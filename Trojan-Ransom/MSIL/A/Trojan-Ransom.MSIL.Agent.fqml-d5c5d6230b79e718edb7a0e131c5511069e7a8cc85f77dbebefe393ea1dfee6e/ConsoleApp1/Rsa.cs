using System;
using System.Security.Cryptography;

namespace ConsoleApp1;

public static class Rsa
{
	public static byte[] Encrypt(byte[] toEncrypt, RSAParameters pubKey)
	{
		byte[] result = null;
		try
		{
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
			rSACryptoServiceProvider.PersistKeyInCsp = false;
			rSACryptoServiceProvider.ImportParameters(pubKey);
			Console.WriteLine("I didd get here");
			result = rSACryptoServiceProvider.Encrypt(toEncrypt, fOAEP: true);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		return result;
	}

	public static byte[] Decrypt(byte[] encrypted, RSAParameters privKey)
	{
		byte[] result = null;
		using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048))
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
			rSACryptoServiceProvider.ImportParameters(privKey);
			result = rSACryptoServiceProvider.Decrypt(encrypted, fOAEP: true);
		}
		return result;
	}
}
