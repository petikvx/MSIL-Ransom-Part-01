using System.Security.Cryptography;

namespace winapp;

internal class rsa
{
	public static byte[] Encryption(byte[] bytes, string PublicKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		try
		{
			rSACryptoServiceProvider.FromXmlString(PublicKey);
			return rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}
}
