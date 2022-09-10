using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control0 : TabControl
{
	internal static byte[] smethod_0(byte[] byte_0, Aes aes_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes_0.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}
}
