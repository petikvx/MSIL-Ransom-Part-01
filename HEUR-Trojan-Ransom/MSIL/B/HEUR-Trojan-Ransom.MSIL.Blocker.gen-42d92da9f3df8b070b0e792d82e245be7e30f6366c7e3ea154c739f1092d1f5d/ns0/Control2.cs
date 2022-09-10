using System.Security.Cryptography;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control2 : TabControl
{
	internal static byte[] smethod_0(byte[] byte_0, Rfc2898DeriveBytes rfc2898DeriveBytes_0)
	{
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes_0.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes_0.GetBytes(aes.BlockSize / 8);
		aes.Mode = CipherMode.ECB;
		return Control0.smethod_0(byte_0, aes);
	}
}
