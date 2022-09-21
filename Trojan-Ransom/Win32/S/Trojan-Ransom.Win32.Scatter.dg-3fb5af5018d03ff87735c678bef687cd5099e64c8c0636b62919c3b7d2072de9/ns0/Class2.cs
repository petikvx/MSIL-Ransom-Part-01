using System;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal class Class2
{
	internal int int_0 = 1024;

	internal string string_0;

	internal Class2()
	{
		string_0 = "<RSAKeyValue><Modulus>0vTwxQzv07EELNROagdGdi5IcGqIEkZJjFJXka2krXiPwzEXt7sC4E+3OAkOnCVWJItTr6NW5Z3AIq8Y14jAJq6dR2i2L7FyycKsck6UYRwWTu9pRPuoTrMb/omNsvi0V9fb869lbnHSh6wD0pl+8tb/agkv3ddLeszyxf4ckxs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
	}

	internal string method_0(string string_1)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(string_1), fOAEP: false));
	}
}
