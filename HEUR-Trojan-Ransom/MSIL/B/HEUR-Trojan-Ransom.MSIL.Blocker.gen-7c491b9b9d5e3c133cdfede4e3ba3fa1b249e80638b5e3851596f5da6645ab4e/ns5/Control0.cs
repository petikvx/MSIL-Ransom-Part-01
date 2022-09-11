using System.IO;
using System.Security.Cryptography;
using System.Windows.Controls;
using ns1;

namespace ns5;

internal sealed class Control0 : Control
{
	private static readonly byte[] P = new byte[16]
	{
		34, 65, 11, 12, 16, 0, 65, 128, 92, 72,
		65, 23, 87, 11, 10, 8
	};

	private static byte[] smethod_0(byte[] byte_0, string string_0, int int_0)
	{
		using PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, P, "SHA512", int_0);
		using MemoryStream memoryStream = new MemoryStream();
		TripleDES tripleDES = Class0.smethod_0("TripleDES");
		tripleDES.Key = passwordDeriveBytes.GetBytes(24);
		tripleDES.IV = passwordDeriveBytes.GetBytes(8);
		using (ICryptoTransform transform = tripleDES.CreateDecryptor())
		{
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		return smethod_0(byte_0, string_0, 2);
	}
}
