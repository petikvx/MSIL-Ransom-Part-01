using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control0 : TabControl
{
	internal static byte[] smethod_0(byte[] byte_0, Aes aes_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Exception0.smethod_0(byte_0, aes_0, memoryStream);
		return memoryStream.ToArray();
	}
}
