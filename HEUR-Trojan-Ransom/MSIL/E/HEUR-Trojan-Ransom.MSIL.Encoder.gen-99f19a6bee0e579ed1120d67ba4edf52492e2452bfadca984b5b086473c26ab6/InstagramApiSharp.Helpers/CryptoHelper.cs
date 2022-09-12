using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace InstagramApiSharp.Helpers;

internal class CryptoHelper
{
	public static string ByteToString(byte[] buff)
	{
		return buff.Aggregate("", (string current, byte item) => current + item.ToString("X2"));
	}

	public static string Base64Encode(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string CalculateMd5(string message)
	{
		Encoding uTF = Encoding.UTF8;
		using MD5 mD = MD5.Create();
		return BitConverter.ToString(mD.ComputeHash(uTF.GetBytes(message))).Replace("-", "").ToLower();
	}

	public static string CalculateHash(string key, string message)
	{
		Encoding uTF = Encoding.UTF8;
		byte[] array = uTF.GetBytes(key);
		byte[] array2 = new byte[64];
		byte[] array3 = new byte[64];
		if (array.Length > 64)
		{
			array = GetHash(array);
		}
		if (array.Length < 64)
		{
			byte[] array4 = new byte[64];
			array.CopyTo(array4, 0);
			array = array4;
		}
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (byte)(array[i] ^ 0x5Cu);
			array3[i] = (byte)(array[i] ^ 0x36u);
		}
		return (from a in GetHash(ByteConcat(array2, GetHash(ByteConcat(array3, uTF.GetBytes(message)))))
			select a.ToString("x2")).Aggregate((string a, string b) => a + b);
	}

	public static byte[] GetHash(byte[] bytes)
	{
		using SHA256 sHA = SHA256.Create();
		return sHA.ComputeHash(bytes);
	}

	public static byte[] ByteConcat(byte[] left, byte[] right)
	{
		if (left == null)
		{
			return right;
		}
		if (right == null)
		{
			return left;
		}
		byte[] array = new byte[left.Length + right.Length];
		left.CopyTo(array, 0);
		right.CopyTo(array, left.Length);
		return array;
	}

	public static string GetCommentBreadCrumbEncoded(string text)
	{
		long num = Convert.ToInt64(DateTimeHelper.GetUnixTimestampMilliseconds(DateTime.Now));
		Random random = new Random(DateTime.Now.Millisecond);
		int length = text.Length;
		int num2 = random.Next(2, 3) * 1000 + length * random.Next(15, 20) * 100;
		decimal num3 = Math.Round((decimal)length / (decimal)random.Next(2, 3), 0);
		if (num3 == 0m)
		{
			num3 = 1m;
		}
		string text2 = $"{length} {num2} {num3} {num}";
		string plainText;
		using (HMACSHA256 hMACSHA = new HMACSHA256(Encoding.UTF8.GetBytes("iN4$aGr0m")))
		{
			plainText = ByteToString(hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(text2)));
		}
		return Base64Encode(plainText) + "\n" + Base64Encode(text2) + "\n";
	}
}
