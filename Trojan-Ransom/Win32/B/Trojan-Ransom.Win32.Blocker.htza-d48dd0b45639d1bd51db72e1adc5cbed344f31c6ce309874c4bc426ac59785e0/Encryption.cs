using System;
using System.Security.Cryptography;
using System.Text;

internal class Encryption
{
	public static string Release(string input, string key)
	{
		string text = null;
		byte[] bytes = Encoding.Unicode.GetBytes(input);
		byte[] bytes2 = Encoding.Unicode.GetBytes(key);
		byte[] bytes3 = RSMDecrypt(bytes, bytes2);
		return Encoding.Unicode.GetString(bytes3);
	}

	public static byte[] RSMDecrypt(byte[] byte_0, byte[] byte_1)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, new byte[8], 1);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(16);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(16);
		byte[] array = rijndaelManaged.CreateDecryptor().TransformFinalBlock(byte_0, 0, byte_0.Length);
		checked
		{
			byte[] array2 = new byte[array.Length - 17 + 1];
			Buffer.BlockCopy(array, 16, array2, 0, array.Length - 16);
			return array2;
		}
	}

	public static string DecryptText(string input, string key)
	{
		char[] array = input.ToCharArray();
		char[] array2 = key.ToCharArray();
		checked
		{
			char[] array3 = new char[input.Length - 2 + 1];
			int num = array[input.Length - 1];
			array[input.Length - 1] = '\0';
			int num2 = 0;
			int num3 = input.Length - 1;
			for (int i = 0; i <= num3; i++)
			{
				if (i < input.Length - 1)
				{
					if (num2 >= array2.Length)
					{
						num2 = 0;
					}
					int num4 = array[i];
					int num5 = array2[num2];
					int value = num4 - num - num5;
					array3[i] = Convert.ToChar(value);
					num2++;
				}
			}
			return new string(array3);
		}
	}
}
