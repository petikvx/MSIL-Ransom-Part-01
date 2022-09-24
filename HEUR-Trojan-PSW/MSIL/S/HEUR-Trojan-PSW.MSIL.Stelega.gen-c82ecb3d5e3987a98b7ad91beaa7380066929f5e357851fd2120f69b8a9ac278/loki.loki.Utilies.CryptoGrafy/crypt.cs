using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace loki.loki.Utilies.CryptoGrafy;

internal class crypt
{
	public static string password_aes = "EAAAALZtWlYn5RSRzzQv25kWmX6INGcLlC5iBzugw0VI7IKL + 7wOaADOJ/daOYUHJx8wkw==";

	public static string password = "goisjgpoerkjgokkbjiushgporwagmwibuts0gp[mvkntiusopjfij";

	private static byte[] _salt = Encoding.ASCII.GetBytes("4326443888886662222");

	public static string loki_decrypt()
	{
		if (string.IsNullOrEmpty(password_aes))
		{
			throw new ArgumentNullException("sifreliMetin");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentNullException("sifre");
		}
		RijndaelManaged rijndaelManaged = null;
		string text = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, _salt);
			byte[] buffer = Convert.FromBase64String(password_aes);
			using MemoryStream memoryStream = new MemoryStream(buffer);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = ReadByteArray(memoryStream);
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

	public static string AESDecript(string stringa)
	{
		if (string.IsNullOrEmpty(stringa))
		{
			throw new ArgumentNullException("sifreliMetin");
		}
		if (string.IsNullOrEmpty(loki_decrypt()))
		{
			throw new ArgumentNullException("sifre");
		}
		RijndaelManaged rijndaelManaged = null;
		string text = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(loki_decrypt(), _salt);
			byte[] buffer = Convert.FromBase64String(stringa);
			using MemoryStream memoryStream = new MemoryStream(buffer);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = ReadByteArray(memoryStream);
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

	private static byte[] ReadByteArray(MemoryStream ms)
	{
		byte[] array = new byte[4];
		if (ms.Read(array, 0, array.Length) != array.Length)
		{
			throw new SystemException("Stream did not contain properly formatted byte array");
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (ms.Read(array2, 0, array2.Length) != array2.Length)
		{
			throw new SystemException("Did not read byte array properly");
		}
		return array2;
	}
}
