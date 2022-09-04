using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

internal class Cryptography
{
	public static byte[] GetBytes(string text)
	{
		return new UTF8Encoding().GetBytes(text);
	}

	public static string GetString(byte[] bytes)
	{
		return new UTF8Encoding().GetString(bytes);
	}

	public static string Base64Encode(string text)
	{
		return Convert.ToBase64String(GetBytes(text));
	}

	public static string Base64Decode(string text)
	{
		return GetString(Convert.FromBase64String(text));
	}

	public static string ImageToBase64(Image image)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		return Convert.ToBase64String((byte[])((TypeConverter)new ImageConverter()).ConvertTo((object?)image, typeof(byte[])));
	}

	public static Image Base64ToImage(string data)
	{
		return Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(data)));
	}

	public static string RijndaelEncrypt(string data, string key)
	{
		string result = string.Empty;
		byte[] salt = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, salt);
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			RijndaelManaged rijndaelManaged2 = rijndaelManaged;
			rijndaelManaged2.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
			rijndaelManaged2.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
			rijndaelManaged2.Mode = CipherMode.ECB;
			rijndaelManaged2.Padding = PaddingMode.Zeros;
			rijndaelManaged2.BlockSize = 256;
			rijndaelManaged2 = null;
			using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			using (StreamWriter streamWriter = new StreamWriter(stream))
			{
				streamWriter.Write(data);
			}
			result = Convert.ToBase64String(memoryStream.ToArray());
		}
		return result;
	}

	public static string RijndaelDecrypt(string data, string key)
	{
		string result = string.Empty;
		byte[] buffer = Convert.FromBase64String(data);
		byte[] salt = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, salt);
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			RijndaelManaged rijndaelManaged2 = rijndaelManaged;
			rijndaelManaged2.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
			rijndaelManaged2.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
			rijndaelManaged2.Mode = CipherMode.ECB;
			rijndaelManaged2.Padding = PaddingMode.Zeros;
			rijndaelManaged2.BlockSize = 256;
			rijndaelManaged2 = null;
			using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using MemoryStream stream = new MemoryStream(buffer);
			using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
			result = streamReader.ReadToEnd();
		}
		return result;
	}

	public static string MD5Hash(string input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = mD5CryptoServiceProvider.ComputeHash(GetBytes(input.ToLower()));
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return stringBuilder.ToString().ToLower();
	}

	public static string GetGUID(string input)
	{
		string value = MD5Hash(input);
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder;
		stringBuilder2.Append(value, 0, 8);
		stringBuilder2.Append("-");
		stringBuilder2.Append(value, 8, 4);
		stringBuilder2.Append("-");
		stringBuilder2.Append(value, 12, 4);
		stringBuilder2.Append("-");
		stringBuilder2.Append(value, 16, 4);
		stringBuilder2.Append("-");
		stringBuilder2.Append(value, 20, 12);
		return stringBuilder2.ToString();
	}
}
