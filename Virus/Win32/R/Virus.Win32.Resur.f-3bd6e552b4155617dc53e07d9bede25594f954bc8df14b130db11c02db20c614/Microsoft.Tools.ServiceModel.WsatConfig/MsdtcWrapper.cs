using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class MsdtcWrapper
{
	private static class NetworkDtcAccessRegValues
	{
		public const string NetworkDtcAccess = "NetworkDtcAccess";

		public const string NetworkDtcAccessInbound = "NetworkDtcAccessInbound";

		public const string NetworkDtcAccessOutbound = "NetworkDtcAccessOutbound";

		public const string NetworkDtcAccessTransactions = "NetworkDtcAccessTransactions";
	}

	private static Dictionary<string, MsdtcWrapper> wrappers = new Dictionary<string, MsdtcWrapper>();

	private static Guid IDtcNetworkAccessConfigInterfaceId = typeof(IDtcNetworkAccessConfig).GUID;

	private IDtcNetworkAccessConfig proxy;

	private ConfigurationProvider configProvider;

	private ServiceController controller;

	private string machineName;

	private string virtualServerName;

	private static string GetTransactionManagerHostName(string machineName, string virtualServerName)
	{
		if (MsdtcClusterUtils.IsClusterServer(machineName))
		{
			if (!string.IsNullOrEmpty(virtualServerName))
			{
				return virtualServerName;
			}
			if (!Utilities.IsLocalMachineName(machineName))
			{
				return machineName;
			}
			return Utilities.LocalHostName;
		}
		if (!Utilities.IsLocalMachineName(machineName))
		{
			return machineName;
		}
		return string.Empty;
	}

	internal static MsdtcWrapper GetWrapper(string machineName, string virtualServerName, ConfigurationProvider configProvider)
	{
		string transactionManagerHostName = GetTransactionManagerHostName(machineName, virtualServerName);
		wrappers.TryGetValue(transactionManagerHostName, out var value);
		if (value == null)
		{
			value = new MsdtcWrapper(machineName, virtualServerName, configProvider);
			wrappers.Add(transactionManagerHostName, value);
		}
		return value;
	}

	private MsdtcWrapper(string machineName, string virtualServerName, ConfigurationProvider configProvider)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		if (configProvider == null)
		{
			throw new ArgumentNullException("configProvider");
		}
		this.machineName = machineName;
		this.virtualServerName = virtualServerName;
		this.configProvider = configProvider;
		proxy = null;
		string transactionManagerHostName = GetTransactionManagerHostName(machineName, virtualServerName);
		int num;
		if (IsLongHornClusterLocalDtc(machineName, virtualServerName))
		{
			SafeNativeMethods.OLE_TM_CONFIG_PARAMS_V2 pvConfigParams = new SafeNativeMethods.OLE_TM_CONFIG_PARAMS_V2
			{
				dwVersion = 2u,
				pwszClusterResourceName = "LOCAL"
			};
			num = SafeNativeMethods.DtcGetTransactionManagerEx_1(transactionManagerHostName, string.Empty, ref IDtcNetworkAccessConfigInterfaceId, 0u, ref pvConfigParams, out proxy);
		}
		else
		{
			num = SafeNativeMethods.DtcGetTransactionManagerEx(transactionManagerHostName, string.Empty, ref IDtcNetworkAccessConfigInterfaceId, 0u, IntPtr.Zero, out proxy);
		}
		if (proxy == null)
		{
			Utilities.Log("Unable to query IDtcNetworkAccessConfig" + num);
			if (Utilities.IsLocalMachineName(machineName))
			{
				controller = new ServiceController("MSDTC");
			}
			else
			{
				controller = null;
			}
		}
	}

	private static bool IsLongHornClusterLocalDtc(string machineName, string virtualServerName)
	{
		if (Utilities.GetOSMajor(machineName) > 5 && MsdtcClusterUtils.IsClusterServer(machineName) && string.IsNullOrEmpty(virtualServerName))
		{
			return true;
		}
		return false;
	}

	internal bool GetNetworkTransactionAccess()
	{
		if (proxy != null)
		{
			try
			{
				bool networkTransactionAccess = false;
				proxy.GetNetworkTransactionAccess(ref networkTransactionAccess);
				return networkTransactionAccess;
			}
			catch (COMException ex)
			{
				if (!IsLongHornClusterLocalDtc(machineName, virtualServerName))
				{
					throw new WsatAdminException(WsatAdminErrorCode.CANNOT_GET_MSDTC_NETWORK_ACCESS_SETTING, SR.GetString("ErrorCannotGetMsdtcNetworkAccessSetting", ex.Message), ex);
				}
			}
			catch (UnauthorizedAccessException innerException)
			{
				throw new WsatAdminException(WsatAdminErrorCode.MSDTC_NETWORK_ACCESS_DENIED, SR.GetString("ErrorMsdtcNetworkAccessDenied"), innerException);
			}
			catch (FileNotFoundException innerException2)
			{
				throw new WsatAdminException(WsatAdminErrorCode.CANNOT_GET_MSDTC_NETWORK_ACCESS_SETTING, SR.GetString("ErrorCannotGetMsdtcNetworkAccessSettingWithDiagnostics"), innerException2);
			}
		}
		return DetermineNetworkTransactionAccessByRegistrySettings();
	}

	private bool DetermineNetworkTransactionAccessByRegistrySettings()
	{
		ConfigurationProvider configurationProvider = configProvider.OpenKey("Security\\");
		bool flag = configurationProvider.ReadUInt32("NetworkDtcAccess", 0u) != 0;
		bool flag2 = configurationProvider.ReadUInt32("NetworkDtcAccessInbound", 0u) != 0;
		bool flag3 = configurationProvider.ReadUInt32("NetworkDtcAccessOutbound", 0u) != 0;
		bool result = configurationProvider.ReadUInt32("NetworkDtcAccessTransactions", 0u) != 0;
		if (flag && (flag2 || flag3))
		{
			return result;
		}
		return false;
	}

	internal void RestartDtcService()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		if (proxy != null)
		{
			int num = proxy.RestartDtcService();
			if (num != 0)
			{
				throw new WsatAdminException(WsatAdminErrorCode.DTC_RESTART_ERROR, SR.GetString("ErrorRestartMSDTCWithErrorCode", num));
			}
			return;
		}
		if ((int)controller.get_Status() != 1)
		{
			if ((int)controller.get_Status() != 3)
			{
				if (!controller.get_CanStop())
				{
					throw new WsatAdminException(WsatAdminErrorCode.DTC_RESTART_ERROR, SR.GetString("ErrorRestartMSDTC"));
				}
				controller.Stop();
			}
			controller.WaitForStatus((ServiceControllerStatus)1, TimeSpan.FromSeconds(30.0));
			if ((int)controller.get_Status() != 1)
			{
				throw new WsatAdminException(WsatAdminErrorCode.DTC_RESTART_ERROR, SR.GetString("ErrorRestartMSDTC"));
			}
		}
		controller.Start();
		controller.WaitForStatus((ServiceControllerStatus)4, TimeSpan.FromSeconds(30.0));
		if ((int)controller.get_Status() != 4)
		{
			throw new WsatAdminException(WsatAdminErrorCode.DTC_RESTART_ERROR, SR.GetString("ErrorRestartMSDTC"));
		}
	}
}
