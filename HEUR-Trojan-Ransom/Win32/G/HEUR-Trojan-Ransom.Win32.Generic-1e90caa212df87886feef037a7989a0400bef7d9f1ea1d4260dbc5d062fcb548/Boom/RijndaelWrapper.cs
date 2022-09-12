using System.IO;
using System.Security.Cryptography;

namespace Boom;

public static class RijndaelWrapper
{
	public static bool EncryptWithRijndael(Rijndael aes, byte[] data, out byte[] encrypted)
	{
		encrypted = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			memoryStream = new MemoryStream();
			cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(data, 0, data.Length);
			encrypted = memoryStream.ToArray();
		}
		catch
		{
			return false;
		}
		finally
		{
			cryptoStream?.Dispose();
			memoryStream?.Dispose();
		}
		return true;
	}
}
