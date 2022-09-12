using System.Security.Cryptography;
using System.Windows.Controls;
using ns1;
using ns9;

namespace ns6;

internal sealed class Control0 : Control
{
	private static readonly byte[] K = new byte[16]
	{
		34, 65, 11, 12, 16, 0, 65, 128, 92, 72,
		65, 23, 87, 11, 10, 8
	};

	private static byte[] smethod_0(byte[] byte_0, string string_0, int int_0)
	{
		using PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, K, "SHA512", int_0);
		TripleDES tripleDES = Class0.smethod_1("TripleDES");
		tripleDES.Key = passwordDeriveBytes.GetBytes(24);
		tripleDES.IV = passwordDeriveBytes.GetBytes(8);
		using (ICryptoTransform icryptoTransform_ = tripleDES.CreateDecryptor())
		{
			Class7.smethod_1(byte_0, icryptoTransform_);
		}
		return Class0.e.ToArray();
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		return smethod_0(byte_0, string_0, 2);
	}
}
