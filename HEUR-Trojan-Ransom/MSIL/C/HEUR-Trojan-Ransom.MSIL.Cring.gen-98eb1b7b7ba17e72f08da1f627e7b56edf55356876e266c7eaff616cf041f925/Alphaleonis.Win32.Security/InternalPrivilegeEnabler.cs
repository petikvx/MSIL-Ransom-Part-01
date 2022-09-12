using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Security;

internal sealed class InternalPrivilegeEnabler : IDisposable
{
	public Privilege EnabledPrivilege { get; private set; }

	[SecurityCritical]
	[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
	public InternalPrivilegeEnabler(Privilege privilegeName)
	{
		if (privilegeName == null)
		{
			throw new ArgumentNullException("privilegeName");
		}
		EnabledPrivilege = privilegeName;
		AdjustPrivilege(enable: true);
	}

	public void Dispose()
	{
		try
		{
			if (EnabledPrivilege != null)
			{
				AdjustPrivilege(enable: false);
			}
		}
		finally
		{
			EnabledPrivilege = null;
		}
	}

	[SecurityCritical]
	private void AdjustPrivilege(bool enable)
	{
		using WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent(TokenAccessLevels.Query | TokenAccessLevels.AdjustPrivileges);
		IntPtr token = windowsIdentity.Token;
		TOKEN_PRIVILEGES previousState = default(TOKEN_PRIVILEGES);
		TOKEN_PRIVILEGES newState = new TOKEN_PRIVILEGES
		{
			PrivilegeCount = 1u,
			Luid = Alphaleonis.Win32.Filesystem.NativeMethods.LongToLuid(EnabledPrivilege.LookupLuid()),
			Attributes = (enable ? 2u : 0u)
		};
		uint returnLength;
		bool num = NativeMethods.AdjustTokenPrivileges(token, disableAllPrivileges: false, ref newState, (uint)Marshal.SizeOf((object)previousState), out previousState, out returnLength);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		if (previousState.PrivilegeCount == 0)
		{
			EnabledPrivilege = null;
		}
	}
}
