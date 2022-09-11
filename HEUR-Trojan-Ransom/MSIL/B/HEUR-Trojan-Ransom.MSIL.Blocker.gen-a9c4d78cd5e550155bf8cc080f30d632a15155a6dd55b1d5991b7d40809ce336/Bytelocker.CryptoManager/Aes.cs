using System.Security.Cryptography;

namespace Bytelocker.CryptoManager;

internal class Aes
{
	private const int SALT_BUFFER = 32;

	public byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
	}
}
