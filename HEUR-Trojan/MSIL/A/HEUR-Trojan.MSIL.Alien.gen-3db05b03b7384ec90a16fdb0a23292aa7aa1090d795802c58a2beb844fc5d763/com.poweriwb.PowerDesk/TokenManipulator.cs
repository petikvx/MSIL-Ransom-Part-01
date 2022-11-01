using System;
using System.Runtime.InteropServices;

namespace com.poweriwb.PowerDesk;

internal static class TokenManipulator
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct TokPriv1Luid
	{
		public int Count;

		public long Luid;

		public int Attr;
	}

	internal const int SE_PRIVILEGE_DISABLED = 0;

	internal const int SE_PRIVILEGE_ENABLED = 2;

	internal const int TOKEN_QUERY = 8;

	internal const int TOKEN_ADJUST_PRIVILEGES = 32;

	internal const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

	internal const string SE_AUDIT_NAME = "SeAuditPrivilege";

	internal const string SE_BACKUP_NAME = "SeBackupPrivilege";

	internal const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

	internal const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";

	internal const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

	internal const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

	internal const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

	internal const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

	internal const string SE_DEBUG_NAME = "SeDebugPrivilege";

	internal const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";

	internal const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";

	internal const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

	internal const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

	internal const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";

	internal const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

	internal const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

	internal const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

	internal const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";

	internal const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

	internal const string SE_RELABEL_NAME = "SeRelabelPrivilege";

	internal const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

	internal const string SE_RESTORE_NAME = "SeRestorePrivilege";

	internal const string SE_SECURITY_NAME = "SeSecurityPrivilege";

	internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	internal const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";

	internal const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

	internal const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

	internal const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

	internal const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

	internal const string SE_TCB_NAME = "SeTcbPrivilege";

	internal const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";

	internal const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";

	internal const string SE_UNDOCK_NAME = "SeUndockPrivilege";

	internal const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

	public static bool AddPrivilege(string privilege)
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			IntPtr phtok = IntPtr.Zero;
			OpenProcessToken(currentProcess, 40, ref phtok);
			TokPriv1Luid newst = default(TokPriv1Luid);
			newst.Count = 1;
			newst.Luid = 0L;
			newst.Attr = 2;
			LookupPrivilegeValue(null, privilege, ref newst.Luid);
			return AdjustTokenPrivileges(phtok, disall: false, ref newst, 0, IntPtr.Zero, IntPtr.Zero);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public static bool RemovePrivilege(string privilege)
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			IntPtr phtok = IntPtr.Zero;
			OpenProcessToken(currentProcess, 40, ref phtok);
			TokPriv1Luid newst = default(TokPriv1Luid);
			newst.Count = 1;
			newst.Luid = 0L;
			newst.Attr = 0;
			LookupPrivilegeValue(null, privilege, ref newst.Luid);
			return AdjustTokenPrivileges(phtok, disall: false, ref newst, 0, IntPtr.Zero, IntPtr.Zero);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
}
