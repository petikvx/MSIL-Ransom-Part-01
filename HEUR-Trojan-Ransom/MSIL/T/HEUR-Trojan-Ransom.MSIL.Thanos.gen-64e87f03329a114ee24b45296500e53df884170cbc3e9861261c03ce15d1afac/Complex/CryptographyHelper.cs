using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

public static class CryptographyHelper
{
	private static bool _optimalAsymmetricEncryptionPadding;

	private static readonly string PublicKey;

	[NonSerialized]
	internal static GetString getString_0;

	public static string Encrypt(string string_0)
	{
		int keySize = 0;
		string xmlKey = getString_0(107393468);
		GetKeyFromEncryptionString(PublicKey, out keySize, out xmlKey);
		byte[] inArray = Encrypt(Encoding.UTF8.GetBytes(string_0), keySize, xmlKey);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] Encrypt(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int maxDataLength = GetMaxDataLength(int_0);
			if (byte_0.Length > maxDataLength)
			{
				throw new ArgumentException(string.Format(getString_0(107404139), maxDataLength), getString_0(107404116));
			}
			if (!IsKeySizeValid(int_0))
			{
				throw new ArgumentException(getString_0(107404102), getString_0(107404073));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404028), getString_0(107403999));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, _optimalAsymmetricEncryptionPadding);
		}
		throw new ArgumentException(getString_0(107404169), getString_0(107404116));
	}

	private static int GetMaxDataLength(int int_0)
	{
		if (_optimalAsymmetricEncryptionPadding)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool IsKeySizeValid(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void GetKeyFromEncryptionString(string rawkey, out int keySize, out string xmlKey)
	{
		keySize = 0;
		xmlKey = getString_0(107393468);
		if (rawkey == null || rawkey.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(rawkey);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404014)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				keySize = int.Parse(array[0]);
				xmlKey = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static CryptographyHelper()
	{
		Strings.CreateGetStringDelegate(typeof(CryptographyHelper));
		_optimalAsymmetricEncryptionPadding = false;
		PublicKey = getString_0(107404009);
	}
}
