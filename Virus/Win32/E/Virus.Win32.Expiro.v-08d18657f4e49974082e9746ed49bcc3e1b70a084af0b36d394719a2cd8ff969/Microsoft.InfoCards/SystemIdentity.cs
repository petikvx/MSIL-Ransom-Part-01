using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class SystemIdentity : IDisposable
{
	private bool m_isDisposed;

	private WindowsIdentity m_identity;

	private object m_sync;

	public static readonly IdentityReference LsaIdentityReference = new SecurityIdentifier("SY");

	public SystemIdentity(bool throwIfAlreadySystem)
	{
		m_sync = new object();
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		if (current.IsSystem && throwIfAlreadySystem)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("UserIdentityEqualSystemNotSupported")));
		}
		if (!current.IsSystem)
		{
			m_identity = current;
			if (!NativeMethods.RevertToSelf())
			{
				InfoCardTrace.Assert(false, "Identity management failure", new object[0]);
			}
		}
		else
		{
			InfoCardTrace.Assert(null == m_identity, "m_identity should be null when we are system and throwIfAlreadySystem == false", new object[0]);
		}
	}

	void IDisposable.Dispose()
	{
		if (m_isDisposed)
		{
			return;
		}
		lock (m_sync)
		{
			if (m_isDisposed)
			{
				return;
			}
			m_isDisposed = true;
			if (m_identity != null)
			{
				if (!NativeMethods.ImpersonateLoggedOnUser(m_identity.Token))
				{
					int hRForLastWin32Error = Marshal.GetHRForLastWin32Error();
					InfoCardTrace.FailFast(string.Format(CultureInfo.InvariantCulture, SR.GetString("StoreImpersonateLoggedOnUserFailed"), new object[1] { hRForLastWin32Error }));
				}
				m_identity.Dispose();
			}
		}
	}
}
