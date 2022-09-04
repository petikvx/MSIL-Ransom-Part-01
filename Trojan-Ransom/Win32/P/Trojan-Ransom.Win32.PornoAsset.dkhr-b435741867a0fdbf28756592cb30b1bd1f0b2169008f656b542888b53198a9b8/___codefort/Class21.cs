using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ___codefort;

internal sealed class Class21
{
	public static string string_0;

	public bool method_0(string string_1)
	{
		return Process.GetProcessesByName(string_1).Length > 0;
	}

	private string method_1(string string_1)
	{
		FileStream fileStream = File.OpenRead(string_1);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace(Class22.smethod_0(737974948), string.Empty).ToUpper();
	}

	public string method_2(string string_1)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(string_1));
		string text = BitConverter.ToString(array).Replace(Class22.smethod_0(737974948), string.Empty).ToLower();
		return text.ToUpper();
	}

	public string method_3(int int_0)
	{
		Random random = new Random();
		string text = Class22.smethod_0(737974956);
		string text2 = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			text2 += text.Substring(random.Next(0, text.Length), 1);
		}
		return text2;
	}

	public bool method_4(string string_1)
	{
		if (!File.Exists(string_1))
		{
			return false;
		}
		if (method_1(string_1) != method_1(Process.GetCurrentProcess().MainModule!.FileName))
		{
			File.Delete(string_1);
			return false;
		}
		return true;
	}
}
