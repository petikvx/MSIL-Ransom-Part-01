using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Virus.A;

internal class rsa
{
	private static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
	{
		try
		{
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportParameters(RSAKeyInfo);
			return rSACryptoServiceProvider.Decrypt(DataToDecrypt, DoOAEPPadding);
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine(ex.ToString());
			return null;
		}
	}

	private static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
	{
		try
		{
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportParameters(RSAKeyInfo);
			return rSACryptoServiceProvider.Encrypt(DataToEncrypt, DoOAEPPadding);
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}

	[CompilerGenerated]
	internal static void smethod_0()
	{
		try
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes("Data to Encrypt");
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			byte[] dataToDecrypt = RSAEncrypt(bytes, rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false), DoOAEPPadding: false);
			byte[] bytes2 = RSADecrypt(dataToDecrypt, rSACryptoServiceProvider.ExportParameters(includePrivateParameters: true), DoOAEPPadding: false);
			Console.WriteLine("Decrypted plaintext: {0}", unicodeEncoding.GetString(bytes2));
		}
		catch (ArgumentNullException)
		{
			Console.WriteLine("Encryption failed.");
		}
	}
}
