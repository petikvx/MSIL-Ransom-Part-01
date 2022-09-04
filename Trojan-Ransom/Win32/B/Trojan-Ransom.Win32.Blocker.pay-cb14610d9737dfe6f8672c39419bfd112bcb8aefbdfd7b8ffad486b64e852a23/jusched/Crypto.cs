using System;
using System.Security.Cryptography;
using System.Text;

namespace jusched;

public class Crypto
{
	private static TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();

	private static string key = Configuration.phpkey;

	private static string ByteArrayToString(byte[] byte_0)
	{
		string text = BitConverter.ToString(byte_0);
		return text.Replace("-", "");
	}

	public static byte[] StringToByteArray(string string_0)
	{
		int length = string_0.Length;
		checked
		{
			byte[] array = new byte[(int)Math.Round((double)length / 2.0 - 1.0) + 1];
			for (int i = 0; i < length; i += 2)
			{
				array[(int)Math.Round((double)i / 2.0)] = Convert.ToByte(string_0.Substring(i, 2), 16);
			}
			return array;
		}
	}

	public static string EncryptData(string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(key);
		byte[] bytes2 = Encoding.ASCII.GetBytes("password");
		byte[] bytes3 = Encoding.ASCII.GetBytes(string_0);
		byte[] array = new byte[0];
		tDes.IV = bytes2;
		tDes.Key = bytes;
		tDes.Mode = CipherMode.CBC;
		tDes.Padding = PaddingMode.Zeros;
		array = tDes.CreateEncryptor().TransformFinalBlock(bytes3, 0, bytes3.Length);
		return ByteArrayToString(array);
	}

	public static string DecryptData(string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(key);
		byte[] bytes2 = Encoding.ASCII.GetBytes("password");
		byte[] array = StringToByteArray(string_0);
		byte[] array2 = new byte[0];
		tDes = (TripleDESCryptoServiceProvider)TripleDES.Create();
		tDes.IV = bytes2;
		tDes.Key = bytes;
		tDes.Mode = CipherMode.CBC;
		tDes.Padding = PaddingMode.Zeros;
		array2 = tDes.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
		return Encoding.ASCII.GetString(array2);
	}
}
