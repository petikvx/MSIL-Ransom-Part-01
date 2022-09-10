using System;
using System.IO;
using System.Management;
using System.Threading;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class RemoteHelper
{
	private static class InputParameters
	{
		public const string CommandLine = "CommandLine";
	}

	private static class OutputParameters
	{
		public const string ProcessId = "ProcessID";

		public const string ReturnValue = "ReturnValue";
	}

	private const int autoEventTimeout = 90000;

	private const int delayInAutoEventTimeout = 400;

	private const string MethodCreate = "Create";

	private const string QueryProcessExitEvent = "SELECT * FROM Win32_ProcessStopTrace";

	private string machineName;

	private ManagementClass processClass;

	private ManagementScope managementScope;

	internal RemoteHelper(string machineName)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		this.machineName = machineName;
		ConnectionOptions val = new ConnectionOptions();
		val.set_Authentication((AuthenticationLevel)6);
		val.set_Impersonation((ImpersonationLevel)3);
		managementScope = new ManagementScope("\\\\" + machineName + "\\root\\cimv2", val);
		ManagementPath val2 = new ManagementPath("Win32_Process");
		ObjectGetOptions val3 = new ObjectGetOptions(new ManagementNamedValueCollection(), TimeSpan.FromSeconds(15.0), false);
		processClass = new ManagementClass(managementScope, val2, val3);
	}

	internal void ExecuteWsatProcess(string arguments)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		Utilities.Log("ExecuteWsatProcess(" + arguments + ")");
		ProcessStopTraceHandler processStopTraceHandler;
		try
		{
			ManagementBaseObject methodParameters = ((ManagementObject)processClass).GetMethodParameters("Create");
			methodParameters.set_Item("CommandLine", (object)(GetDeploymentPath() + " " + arguments));
			WqlEventQuery val = new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace");
			ManagementEventWatcher val2 = new ManagementEventWatcher(managementScope, (EventQuery)(object)val);
			processStopTraceHandler = new ProcessStopTraceHandler();
			val2.add_EventArrived(new EventArrivedEventHandler(processStopTraceHandler.Arrived));
			val2.Start();
			ManagementBaseObject val3 = ((ManagementObject)processClass).InvokeMethod("Create", methodParameters, (InvokeMethodOptions)null);
			if (val3.get_Properties().get_Item("ProcessID").get_Value() == null || val3.get_Properties().get_Item("ReturnValue").get_Value() == null)
			{
				throw new WsatAdminException(WsatAdminErrorCode.REMOTE_MISSING_WSAT, SR.GetString("ErrorRemoteWSATMissing"));
			}
			uint processId = (uint)val3.get_Properties().get_Item("ProcessID").get_Value();
			if ((uint)val3.get_Properties().get_Item("ReturnValue").get_Value() != 0)
			{
				throw new WsatAdminException(WsatAdminErrorCode.REMOTE_MISSING_WSAT, SR.GetString("ErrorRemoteWSATMissing"));
			}
			processStopTraceHandler.ProcessId = processId;
			int num = 0;
			while (!processStopTraceHandler.IsArrived && num < 90000)
			{
				num += 400;
				Thread.Sleep(400);
			}
			val2.Stop();
		}
		catch (WsatAdminException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			if (Utilities.IsCriticalException(ex2))
			{
				throw;
			}
			throw new WsatAdminException(WsatAdminErrorCode.REMOTE_EXECUTION_ATTEMPT_ERROR, SR.GetString("ErrorAttemptRemoteExecution", ex2.Message));
		}
		if (processStopTraceHandler.IsArrived && processStopTraceHandler.ReturnCode != 0)
		{
			throw new WsatAdminException((WsatAdminErrorCode)processStopTraceHandler.ReturnCode, SR.GetString("ErrorRemoteExecution", processStopTraceHandler.ReturnCode));
		}
		if (!processStopTraceHandler.IsArrived)
		{
			throw new WsatAdminException(WsatAdminErrorCode.REMOTE_TIMEOUT, SR.GetString("ErrorRemoteTimeout"));
		}
		Utilities.Log("ExecuteWSATProcess successfully quitted.");
	}

	internal string GetDeploymentPath()
	{
		string text = null;
		try
		{
			RegistryConfigurationProvider registryConfigurationProvider = new RegistryConfigurationProvider(RegistryHive.LocalMachine, "Software\\Microsoft\\NET Framework Setup\\NDP\\v3.0\\Setup\\Windows Communication Foundation\\", machineName);
			text = registryConfigurationProvider.ReadString("RuntimeInstallPath", null);
			if (string.IsNullOrEmpty(text))
			{
				throw new WsatAdminException(WsatAdminErrorCode.CANNOT_GET_REMOTE_INSTALL_PATH, SR.GetString("ErrorCannotGetRemoteInstallPath"));
			}
			return Path.Combine(text, "WsatConfig.exe");
		}
		catch (WsatAdminException innerException)
		{
			throw new WsatAdminException(WsatAdminErrorCode.CANNOT_GET_REMOTE_INSTALL_PATH, SR.GetString("ErrorCannotGetRemoteInstallPath"), innerException);
		}
		catch (ArgumentException innerException2)
		{
			throw new WsatAdminException(WsatAdminErrorCode.CANNOT_GET_REMOTE_INSTALL_PATH, SR.GetString("ErrorCannotGetRemoteInstallPath"), innerException2);
		}
	}
}
