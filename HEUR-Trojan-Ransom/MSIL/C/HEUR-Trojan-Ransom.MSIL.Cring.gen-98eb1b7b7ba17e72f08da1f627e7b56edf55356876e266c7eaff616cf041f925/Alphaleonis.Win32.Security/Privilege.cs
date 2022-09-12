using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Security;

[ImmutableObject(true)]
public class Privilege : IEquatable<Privilege>
{
	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege AssignPrimaryToken = new Privilege("SeAssignPrimaryTokenPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Audit = new Privilege("SeAuditPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Backup = new Privilege("SeBackupPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege ChangeNotify = new Privilege("SeChangeNotifyPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege CreateGlobal = new Privilege("SeCreateGlobalPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pagefile")]
	public static readonly Privilege CreatePagefile = new Privilege("SeCreatePagefilePrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege CreatePermanent = new Privilege("SeCreatePermanentPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege CreateSymbolicLink = new Privilege("SeCreateSymbolicLinkPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege CreateToken = new Privilege("SeCreateTokenPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Debug = new Privilege("SeDebugPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege EnableDelegation = new Privilege("SeEnableDelegationPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Impersonate = new Privilege("SeImpersonatePrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege IncreaseBasePriority = new Privilege("SeIncreaseBasePriorityPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege IncreaseQuota = new Privilege("SeIncreaseQuotaPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege IncreaseWorkingSet = new Privilege("SeIncreaseWorkingSetPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege LoadDriver = new Privilege("SeLoadDriverPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege LockMemory = new Privilege("SeLockMemoryPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege MachineAccount = new Privilege("SeMachineAccountPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege ManageVolume = new Privilege("SeManageVolumePrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege ProfileSingleProcess = new Privilege("SeProfileSingleProcessPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Relabel")]
	public static readonly Privilege Relabel = new Privilege("SeRelabelPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege RemoteShutdown = new Privilege("SeRemoteShutdownPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Restore = new Privilege("SeRestorePrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Security = new Privilege("SeSecurityPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Shutdown = new Privilege("SeShutdownPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege SyncAgent = new Privilege("SeSyncAgentPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege SystemEnvironment = new Privilege("SeSystemEnvironmentPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege SystemProfile = new Privilege("SeSystemProfilePrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege SystemTime = new Privilege("SeSystemtimePrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege TakeOwnership = new Privilege("SeTakeOwnershipPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tcb")]
	public static readonly Privilege Tcb = new Privilege("SeTcbPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege TimeZone = new Privilege("SeTimeZonePrivilege");

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Cred")]
	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege TrustedCredManAccess = new Privilege("SeTrustedCredManAccessPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege Undock = new Privilege("SeUndockPrivilege");

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly Privilege UnsolicitedInput = new Privilege("SeUnsolicitedInputPrivilege");

	private readonly string _name;

	private readonly string _systemName;

	public string Name => _name;

	public Privilege(string systemName, Privilege privilege)
	{
		if (Utils.IsNullOrWhiteSpace(systemName))
		{
			throw new ArgumentNullException("systemName", Resources.Privilege_Name_Cannot_Be_Empty);
		}
		_systemName = systemName;
		if (privilege != null)
		{
			_name = privilege._name;
		}
	}

	private Privilege(string name)
	{
		if (Utils.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException("name", Resources.Privilege_Name_Cannot_Be_Empty);
		}
		_name = name;
	}

	[SecurityCritical]
	public string LookupDisplayName()
	{
		uint cchDisplayName = 10u;
		StringBuilder lpDisplayName = new StringBuilder(10);
		uint lpLanguageId;
		bool flag = NativeMethods.LookupPrivilegeDisplayNameW(_systemName, _name, ref lpDisplayName, ref cchDisplayName, out lpLanguageId);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			if (lastWin32Error == 122L)
			{
				lpDisplayName = new StringBuilder((int)(cchDisplayName + 1));
				flag = NativeMethods.LookupPrivilegeDisplayNameW(_systemName, _name, ref lpDisplayName, ref cchDisplayName, out lpLanguageId);
				lastWin32Error = Marshal.GetLastWin32Error();
			}
			if (!flag)
			{
				NativeError.ThrowException(lastWin32Error, _name);
			}
		}
		return lpDisplayName.ToString();
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Luid")]
	public long LookupLuid()
	{
		LUID lpLuid;
		bool num = NativeMethods.LookupPrivilegeValueW(_systemName, _name, out lpLuid);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, _name);
		}
		return Alphaleonis.Win32.Filesystem.NativeMethods.LuidToLong(lpLuid);
	}

	public bool Equals(Privilege other)
	{
		if (other != null && _name.Equals(other._name, StringComparison.OrdinalIgnoreCase))
		{
			if (_systemName == null && other._systemName == null)
			{
				return true;
			}
			if (_systemName != null)
			{
				return _systemName.Equals(other._systemName, StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj != null && (object)GetType() == obj.GetType())
		{
			if (obj is Privilege privilege && _name.Equals(privilege._name, StringComparison.OrdinalIgnoreCase))
			{
				if (_systemName == null && privilege._systemName == null)
				{
					return true;
				}
				if (_systemName != null)
				{
					return _systemName.Equals(privilege._systemName, StringComparison.OrdinalIgnoreCase);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (_name == null)
		{
			return 0;
		}
		return _name.GetHashCode();
	}

	public override string ToString()
	{
		return _name;
	}
}
