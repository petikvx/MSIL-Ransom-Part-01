using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class4
{
	public static object smethod_0(string string_0, string string_1)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_0));
			mD5CryptoServiceProvider.Clear();
			rijndaelManaged.Key = key;
			rijndaelManaged.GenerateIV();
			byte[] iV = rijndaelManaged.IV;
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(iV, 0, iV.Length);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] inArray = memoryStream.ToArray();
			cryptoStream.Close();
			rijndaelManaged.Clear();
			return Convert.ToBase64String(inArray);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_1(string string_0, string string_1)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_0));
			mD5CryptoServiceProvider.Clear();
			byte[] buffer = Convert.FromBase64String(string_1);
			MemoryStream memoryStream = new MemoryStream(buffer);
			byte[] array = new byte[16];
			memoryStream.Read(array, 0, 16);
			rijndaelManaged.IV = array;
			rijndaelManaged.Key = key;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
			byte[] array2 = new byte[checked((int)(memoryStream.Length - 16L) + 1)];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			cryptoStream.Close();
			rijndaelManaged.Clear();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
