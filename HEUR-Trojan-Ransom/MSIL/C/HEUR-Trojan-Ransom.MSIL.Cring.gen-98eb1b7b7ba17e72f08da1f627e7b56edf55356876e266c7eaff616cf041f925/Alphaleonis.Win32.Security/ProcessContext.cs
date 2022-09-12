using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32;

namespace Alphaleonis.Win32.Security;

public static class ProcessContext
{
	public static bool IsAdministrator
	{
		get
		{
			WindowsIdentity windowsIdentity;
			WindowsPrincipal windowsPrincipal = GetWindowsPrincipal(out windowsIdentity);
			using (windowsIdentity)
			{
				return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator) || windowsPrincipal.IsInRole(512);
			}
		}
	}

	public static bool IsElevatedProcess
	{
		get
		{
			if (IsUacEnabled)
			{
				if (GetProcessElevationType() != NativeMethods.TOKEN_ELEVATION_TYPE.TokenElevationTypeFull)
				{
					return IsAdministrator;
				}
				return true;
			}
			return false;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Uac")]
	public static bool IsUacEnabled
	{
		get
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: false);
			return registryKey?.GetValue("EnableLUA").Equals(1) ?? false;
		}
	}

	public static bool IsWindowsService
	{
		get
		{
			WindowsIdentity windowsIdentity;
			WindowsPrincipal windowsPrincipal = GetWindowsPrincipal(out windowsIdentity);
			using (windowsIdentity)
			{
				return windowsPrincipal.IsInRole(new SecurityIdentifier(WellKnownSidType.LocalSystemSid, null)) || windowsPrincipal.IsInRole(new SecurityIdentifier(WellKnownSidType.ServiceSid, null));
			}
		}
	}

	private static WindowsPrincipal GetWindowsPrincipal(out WindowsIdentity windowsIdentity)
	{
		windowsIdentity = WindowsIdentity.GetCurrent();
		if (windowsIdentity == null)
		{
			throw new InvalidOperationException(Resources.GetCurrentWindowsIdentityFailed);
		}
		return new WindowsPrincipal(windowsIdentity);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "GetTokenInformation")]
	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "OpenProcessToken")]
	private static NativeMethods.TOKEN_ELEVATION_TYPE GetProcessElevationType()
	{
		SafeTokenHandle tokenHandle;
		bool num = NativeMethods.OpenProcessToken(Process.GetCurrentProcess().Handle, NativeMethods.TOKEN.TOKEN_READ, out tokenHandle);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			throw new Win32Exception(lastWin32Error, string.Format(CultureInfo.CurrentCulture, "{0}: OpenProcessToken failed with error: {1}", new object[2]
			{
				MethodBase.GetCurrentMethod()!.Name,
				lastWin32Error.ToString(CultureInfo.CurrentCulture)
			}));
		}
		using (tokenHandle)
		{
			using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(Marshal.SizeOf(Enum.GetUnderlyingType(typeof(NativeMethods.TOKEN_ELEVATION_TYPE))));
			uint returnLength;
			bool tokenInformation = NativeMethods.GetTokenInformation(tokenHandle, NativeMethods.TOKEN_INFORMATION_CLASS.TokenElevationType, safeGlobalMemoryBufferHandle, (uint)safeGlobalMemoryBufferHandle.Capacity, out returnLength);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!tokenInformation)
			{
				throw new Win32Exception(lastWin32Error, string.Format(CultureInfo.CurrentCulture, "{0}: GetTokenInformation failed with error: {1}", new object[2]
				{
					MethodBase.GetCurrentMethod()!.Name,
					lastWin32Error.ToString(CultureInfo.CurrentCulture)
				}));
			}
			return (NativeMethods.TOKEN_ELEVATION_TYPE)safeGlobalMemoryBufferHandle.ReadInt32();
		}
	}
}
