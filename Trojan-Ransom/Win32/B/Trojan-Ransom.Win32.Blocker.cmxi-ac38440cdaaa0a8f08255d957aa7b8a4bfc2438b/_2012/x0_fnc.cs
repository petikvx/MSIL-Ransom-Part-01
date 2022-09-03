using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading;

namespace _2012;

internal class x0_fnc
{
	[DllImport("kernel32.dll")]
	public static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

	public static void Flush()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
		}
	}

	public static bool fnc_admin()
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

	public static bool checkFile(string FilePath)
	{
		if (!File.Exists(FilePath))
		{
			return false;
		}
		if (FileMD5(FilePath) != FileMD5(Process.GetCurrentProcess().MainModule!.FileName))
		{
			File.SetAttributes(FilePath, FileAttributes.Normal);
			File.Delete(FilePath);
			return false;
		}
		return true;
	}

	private static string FileMD5(string op654654kl454lk54lk648)
	{
		FileStream fileStream = File.OpenRead(op654654kl454lk54lk648);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public static string gstring(int len)
	{
		Random random = new Random();
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = string.Empty;
		for (int i = 0; i < len; i++)
		{
			text2 += text.Substring(random.Next(0, text.Length), 1);
		}
		return text2;
	}

	public static void cxmux()
	{
		try
		{
			x0_str.xmux = new Mutex(initiallyOwned: true, "777e7e7e7e7d5f44d6s4d6764537463576df4f5486736544654f68d7f6sa666a6a4sa6d48384364f52f");
			x0_str.xmux.ReleaseMutex();
		}
		catch
		{
			Console.WriteLine("Mutex");
			Environment.Exit(-1);
		}
	}
}
