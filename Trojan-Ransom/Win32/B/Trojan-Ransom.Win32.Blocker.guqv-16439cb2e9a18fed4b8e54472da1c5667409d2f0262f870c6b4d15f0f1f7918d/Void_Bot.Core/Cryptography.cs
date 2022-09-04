using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Void_Bot.Core;

internal class Cryptography
{
	public static string ROT13(string Input)
	{
		if (string.IsNullOrEmpty(Input))
		{
			return Config.Const_FunctionError;
		}
		string text = string.Empty;
		int num = 0;
		foreach (char c in Input)
		{
			num = c;
			if (c >= 'a' && c <= 'z')
			{
				num = ((c < 'a' || c > 'm') ? (num - 13) : (num + 13));
			}
			else if (c >= 'A' && c <= 'Z')
			{
				num = ((c < 'A' || c > 'M') ? (num - 13) : (num + 13));
			}
			text += (char)num;
		}
		return text;
	}

	public static string ReadConfigString(string Input)
	{
		if (string.IsNullOrEmpty(Input))
		{
			return Config.Const_FunctionError;
		}
		string s = ROT13(Input);
		s = Encoding.UTF8.GetString(Convert.FromBase64String(s));
		return ROT13(s);
	}

	public static string GetFileMD5(string Path)
	{
		string text = Config.Const_FunctionError;
		try
		{
			using FileStream fileStream = Functions.GetFileStream(Path);
			byte[] array;
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				array = mD5CryptoServiceProvider.ComputeHash(fileStream);
				mD5CryptoServiceProvider.Clear();
			}
			text = BitConverter.ToString(array).Replace("-", "");
			fileStream.Close();
			fileStream.Dispose();
		}
		catch
		{
		}
		if (text != Config.Const_FunctionError)
		{
			text = text.ToUpper();
		}
		return text;
	}

	public static string GetStringMD5(string Input)
	{
		string text = Config.Const_FunctionError;
		if (Input != "")
		{
			try
			{
				byte[] array;
				using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
				{
					array = Encoding.UTF8.GetBytes(Input);
					array = mD5CryptoServiceProvider.ComputeHash(array);
					mD5CryptoServiceProvider.Clear();
				}
				text = BitConverter.ToString(array).Replace("-", "");
			}
			catch
			{
			}
		}
		if (text != Config.Const_FunctionError)
		{
			text = text.ToUpper();
		}
		return text;
	}
}
