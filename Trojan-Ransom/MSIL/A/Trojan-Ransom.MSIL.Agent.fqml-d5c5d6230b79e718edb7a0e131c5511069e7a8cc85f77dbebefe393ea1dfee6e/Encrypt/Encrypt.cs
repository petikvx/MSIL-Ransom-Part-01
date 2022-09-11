using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt;

internal class Encrypt
{
	[DllImport("KERNEL32.DLL")]
	public static extern bool RtlZeroMemory(IntPtr Destination, int Length);

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
	}

	public void FileEncrypt(string inputFile, byte[] skey)
	{
		FileStream fileStream = new FileStream(inputFile + ".aes", FileMode.Create, FileAccess.Write);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		char[] array = new char[16];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = '0';
		}
		rijndaelManaged.Key = skey;
		rijndaelManaged.IV = Encoding.ASCII.GetBytes(array);
		rijndaelManaged.Mode = CipherMode.CFB;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
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
			Console.WriteLine("Error: " + ex.Message);
		}
		finally
		{
			File.Delete(inputFile);
			cryptoStream.Close();
			fileStream.Close();
		}
	}

	public void FileDecrypt(string inputFile, byte[] skey)
	{
		FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		if (!Path.GetExtension(fileStream.Name)!.Contains(".aes"))
		{
			return;
		}
		string path = inputFile.Replace(".aes", "");
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		char[] array = new char[16];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = '0';
		}
		rijndaelManaged.Key = skey;
		rijndaelManaged.IV = Encoding.ASCII.GetBytes(array);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CFB;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(path, FileMode.Create);
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
			Console.WriteLine("CryptographicException error: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Console.WriteLine("Error: " + ex2.Message);
		}
		try
		{
			cryptoStream.Close();
		}
		catch (Exception ex3)
		{
			Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}
}
