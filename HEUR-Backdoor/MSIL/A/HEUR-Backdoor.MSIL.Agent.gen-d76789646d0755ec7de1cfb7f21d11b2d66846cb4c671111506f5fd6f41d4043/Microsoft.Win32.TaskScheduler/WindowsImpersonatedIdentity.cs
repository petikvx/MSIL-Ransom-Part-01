using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32.TaskScheduler;

internal class WindowsImpersonatedIdentity : IDisposable, IIdentity
{
	private sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		private SafeTokenHandle()
			: base(ownsHandle: true)
		{
		}

		[DllImport("kernel32.dll")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr handle);

		protected override bool ReleaseHandle()
		{
			return CloseHandle(handle);
		}
	}

	private const int LOGON32_LOGON_INTERACTIVE = 2;

	private const int LOGON32_PROVIDER_DEFAULT = 0;

	private WindowsImpersonationContext impersonationContext;

	private WindowsIdentity identity;

	public string AuthenticationType
	{
		get
		{
			if (identity != null)
			{
				return identity.AuthenticationType;
			}
			return null;
		}
	}

	public bool IsAuthenticated
	{
		get
		{
			if (identity != null)
			{
				return identity.IsAuthenticated;
			}
			return false;
		}
	}

	public string Name
	{
		get
		{
			if (identity != null)
			{
				return identity.Name;
			}
			return null;
		}
	}

	public WindowsImpersonatedIdentity(string userName, string domainName, string password)
	{
		if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(domainName) && string.IsNullOrEmpty(password))
		{
			identity = WindowsIdentity.GetCurrent();
			return;
		}
		if (LogonUser(userName, domainName, password, 2, 0, out var phToken) != 0)
		{
			using (phToken)
			{
				identity = new WindowsIdentity(phToken.DangerousGetHandle());
				impersonationContext = identity.Impersonate();
				return;
			}
		}
		throw new Win32Exception(Marshal.GetLastWin32Error());
	}

	public void Dispose()
	{
		if (impersonationContext != null)
		{
			impersonationContext.Undo();
		}
		if (identity != null)
		{
			identity.Dispose();
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int LogonUser(string lpszUserName, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, out SafeTokenHandle phToken);
}
