using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

[StandardModule]
public sealed class DecodeFiles
{
	public static string Password;

	public static string tdsDecode(string string_0, string string_1, bool bool_0 = false)
	{
		string text = null;
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
	}

	public static void Decode_File(string string_0)
	{
		try
		{
			string string_ = File.ReadAllText(string_0);
			string s = tdsDecode(generale.GetStrings(string_), Password);
			byte[] array = Convert.FromBase64String(s);
			string path = string_0.Replace(".css", "");
			FileStream fileStream = new FileStream(path, FileMode.Create);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			File.Delete(string_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
