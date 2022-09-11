using System;
using System.Security.Cryptography;
using System.Text;

namespace Spy_PC;

internal class AES_CryptoClass
{
	public static string keyStr = "9856741230123654";

	public string Decrypt(string textToDecrypt)
	{
		RijndaelManaged obj = new RijndaelManaged
		{
			Mode = CipherMode.ECB,
			Padding = PaddingMode.None,
			KeySize = 128,
			BlockSize = 128
		};
		byte[] array = Convert.FromBase64String(textToDecrypt);
		byte[] bytes = Encoding.UTF8.GetBytes(keyStr);
		byte[] array2 = new byte[16];
		int num = bytes.Length;
		if (num > array2.Length)
		{
			num = array2.Length;
		}
		Array.Copy(bytes, array2, num);
		obj.Key = array2;
		obj.IV = array2;
		byte[] bytes2 = obj.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
		string @string = Encoding.UTF8.GetString(bytes2);
		return @string[..@string.LastIndexOf('/')] + "/";
	}

	public string Encrypt(string textToEncrypt, string key)
	{
		RijndaelManaged obj = new RijndaelManaged
		{
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7,
			KeySize = 128,
			BlockSize = 128
		};
		byte[] bytes = Encoding.UTF8.GetBytes(key);
		byte[] array = new byte[16];
		int num = bytes.Length;
		if (num > array.Length)
		{
			num = array.Length;
		}
		Array.Copy(bytes, array, num);
		obj.Key = array;
		obj.IV = array;
		ICryptoTransform cryptoTransform = obj.CreateEncryptor();
		byte[] bytes2 = Encoding.UTF8.GetBytes(textToEncrypt);
		return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length));
	}
}
