using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

internal class Class4
{
	public void method_0()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
		}
	}

	public bool method_1(string string_0)
	{
		return Process.GetProcessesByName(string_0).Length > 0;
	}

	private string method_2(string string_0)
	{
		FileStream fileStream = File.OpenRead(string_0);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public string method_3(string string_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(string_0));
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public string method_4(int int_0)
	{
		Random random = new Random();
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			text2 += text.Substring(random.Next(0, text.Length), 1);
		}
		return text2;
	}

	public bool method_5(string string_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				return false;
			}
			if (method_2(string_0) != method_2(Process.GetCurrentProcess().MainModule!.FileName))
			{
				File.Delete(string_0);
				return false;
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool method_6()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch
		{
			return false;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);

	public Class4()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
