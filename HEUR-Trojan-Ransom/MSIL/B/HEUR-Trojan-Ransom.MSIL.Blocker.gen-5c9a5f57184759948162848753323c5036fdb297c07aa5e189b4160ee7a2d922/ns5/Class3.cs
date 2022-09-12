using System.Security.Cryptography;

namespace ns5;

internal sealed class Class3
{
	internal static void smethod_0(byte[] byte_0, CryptoStream cryptoStream_0)
	{
		cryptoStream_0.Write(byte_0, 0, byte_0.Length);
	}
}
