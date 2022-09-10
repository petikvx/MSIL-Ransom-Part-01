using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal class Class6
{
	public bool method_0(string string_0)
	{
		return Process.GetProcessesByName(string_0).Length > 0;
	}

	private string method_1(string string_0)
	{
		FileStream fileStream = File.OpenRead(string_0);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", "").ToUpper();
	}

	public string method_2(string string_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(string_0));
		string text = BitConverter.ToString(array).Replace("-", "").ToLower();
		return text.ToUpper();
	}

	public string method_3(int int_0)
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

	public bool method_4(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return false;
		}
		if (method_1(string_0) != method_1(Process.GetCurrentProcess().MainModule!.FileName))
		{
			File.Delete(string_0);
			return false;
		}
		return true;
	}
}
