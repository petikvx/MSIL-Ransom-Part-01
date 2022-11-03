using System;
using System.Runtime.InteropServices;

namespace CosmosKey.Utils;

public static class TokenManipulator
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

	public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

	public const string SE_AUDIT_NAME = "SeAuditPrivilege";

	public const string SE_BACKUP_NAME = "SeBackupPrivilege";

	public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

	public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";

	public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

	public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

	public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

	public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

	public const string SE_DEBUG_NAME = "SeDebugPrivilege";

	public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";

	public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";

	public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

	public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

	public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";

	public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

	public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

	public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

	public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";

	public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

	public const string SE_RELABEL_NAME = "SeRelabelPrivilege";

	public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

	public const string SE_RESTORE_NAME = "SeRestorePrivilege";

	public const string SE_SECURITY_NAME = "SeSecurityPrivilege";

	public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";

	public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

	public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

	public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

	public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

	public const string SE_TCB_NAME = "SeTcbPrivilege";

	public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";

	public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";

	public const string SE_UNDOCK_NAME = "SeUndockPrivilege";

	public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

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
