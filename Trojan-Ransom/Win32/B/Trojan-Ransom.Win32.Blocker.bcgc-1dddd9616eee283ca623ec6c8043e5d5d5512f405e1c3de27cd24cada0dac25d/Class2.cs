using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal sealed class Class2
{
	public static string smethod_0(string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("qwertyuioplkjhgf");
		byte[] bytes2 = Encoding.ASCII.GetBytes("qwertyuioplkjhgf");
		byte[] bytes3 = Encoding.ASCII.GetBytes(string_0);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MemoryStream memoryStream = new MemoryStream(bytes3.Length);
		byte[] inArray;
		try
		{
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(bytes, bytes2), CryptoStreamMode.Write);
			try
			{
				cryptoStream.Write(bytes3, 0, bytes3.Length);
				cryptoStream.FlushFinalBlock();
				cryptoStream.Close();
			}
			finally
			{
				((IDisposable)cryptoStream).Dispose();
			}
			inArray = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return Convert.ToBase64String(inArray);
	}

	public static string smethod_1(string string_0)
	{
		string text = string.Empty;
		Random random = new Random(1646475713);
		string[] array = string_0.Split(new char[1] { '~' });
		string[] array2 = array;
		foreach (string s in array2)
		{
			int value = int.Parse(s) / random.Next(10000);
			text += Convert.ToChar(value);
		}
		return text;
	}

	public static string smethod_2(string string_0, string string_1)
	{
		HashAlgorithm hashAlgorithm = HashAlgorithm.Create(string_1);
		FileStream fileStream = File.OpenRead(string_0);
		byte[] array = hashAlgorithm.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace("-", string.Empty);
	}
}
