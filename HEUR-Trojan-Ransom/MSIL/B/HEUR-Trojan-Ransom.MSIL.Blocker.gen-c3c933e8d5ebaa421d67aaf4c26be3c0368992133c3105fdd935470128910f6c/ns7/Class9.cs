using System.Security.Cryptography;
using ns2;

namespace ns7;

internal sealed class Class9
{
	internal static byte[] smethod_0(byte[] byte_0)
	{
		byte[] array = new byte[16]
		{
			58, 168, 232, 178, 49, 42, 130, 245, 60, 136,
			12, 31, 103, 88, 48, 233
		};
		using Rijndael rijndael = Rijndael.Create();
		rijndael.Key = array;
		rijndael.IV = array;
		return smethod_1(byte_0, rijndael);
	}

	private static byte[] smethod_1(byte[] byte_0, Rijndael rijndael_0)
	{
		using ICryptoTransform icryptoTransform_ = rijndael_0.CreateDecryptor(rijndael_0.Key, rijndael_0.IV);
		return Class4.smethod_1(byte_0, icryptoTransform_);
	}
}
