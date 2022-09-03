using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class8
{
	private static byte[] smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = default(byte[]);
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			Rijndael rijndael = Rijndael.Create();
			rijndael.Key = byte_1;
			rijndael.IV = byte_2;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
			byte[] array = memoryStream.ToArray();
			result = array;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_1(string string_0, string string_1)
	{
		string result = default(string);
		try
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_1, new byte[13]
			{
				73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
				100, 101, 118
			});
			byte[] inArray = smethod_0(bytes, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
			result = Convert.ToBase64String(inArray);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static byte[] smethod_2(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = default(byte[]);
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			Rijndael rijndael = Rijndael.Create();
			rijndael.Key = byte_1;
			rijndael.IV = byte_2;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
			byte[] array = memoryStream.ToArray();
			result = array;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_3(string string_0, string string_1)
	{
		try
		{
			byte[] byte_ = Convert.FromBase64String(string_0);
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_1, new byte[13]
			{
				73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
				100, 101, 118
			});
			byte[] bytes = smethod_2(byte_, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
			return Encoding.Unicode.GetString(bytes);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
