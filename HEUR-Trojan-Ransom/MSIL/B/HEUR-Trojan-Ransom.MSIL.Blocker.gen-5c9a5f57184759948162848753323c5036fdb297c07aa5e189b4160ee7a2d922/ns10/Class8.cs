using System.IO;
using System.Security.Cryptography;
using ns2;
using ns5;
using ns6;

namespace ns10;

internal sealed class Class8
{
	internal static SymmetricAlgorithm smethod_0(string string_0)
	{
		Rijndael rijndael = Class4.smethod_0("Rijndael");
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, new byte[15]
		{
			83, 111, 100, 105, 117, 109, 32, 67, 104, 108,
			111, 114, 105, 100, 101
		});
		rijndael.Padding = PaddingMode.Zeros;
		rijndael.Key = rfc2898DeriveBytes.GetBytes(32);
		rijndael.IV = rfc2898DeriveBytes.GetBytes(16);
		return rijndael;
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		using SymmetricAlgorithm symmetricAlgorithm_ = Class1.smethod_0(string_0);
		using ICryptoTransform transform = smethod_2(symmetricAlgorithm_);
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		Class3.smethod_0(byte_0, cryptoStream);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}

	internal static ICryptoTransform smethod_2(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateDecryptor();
	}
}
