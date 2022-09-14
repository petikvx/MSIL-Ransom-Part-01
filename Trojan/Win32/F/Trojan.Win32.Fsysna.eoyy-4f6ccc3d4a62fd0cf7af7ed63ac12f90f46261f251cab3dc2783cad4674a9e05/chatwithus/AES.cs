using System.Diagnostics;
using System.Security.Cryptography;

namespace chatwithus;

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
			return new RijndaelManaged
			{
				KeySize = 256
			}.CreateDecryptor(key, key).TransformFinalBlock(byte_ciphertext, 0, byte_ciphertext.Length);
		}

		public static byte[] encrypt(byte[] data, byte[] key)
		{
			return new RijndaelManaged
			{
				KeySize = 256
			}.CreateEncryptor(key, key).TransformFinalBlock(data, 0, data.Length);
		}

		public static byte[] generateKey()
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.GenerateKey();
			return rijndaelManaged.Key;
		}
	}
}
