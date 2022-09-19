using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskPrincipalPrivilege
{
	SeCreateTokenPrivilege = 1,
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
