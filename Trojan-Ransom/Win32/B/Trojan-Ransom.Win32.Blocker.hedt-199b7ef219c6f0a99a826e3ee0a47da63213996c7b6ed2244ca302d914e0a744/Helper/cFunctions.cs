using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Helper;

internal class cFunctions
{
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
		string text = BitConverter.ToString(array).Replace("-", "").ToLower();
		return text.ToUpper();
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
}
