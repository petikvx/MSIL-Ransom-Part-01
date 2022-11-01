using System;
using System.Runtime.InteropServices;
using System.Text;

namespace YullySpoofer;

public class TokenManipulation
{
	[Flags]
	internal enum AccessTypeMasks
	{
		SpecificRightsAll = 0xFFFF,
		Delete = 0x10000,
		ReadControl = 0x20000,
		StandardRightsExecute = 0x20000,
		StandardRightsRead = 0x20000,
		StandardRightsWrite = 0x20000,
		WriteDAC = 0x40000,
		WriteOwner = 0x80000,
		StandardRightsRequired = 0xF0000,
		Synchronize = 0x100000,
		StandardRightsAll = 0x1F0000
	}

	public struct LUID
	{
		public int lowPart;

		public int highPart;
	}

	public struct LUID_AND_ATTRIBUTES
	{
		public LUID Luid;

		public int Attributes;
	}

	[Flags]
	public enum PrivilegeAttributes
	{
		UsedForAccess = int.MinValue,
		Disabled = 0,
		EnabledByDefault = 1,
		Enabled = 2,
		Removed = 4
	}

	public struct TOKEN_PRIVILEGES
	{
		public int PrivilegeCount;

		public LUID_AND_ATTRIBUTES[] Privileges;
	}

	[Flags]
	public enum TokenAccessRights
	{
		AssignPrimary = 0,
		Duplicate = 1,
		Impersonate = 4,
		Query = 8,
		QuerySource = 0x10,
		AdjustPrivileges = 0x20,
		AdjustGroups = 0x40,
		AdjustDefault = 0x80,
		AdjustSessionId = 0x100,
		Execute = 0x20004,
		Read = 0x20008,
		Write = 0x200E0,
		AllAccess = 0xF01FD
	}

	public const string CreateToken = "SeCreateTokenPrivilege";

	public const string AssignPrimaryToken = "SeAssignPrimaryTokenPrivilege";

	public const string LockMemory = "SeLockMemoryPrivilege";

	public const string IncreaseQuota = "SeIncreaseQuotaPrivilege";

	public const string UnsolicitedInput = "SeUnsolicitedInputPrivilege";

	public const string MachineAccount = "SeMachineAccountPrivilege";

	public const string TrustedComputingBase = "SeTcbPrivilege";

	public const string Security = "SeSecurityPrivilege";

	public const string TakeOwnership = "SeTakeOwnershipPrivilege";

	public const string LoadDriver = "SeLoadDriverPrivilege";

	public const string SystemProfile = "SeSystemProfilePrivilege";

	public const string SystemTime = "SeSystemtimePrivilege";

	public const string ProfileSingleProcess = "SeProfileSingleProcessPrivilege";

	public const string IncreaseBasePriority = "SeIncreaseBasePriorityPrivilege";

	public const string CreatePageFile = "SeCreatePagefilePrivilege";

	public const string CreatePermanent = "SeCreatePermanentPrivilege";

	public const string Backup = "SeBackupPrivilege";

	public const string Restore = "SeRestorePrivilege";

	public const string Shutdown = "SeShutdownPrivilege";

	public const string Debug = "SeDebugPrivilege";

	public const string Audit = "SeAuditPrivilege";

	public const string SystemEnvironment = "SeSystemEnvironmentPrivilege";

	public const string ChangeNotify = "SeChangeNotifyPrivilege";

	public const string RemoteShutdown = "SeRemoteShutdownPrivilege";

	public const string Undock = "SeUndockPrivilege";

	public const string SyncAgent = "SeSyncAgentPrivilege";

	public const string EnableDelegation = "SeEnableDelegationPrivilege";

	public const string ManageVolume = "SeManageVolumePrivilege";

	public const string Impersonate = "SeImpersonatePrivilege";

	public const string CreateGlobal = "SeCreateGlobalPrivilege";

	public const string TrustedCredentialManagerAccess = "SeTrustedCredManAccessPrivilege";

	public const string ReserveProcessor = "SeReserveProcessorPrivilege";

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool AdjustTokenPrivileges([In] IntPtr accessTokenHandle, [In] bool disableAllPrivileges, [In] ref TOKEN_PRIVILEGES newState, [In] int bufferLength, [In][Out] ref TOKEN_PRIVILEGES previousState, [In][Out] ref int returnLength);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool CloseHandle([In] IntPtr handle);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int GetLastError();

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool LookupPrivilegeName([In] string systemName, [In] ref LUID luid, [In][Out] StringBuilder name, [In][Out] ref int nameLength);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool LookupPrivilegeValue([In] string systemName, [In] string name, [In][Out] ref LUID luid);

	public static bool MySetPrivilege(string sPrivilege, bool enablePrivilege)
	{
		TOKEN_PRIVILEGES newState = default(TOKEN_PRIVILEGES);
		TOKEN_PRIVILEGES previousState = default(TOKEN_PRIVILEGES);
		LUID luid = default(LUID);
		int returnLength = 0;
		IntPtr tokenHandle = IntPtr.Zero;
		if (!OpenProcessToken(GetCurrentProcess(), TokenAccessRights.AllAccess, ref tokenHandle))
		{
			return false;
		}
		if (LookupPrivilegeValue(null, sPrivilege, ref luid))
		{
			newState.PrivilegeCount = 1;
			newState.Privileges = new LUID_AND_ATTRIBUTES[64];
			newState.Privileges[0].Luid = luid;
			if (!enablePrivilege)
			{
				newState.Privileges[0].Attributes = 0;
			}
			else
			{
				newState.Privileges[0].Attributes = 2;
			}
			previousState.PrivilegeCount = 64;
			previousState.Privileges = new LUID_AND_ATTRIBUTES[64];
			return AdjustTokenPrivileges(tokenHandle, disableAllPrivileges: false, ref newState, 16, ref previousState, ref returnLength);
		}
		return false;
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool OpenProcessToken([In] IntPtr processHandle, [In] TokenAccessRights desiredAccess, [In][Out] ref IntPtr tokenHandle);
}
