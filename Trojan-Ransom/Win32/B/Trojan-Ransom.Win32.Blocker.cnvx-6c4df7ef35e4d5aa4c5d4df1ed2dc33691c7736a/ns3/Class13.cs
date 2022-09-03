using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns3;

internal sealed class Class13
{
	private static Random random_0 = new Random();

	public static string smethod_0(string string_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(string_0));
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	private static string smethod_1(string string_0)
	{
		FileStream fileStream = File.OpenRead(string_0);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public static bool smethod_2(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return false;
		}
		if (smethod_1(string_0) != smethod_1(Process.GetCurrentProcess().MainModule!.FileName))
		{
			File.Delete(string_0);
			return false;
		}
		return true;
	}

	public static string smethod_3(int int_0)
	{
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			text2 += text.Substring(random_0.Next(0, text.Length), 1);
		}
		return text2;
	}

	public static void smethod_4()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
		}
	}

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);
}
