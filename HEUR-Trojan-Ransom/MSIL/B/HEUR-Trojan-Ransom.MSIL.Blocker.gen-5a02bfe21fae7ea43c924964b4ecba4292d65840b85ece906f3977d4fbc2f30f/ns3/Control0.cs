using System.IO;
using System.Security.Cryptography;
using System.Windows.Controls;
using ns4;

namespace ns3;

internal sealed class Control0 : Control
{
	private static SymmetricAlgorithm smethod_0(string string_0)
	{
		Rijndael rijndael = Class2.smethod_0("Rijndael");
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
		using SymmetricAlgorithm symmetricAlgorithm = smethod_0(string_0);
		using ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor();
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}
}
