using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace SysDriver;

internal class cFunctions
{
	public void FlushMemory()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
		}
	}

	public bool checkProcess(string sProcessName)
	{
		return Process.GetProcessesByName(sProcessName).Length > 0;
	}

	private string FileMD5(string sFileName)
	{
		FileStream fileStream = File.OpenRead(sFileName);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public string getMD5Hash(string sString)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(sString));
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public string genString(int iLen)
	{
		Random random = new Random();
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = string.Empty;
		for (int i = 0; i < iLen; i++)
		{
			text2 += text.Substring(random.Next(0, text.Length), 1);
		}
		return text2;
	}

	public bool checkFile(string FilePath)
	{
		if (!File.Exists(FilePath))
		{
			return false;
		}
		if (FileMD5(FilePath) != FileMD5(Process.GetCurrentProcess().MainModule!.FileName))
		{
			File.Delete(FilePath);
			return false;
		}
		return true;
	}

	public bool getAdminStatus()
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
	private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);
}
