using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace NotRansom_StopCtypt;

internal class Class1
{
	public static void EnablePrivilege(SecurityEntity securityEntity)
	{
		if (!Enum.IsDefined(typeof(SecurityEntity), securityEntity))
		{
			throw new InvalidEnumArgumentException("securityEntity", (int)securityEntity, typeof(SecurityEntity));
		}
		string securityEntityValue = GetSecurityEntityValue(securityEntity);
		try
		{
			NativeMethods.LUID lpLuid = default(NativeMethods.LUID);
			if (NativeMethods.LookupPrivilegeValue(null, securityEntityValue, ref lpLuid))
			{
				NativeMethods.TOKEN_PRIVILEGES newstate = default(NativeMethods.TOKEN_PRIVILEGES);
				newstate.PrivilegeCount = 1;
				newstate.Attributes = 2;
				newstate.Luid = lpLuid;
				IntPtr tokenHandle = IntPtr.Zero;
				try
				{
					IntPtr currentProcess = NativeMethods.GetCurrentProcess();
					if (NativeMethods.OpenProcessToken(currentProcess, 40u, out tokenHandle))
					{
						if (NativeMethods.AdjustTokenPrivileges(tokenHandle, disableAllPrivileges: false, ref newstate, 1024u, IntPtr.Zero, IntPtr.Zero))
						{
							if (Marshal.GetLastWin32Error() == 1300)
							{
								Win32Exception innerException = new Win32Exception();
								throw new InvalidOperationException("AdjustTokenPrivileges failed.", innerException);
							}
							return;
						}
						Win32Exception innerException2 = new Win32Exception();
						throw new InvalidOperationException("AdjustTokenPrivileges failed.", innerException2);
					}
					Win32Exception innerException3 = new Win32Exception();
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "OpenProcessToken failed. CurrentProcess: {0}", currentProcess.ToInt32()), innerException3);
				}
				finally
				{
					if (tokenHandle != IntPtr.Zero)
					{
						NativeMethods.CloseHandle(tokenHandle);
					}
				}
			}
			Win32Exception innerException4 = new Win32Exception();
			throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "LookupPrivilegeValue failed. SecurityEntityValue: {0}", securityEntityValue), innerException4);
		}
		catch (Exception innerException5)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "GrandPrivilege failed. SecurityEntity: {0}", securityEntityValue), innerException5);
		}
	}

	private static string GetSecurityEntityValue(SecurityEntity securityEntity)
	{
		return securityEntity switch
		{
			SecurityEntity.SE_CREATE_TOKEN_NAME => "SeCreateTokenPrivilege", 
			SecurityEntity.SE_ASSIGNPRIMARYTOKEN_NAME => "SeAssignPrimaryTokenPrivilege", 
			SecurityEntity.SE_LOCK_MEMORY_NAME => "SeLockMemoryPrivilege", 
			SecurityEntity.SE_INCREASE_QUOTA_NAME => "SeIncreaseQuotaPrivilege", 
			SecurityEntity.SE_MACHINE_ACCOUNT_NAME => "SeMachineAccountPrivilege", 
			SecurityEntity.SE_TCB_NAME => "SeTcbPrivilege", 
			SecurityEntity.SE_SECURITY_NAME => "SeSecurityPrivilege", 
			SecurityEntity.SE_TAKE_OWNERSHIP_NAME => "SeTakeOwnershipPrivilege", 
			SecurityEntity.SE_LOAD_DRIVER_NAME => "SeLoadDriverPrivilege", 
			SecurityEntity.SE_SYSTEM_PROFILE_NAME => "SeSystemProfilePrivilege", 
			SecurityEntity.SE_SYSTEMTIME_NAME => "SeSystemtimePrivilege", 
			SecurityEntity.SE_PROF_SINGLE_PROCESS_NAME => "SeProfileSingleProcessPrivilege", 
			SecurityEntity.SE_INC_BASE_PRIORITY_NAME => "SeIncreaseBasePriorityPrivilege", 
			SecurityEntity.SE_CREATE_PAGEFILE_NAME => "SeCreatePagefilePrivilege", 
			SecurityEntity.SE_CREATE_PERMANENT_NAME => "SeCreatePermanentPrivilege", 
			SecurityEntity.SE_BACKUP_NAME => "SeBackupPrivilege", 
			SecurityEntity.SE_RESTORE_NAME => "SeRestorePrivilege", 
			SecurityEntity.SE_SHUTDOWN_NAME => "SeShutdownPrivilege", 
			SecurityEntity.SE_DEBUG_NAME => "SeDebugPrivilege", 
			SecurityEntity.SE_AUDIT_NAME => "SeAuditPrivilege", 
			SecurityEntity.SE_SYSTEM_ENVIRONMENT_NAME => "SeSystemEnvironmentPrivilege", 
			SecurityEntity.SE_CHANGE_NOTIFY_NAME => "SeChangeNotifyPrivilege", 
			SecurityEntity.SE_REMOTE_SHUTDOWN_NAME => "SeRemoteShutdownPrivilege", 
			SecurityEntity.SE_UNDOCK_NAME => "SeUndockPrivilege", 
			SecurityEntity.SE_SYNC_AGENT_NAME => "SeSyncAgentPrivilege", 
			SecurityEntity.SE_ENABLE_DELEGATION_NAME => "SeEnableDelegationPrivilege", 
			SecurityEntity.SE_MANAGE_VOLUME_NAME => "SeManageVolumePrivilege", 
			SecurityEntity.SE_IMPERSONATE_NAME => "SeImpersonatePrivilege", 
			SecurityEntity.SE_CREATE_GLOBAL_NAME => "SeCreateGlobalPrivilege", 
			SecurityEntity.SE_CREATE_SYMBOLIC_LINK_NAME => "SeCreateSymbolicLinkPrivilege", 
			SecurityEntity.SE_INC_WORKING_SET_NAME => "SeIncreaseWorkingSetPrivilege", 
			SecurityEntity.SE_RELABEL_NAME => "SeRelabelPrivilege", 
			SecurityEntity.SE_TIME_ZONE_NAME => "SeTimeZonePrivilege", 
			SecurityEntity.SE_TRUSTED_CREDMAN_ACCESS_NAME => "SeTrustedCredManAccessPrivilege", 
			_ => throw new ArgumentOutOfRangeException(typeof(SecurityEntity).Name), 
		};
	}
}
