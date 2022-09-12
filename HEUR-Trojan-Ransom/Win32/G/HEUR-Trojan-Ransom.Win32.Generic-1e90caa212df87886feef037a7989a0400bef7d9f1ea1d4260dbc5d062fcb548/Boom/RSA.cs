using System.Security.Cryptography;

namespace Boom;

public static class RSA
{
	public static string RSA_PUB = "<RSAKeyValue><Modulus>75JYOhCXm3k0KAl3TcmumsoKTGJ55sxrBAPKdMTcOZ/JurM6pK4cNValdCDKznTRNq+8xj5GQbFv6B69PHn6WpX88Z029Nzvdk/4v3mvzCJybmN98RITYo7kGUMJyBEkLSAnOs3493IdJcS5jxT2sNyF3Gn+aqUww0chzxQhAvLsRoZUv6t+USxTnMTNC5NEYz7lrHDKeYmgPU0iWjyG43DvkfWMHn6sY4wth7nOohnutnd+d2nwu2pHCYMU/CobGW9xKxdHWhRuYPGlFyA11sWlGQsqGlKyYrVzU8lzdO9VBgPTS2YsAwqy88M6dFnYKv7ODIuPBJudsuatkfd6+Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	public static bool EncryptWithRSA(byte[] data, out byte[] encrypted)
	{
		encrypted = null;
		try
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
			rSACryptoServiceProvider.FromXmlString(RSA_PUB);
			encrypted = rSACryptoServiceProvider.Encrypt(data, fOAEP: true);
			rSACryptoServiceProvider.PersistKeyInCsp = false;
			rSACryptoServiceProvider.Clear();
			return true;
		}
		catch
		{
			return false;
		}
	}
}
