using System.Security.Cryptography;
using System.Windows;
using ns5;

namespace ns2;

internal sealed class Class0 : Application
{
	internal static byte[] smethod_0(byte[] byte_0, Aes aes_0)
	{
		using ICryptoTransform icryptoTransform_ = aes_0.CreateDecryptor(aes_0.Key, aes_0.IV);
		return GClass2.smethod_3(byte_0, icryptoTransform_);
	}
}
