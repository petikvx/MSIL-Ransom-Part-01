using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;
using System.ServiceProcess;
using Microsoft.Win32;

namespace System.ServiceModel.Activation;

internal static class SMSvcHost
{
	private static TcpPortSharing netTcpPortSharing;

	private static TcpActivation netTcpActivator;

	private static NamedPipeActivation netPipeActivator;

	private static MsmqActivation netMsmqActivator;

	private static string listenerAdapterNativeLibrary;

	internal static bool IsTcpPortSharingPaused => netTcpPortSharing.IsPaused;

	internal static bool IsTcpActivationPaused => netTcpActivator.IsPaused;

	internal static bool IsNamedPipeActivationPaused => netPipeActivator.IsPaused;

	internal static bool IsWebhostSupported
	{
		get
		{
			bool result = false;
			using RegistryKey registryKey = Registry.LocalMachine;
			using RegistryKey registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\InetSTP");
			if (registryKey2 != null)
			{
				object value = registryKey2.GetValue("MajorVersion");
				if (value != null)
				{
					if (value.GetType().Equals(typeof(int)))
					{
						if ((int)value >= 7)
						{
							return File.Exists(ListenerAdapterNativeLibrary);
						}
						return result;
					}
					return result;
				}
				return result;
			}
			return result;
		}
	}

	internal static string ListenerAdapterNativeLibrary
	{
		get
		{
			if (listenerAdapterNativeLibrary == null)
			{
				listenerAdapterNativeLibrary = Environment.SystemDirectory + "\\inetsrv\\wbhstipm.dll";
			}
			return listenerAdapterNativeLibrary;
		}
	}

	private static void Main(string[] args)
	{
		if (!OSEnvironmentHelper.get_IsVistaOrGreater())
		{
			try
			{
				Utility.KeepOnlyPrivilegeInProcess("SeCreateGlobalPrivilege");
			}
			catch (Win32Exception ex)
			{
				ListenerTraceUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)13, (EventLogEventId)(-1073479673), false, new string[1] { ex.ToString() });
				throw;
			}
		}
		AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
		List<ServiceBase> list = new List<ServiceBase>();
		netTcpPortSharing = new TcpPortSharing();
		list.Add((ServiceBase)(object)netTcpPortSharing);
		if (OSEnvironmentHelper.get_IsVistaOrGreater())
		{
			MainIis7(list);
		}
		ServiceBase.Run(list.ToArray());
	}

	private static void MainIis7(List<ServiceBase> services)
	{
		netTcpActivator = new TcpActivation();
		services.Add((ServiceBase)(object)netTcpActivator);
		netPipeActivator = new NamedPipeActivation();
		services.Add((ServiceBase)(object)netPipeActivator);
		netMsmqActivator = new MsmqActivation();
		services.Add((ServiceBase)(object)netMsmqActivator);
	}

	private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		Exception ex = e.ExceptionObject as Exception;
		ListenerTraceUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)13, (EventLogEventId)(-1073479670), false, new string[1] { (ex == null) ? string.Empty : ex.ToString() });
	}
}
