using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace CiscoAnyconnectControl.Utility;

public static class ServiceUtil
{
	[Flags]
	public enum ServiceManagerRights
	{
		Connect = 1,
		CreateService = 2,
		EnumerateService = 4,
		Lock = 8,
		QueryLockStatus = 0x10,
		ModifyBootConfig = 0x20,
		StandardRightsRequired = 0xF0000,
		AllAccess = 0xF003F
	}

	[Flags]
	public enum ServiceRights
	{
		QueryConfig = 1,
		ChangeConfig = 2,
		QueryStatus = 4,
		EnumerateDependants = 8,
		Start = 0x10,
		Stop = 0x20,
		PauseContinue = 0x40,
		Interrogate = 0x80,
		UserDefinedControl = 0x100,
		Delete = 0x10000,
		StandardRightsRequired = 0xF0000,
		AllAccess = 0xF01FF
	}

	public enum ServiceBootFlag
	{
		Start,
		SystemStart,
		AutoStart,
		DemandStart,
		Disabled
	}

	public enum ServiceState
	{
		Unknown = -1,
		NotFound,
		Stop,
		Run,
		Stopping,
		Starting
	}

	public enum ServiceControl
	{
		Stop = 1,
		Pause,
		Continue,
		Interrogate,
		Shutdown,
		ParamChange,
		NetBindAdd,
		NetBindRemove,
		NetBindEnable,
		NetBindDisable
	}

	public enum ServiceError
	{
		Ignore,
		Normal,
		Severe,
		Critical
	}

	public enum ServiceConfig
	{
		ServiceConfidDelayedAutoStartInfo = 3,
		Description = 1,
		FailiureActions = 2,
		FailiureActionFlag = 4,
		PreferredNode = 9,
		PreshutdownInfo = 7,
		RequiredPrivilegesInfo = 6,
		ServiceSidInfo = 5,
		TriggerInfo = 8,
		LaunchProtected = 12
	}

	[StructLayout(LayoutKind.Sequential)]
	private class SERVICE_DESCRIPTION
	{
		public string lpDescription;
	}

	[StructLayout(LayoutKind.Sequential)]
	private class SERVICE_STATUS
	{
		public int dwServiceType = 0;

		public ServiceState dwCurrentState = ServiceState.NotFound;

		public int dwControlsAccepted = 0;

		public int dwWin32ExitCode = 0;

		public int dwServiceSpecificExitCode = 0;

		public int dwCheckPoint = 0;

		public int dwWaitHint = 0;
	}

	private const int STANDARD_RIGHTS_REQUIRED = 983040;

	private const int SERVICE_WIN32_OWN_PROCESS = 16;

	public static ServiceController[] List => null;

	public static string GetEnvironment(string name, bool ExpandVariables = true)
	{
		if (!ExpandVariables)
		{
			return (string)ServiceUtil.smethod_2(ServiceUtil.smethod_1(Registry.LocalMachine, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment\\"), name, (object)"", RegistryValueOptions.DoNotExpandEnvironmentNames);
		}
		return ServiceUtil.smethod_0(name);
	}

	public static void SetEnvironment(string name, string value)
	{
		ServiceUtil.smethod_3(name, value);
	}

	public static void Start(string serviceName, int timeoutMilliseconds)
	{
	}

	public static void Stop(string serviceName, int timeoutMilliseconds)
	{
	}

	public static void Restart(string serviceName, int timeoutMilliseconds)
	{
	}

	public static bool IsInstalled(string serviceName)
	{
		return false;
	}

	[DllImport("advapi32.dll")]
	private static extern IntPtr OpenSCManagerA(string lpMachineName, string lpDatabaseName, ServiceManagerRights dwDesiredAccess);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi)]
	private static extern IntPtr OpenServiceA(IntPtr hSCManager, string lpServiceName, ServiceRights dwDesiredAccess);

	[DllImport("advapi32.dll")]
	private static extern IntPtr CreateServiceA(IntPtr hSCManager, string lpServiceName, string lpDisplayName, ServiceRights dwDesiredAccess, int dwServiceType, ServiceBootFlag dwStartType, ServiceError dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, IntPtr lpdwTagId, string lpDependencies, string lp, string lpPassword);

	[DllImport("advapi32.dll")]
	private static extern int CloseServiceHandle(IntPtr hSCObject);

	[DllImport("advapi32.dll")]
	private static extern int QueryServiceStatus(IntPtr hService, SERVICE_STATUS lpServiceStatus);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int DeleteService(IntPtr hService);

	[DllImport("advapi32.dll")]
	private static extern int ControlService(IntPtr hService, ServiceControl dwControl, SERVICE_STATUS lpServiceStatus);

	[DllImport("advapi32.dll")]
	private static extern int StartServiceA(IntPtr hService, int dwNumServiceArgs, int lpServiceArgVectors);

	[DllImport("advapi32.dll")]
	private static extern int ChangeServiceConfig2(IntPtr hService, ServiceConfig dwInfoLevel, object lpInfo);

	public static void Uninstall(string ServiceName)
	{
		IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
		try
		{
			IntPtr intPtr2 = OpenServiceA(intPtr, ServiceName, ServiceRights.StandardRightsRequired | ServiceRights.QueryStatus | ServiceRights.Stop);
			if (!(intPtr2 == IntPtr.Zero))
			{
				try
				{
					StopService(intPtr2);
					if (DeleteService(intPtr2) == 0)
					{
						throw ServiceUtil.smethod_4(ServiceUtil.smethod_6("Could not delete service ", ServiceUtil.smethod_5().ToString()));
					}
					return;
				}
				finally
				{
					CloseServiceHandle(intPtr2);
				}
			}
			throw ServiceUtil.smethod_4("Service not installed.");
		}
		finally
		{
			CloseServiceHandle(intPtr);
		}
	}

	public static bool ServiceIsInstalled(string ServiceName)
	{
		IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
		try
		{
			IntPtr intPtr2 = OpenServiceA(intPtr, ServiceName, ServiceRights.QueryStatus);
			if (!(intPtr2 == IntPtr.Zero))
			{
				CloseServiceHandle(intPtr2);
				return true;
			}
			return false;
		}
		finally
		{
			CloseServiceHandle(intPtr);
		}
	}

	public static void InstallAndStart(string ServiceName, string DisplayName, string FileName, string Dependencies = null, string Description = null)
	{
		IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect | ServiceManagerRights.CreateService);
		try
		{
			IntPtr intPtr2 = OpenServiceA(intPtr, ServiceName, ServiceRights.QueryStatus | ServiceRights.Start);
			if (intPtr2 == IntPtr.Zero)
			{
				intPtr2 = CreateServiceA(intPtr, ServiceName, DisplayName, ServiceRights.QueryStatus | ServiceRights.Start, 16, ServiceBootFlag.AutoStart, ServiceError.Normal, FileName, null, IntPtr.Zero, Dependencies, null, null);
			}
			if (!(intPtr2 == IntPtr.Zero))
			{
				SERVICE_DESCRIPTION lpInfo = new SERVICE_DESCRIPTION
				{
					lpDescription = Description
				};
				ChangeServiceConfig2(intPtr2, ServiceConfig.Description, lpInfo);
				try
				{
					StartService(intPtr2);
					return;
				}
				finally
				{
					CloseServiceHandle(intPtr2);
				}
			}
			throw ServiceUtil.smethod_4("Failed to install service.");
		}
		finally
		{
			CloseServiceHandle(intPtr);
		}
	}

	public static void StartService(string Name)
	{
		IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
		try
		{
			IntPtr intPtr2 = OpenServiceA(intPtr, Name, ServiceRights.QueryStatus | ServiceRights.Start);
			if (intPtr2 == IntPtr.Zero)
			{
				throw ServiceUtil.smethod_4("Could not open service.");
			}
			try
			{
				StartService(intPtr2);
			}
			finally
			{
				CloseServiceHandle(intPtr2);
			}
		}
		finally
		{
			CloseServiceHandle(intPtr);
		}
	}

	public static void StopService(string Name)
	{
		IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
		try
		{
			IntPtr intPtr2 = OpenServiceA(intPtr, Name, ServiceRights.QueryStatus | ServiceRights.Stop);
			if (intPtr2 == IntPtr.Zero)
			{
				throw ServiceUtil.smethod_4("Could not open service.");
			}
			try
			{
				StopService(intPtr2);
			}
			finally
			{
				CloseServiceHandle(intPtr2);
			}
		}
		finally
		{
			CloseServiceHandle(intPtr);
		}
	}

	public static void RestartService(string Name)
	{
		IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
		try
		{
			IntPtr intPtr2 = OpenServiceA(intPtr, Name, ServiceRights.QueryStatus | ServiceRights.Start | ServiceRights.Stop);
			if (!(intPtr2 == IntPtr.Zero))
			{
				try
				{
					RestartService(intPtr2);
					return;
				}
				finally
				{
					CloseServiceHandle(intPtr2);
				}
			}
			throw ServiceUtil.smethod_4("Could not open service.");
		}
		finally
		{
			CloseServiceHandle(intPtr);
		}
	}

	private static void StartService(IntPtr hService)
	{
		new SERVICE_STATUS();
		StartServiceA(hService, 0, 0);
		WaitForServiceStatus(hService, ServiceState.Starting, ServiceState.Run);
	}

	private static void StopService(IntPtr hService)
	{
		SERVICE_STATUS lpServiceStatus = new SERVICE_STATUS();
		ControlService(hService, ServiceControl.Stop, lpServiceStatus);
		WaitForServiceStatus(hService, ServiceState.Stopping, ServiceState.Stop);
	}

	private static void RestartService(IntPtr hService)
	{
		StopService(hService);
		StartService(hService);
	}

	public static ServiceState GetServiceStatus(string ServiceName)
	{
		IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
		try
		{
			IntPtr intPtr2 = OpenServiceA(intPtr, ServiceName, ServiceRights.QueryStatus);
			if (!(intPtr2 == IntPtr.Zero))
			{
				try
				{
					return GetServiceStatus(intPtr2);
				}
				finally
				{
					CloseServiceHandle(intPtr);
				}
			}
			return ServiceState.NotFound;
		}
		finally
		{
			CloseServiceHandle(intPtr);
		}
	}

	private static ServiceState GetServiceStatus(IntPtr hService)
	{
		SERVICE_STATUS sERVICE_STATUS = new SERVICE_STATUS();
		if (QueryServiceStatus(hService, sERVICE_STATUS) == 0)
		{
			throw ServiceUtil.smethod_4("Failed to query service status.");
		}
		return sERVICE_STATUS.dwCurrentState;
	}

	private static bool WaitForServiceStatus(IntPtr hService, ServiceState WaitStatus, ServiceState DesiredStatus)
	{
		SERVICE_STATUS sERVICE_STATUS = new SERVICE_STATUS();
		QueryServiceStatus(hService, sERVICE_STATUS);
		if (sERVICE_STATUS.dwCurrentState != DesiredStatus)
		{
			int num = ServiceUtil.smethod_7();
			int dwCheckPoint = sERVICE_STATUS.dwCheckPoint;
			while (sERVICE_STATUS.dwCurrentState == WaitStatus)
			{
				int num2 = sERVICE_STATUS.dwWaitHint / 10;
				if (num2 < 1000)
				{
					num2 = 1000;
				}
				else if (num2 > 10000)
				{
					num2 = 10000;
				}
				ServiceUtil.smethod_8(num2);
				if (QueryServiceStatus(hService, sERVICE_STATUS) == 0)
				{
					break;
				}
				if (sERVICE_STATUS.dwCheckPoint > dwCheckPoint)
				{
					num = ServiceUtil.smethod_7();
					dwCheckPoint = sERVICE_STATUS.dwCheckPoint;
				}
				else if (ServiceUtil.smethod_7() - num > sERVICE_STATUS.dwWaitHint)
				{
					break;
				}
			}
			return sERVICE_STATUS.dwCurrentState == DesiredStatus;
		}
		return true;
	}

	private static IntPtr OpenSCManager(ServiceManagerRights Rights)
	{
		IntPtr intPtr = OpenSCManagerA(null, null, Rights);
		if (intPtr == IntPtr.Zero)
		{
			throw ServiceUtil.smethod_4("Could not connect to service control manager.");
		}
		return intPtr;
	}

	static string smethod_0(string string_0)
	{
		return Environment.GetEnvironmentVariable(string_0);
	}

	static RegistryKey smethod_1(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.OpenSubKey(string_0);
	}

	static object smethod_2(RegistryKey registryKey_0, string string_0, object object_0, RegistryValueOptions registryValueOptions_0)
	{
		return registryKey_0.GetValue(string_0, object_0, registryValueOptions_0);
	}

	static void smethod_3(string string_0, string string_1)
	{
		Environment.SetEnvironmentVariable(string_0, string_1);
	}

	static ApplicationException smethod_4(string string_0)
	{
		return new ApplicationException(string_0);
	}

	static int smethod_5()
	{
		return Marshal.GetLastWin32Error();
	}

	static string smethod_6(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static int smethod_7()
	{
		return Environment.TickCount;
	}

	static void smethod_8(int int_0)
	{
		Thread.Sleep(int_0);
	}
}
