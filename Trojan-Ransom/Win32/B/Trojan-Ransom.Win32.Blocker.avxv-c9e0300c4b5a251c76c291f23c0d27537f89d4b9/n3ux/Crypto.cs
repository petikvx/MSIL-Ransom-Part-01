using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace n3ux;

internal class Crypto
{
	public static string EncryptRijndael(string text)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("qazwsxedcrfvtgb");
		byte[] bytes2 = Encoding.ASCII.GetBytes("qazwsxedcrfvtgb");
		byte[] bytes3 = Encoding.ASCII.GetBytes(text);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] inArray;
		using (MemoryStream memoryStream = new MemoryStream(bytes3.Length))
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(bytes, bytes2), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytes3, 0, bytes3.Length);
				cryptoStream.FlushFinalBlock();
				cryptoStream.Close();
			}
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	public static string DecryptDomains(string text)
	{
		string text2 = string.Empty;
		Random random = new Random(1646475713);
		string[] array = text.Split(new char[1] { '~' });
		string[] array2 = array;
		foreach (string s in array2)
		{
			int value = int.Parse(s) / random.Next(10000);
			text2 += Convert.ToChar(value);
		}
		return text2;
	}

	public static string getSignature(string filename, string algorithm)
	{
		HashAlgorithm hashAlgorithm = HashAlgorithm.Create(algorithm);
		FileStream fileStream = System.IO.File.OpenRead(filename);
		byte[] array = hashAlgorithm.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", "");
	}
}
