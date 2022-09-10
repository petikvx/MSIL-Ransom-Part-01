using System.IO;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Exception0 : InternalBufferOverflowException
{
	internal static void smethod_0(byte[] byte_0, Aes aes_0, MemoryStream memoryStream_0)
	{
		using CryptoStream cryptoStream = new CryptoStream(memoryStream_0, aes_0.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
	}
}
