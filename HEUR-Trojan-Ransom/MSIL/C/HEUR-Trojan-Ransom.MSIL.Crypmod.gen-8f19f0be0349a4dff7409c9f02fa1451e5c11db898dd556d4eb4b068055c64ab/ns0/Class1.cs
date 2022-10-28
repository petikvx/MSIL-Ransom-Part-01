using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal sealed class Class1
{
	public static string string_0 = "EAAAALZtWlYn5RSRzzQv25kWmX6INGcLlC5iBzugw0VI7IKL + 7wOaADOJ/daOYUHJx8wkw==";

	public static string string_1 = "goisjgpoerkjgokkbjiushgporwagmwibuts0gp[mvkntiusopjfij";

	private static byte[] byte_0 = Encoding.ASCII.GetBytes("4326443888886662222");

	public static string smethod_0()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("sifreliMetin");
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException("sifre");
		}
		RijndaelManaged rijndaelManaged = null;
		string text = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0);
			byte[] buffer = Convert.FromBase64String(string_0);
			using MemoryStream memoryStream = new MemoryStream(buffer);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = smethod_2(memoryStream);
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}
		finally
		{
			rijndaelManaged?.Clear();
		}
	}

	public static string smethod_1(string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			throw new ArgumentNullException("sifreliMetin");
		}
		if (string.IsNullOrEmpty(smethod_0()))
		{
			throw new ArgumentNullException("sifre");
		}
		RijndaelManaged rijndaelManaged = null;
		string text = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(smethod_0(), byte_0);
			byte[] buffer = Convert.FromBase64String(string_2);
			using MemoryStream memoryStream = new MemoryStream(buffer);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = smethod_2(memoryStream);
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}
		finally
		{
			rijndaelManaged?.Clear();
		}
	}

	private static byte[] smethod_2(MemoryStream memoryStream_0)
	{
		byte[] array = new byte[4];
		if (memoryStream_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new SystemException("Stream did not contain properly formatted byte array");
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (memoryStream_0.Read(array2, 0, array2.Length) != array2.Length)
		{
			throw new SystemException("Did not read byte array properly");
		}
		return array2;
	}
}
