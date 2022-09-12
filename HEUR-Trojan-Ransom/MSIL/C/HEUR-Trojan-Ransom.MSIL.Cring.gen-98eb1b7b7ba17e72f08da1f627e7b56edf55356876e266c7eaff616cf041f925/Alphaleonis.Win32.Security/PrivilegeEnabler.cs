using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Alphaleonis.Win32.Security;

public sealed class PrivilegeEnabler : IDisposable
{
	private readonly List<InternalPrivilegeEnabler> _enabledPrivileges = new List<InternalPrivilegeEnabler>();

	public IEnumerable<Privilege> EnabledPrivileges => from priv in _enabledPrivileges
		where priv.EnabledPrivilege != null
		select priv.EnabledPrivilege;

	public PrivilegeEnabler(Privilege privilege, params Privilege[] privileges)
	{
		_enabledPrivileges.Add(new InternalPrivilegeEnabler(privilege));
		if (privileges != null)
		{
			foreach (Privilege privilegeName in privileges)
			{
				_enabledPrivileges.Add(new InternalPrivilegeEnabler(privilegeName));
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public void Dispose()
	{
		foreach (InternalPrivilegeEnabler enabledPrivilege in _enabledPrivileges)
		{
			try
			{
				enabledPrivilege.Dispose();
			}
			catch
			{
			}
		}
	}
}
