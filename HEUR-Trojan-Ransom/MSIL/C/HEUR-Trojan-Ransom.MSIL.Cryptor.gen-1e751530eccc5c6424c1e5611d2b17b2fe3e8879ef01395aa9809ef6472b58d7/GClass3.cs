using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

public static class GClass3
{
	public static string smethod_0(this byte[] byte_0)
	{
		return Encoding.UTF8.GetString(byte_0);
	}

	public static string smethod_1(this object object_0)
	{
		string text = object_0.ToString();
		int length = text.Length;
		if (length < 3)
		{
			return text;
		}
		if (length % 3 == 0)
		{
			MatchCollection matchCollection = new Regex(Class4.smethod_0(-1659687954)).Matches(text);
			string text2 = string.Empty;
			for (int i = 0; i < matchCollection.Count; i++)
			{
				text2 = ((i + 1 < matchCollection.Count) ? (text2 + matchCollection[i].Groups[1].Value.ToString() + Class4.smethod_0(-1659687944)) : (text2 + matchCollection[i].Groups[1].Value.ToString()));
			}
			return text2;
		}
		if (length % 3 == 1)
		{
			Regex regex = new Regex(Class4.smethod_0(-1659687954));
			string text3 = text.Substring(0, 1);
			object_0 = text.Substring(1);
			MatchCollection matchCollection2 = regex.Matches(object_0.ToString());
			string text4 = string.Empty;
			for (int j = 0; j < matchCollection2.Count; j++)
			{
				text4 = ((j + 1 != matchCollection2.Count) ? (text4 + matchCollection2[j].Groups[1].Value.ToString() + Class4.smethod_0(-1659687944)) : (text4 + matchCollection2[j].Groups[1].Value.ToString()));
			}
			return text3 + Class4.smethod_0(-1659687944) + text4;
		}
		Regex regex2 = new Regex(Class4.smethod_0(-1659687954));
		string text5 = text.Substring(0, 2);
		object_0 = text.Substring(2);
		MatchCollection matchCollection3 = regex2.Matches(text);
		string text6 = string.Empty;
		for (int k = 0; k < matchCollection3.Count; k++)
		{
			text6 = ((k + 1 != matchCollection3.Count) ? (text6 + matchCollection3[k].Groups[1].Value.ToString() + Class4.smethod_0(-1659687944)) : (text6 + matchCollection3[k].Groups[1].Value.ToString()));
		}
		return text5 + Class4.smethod_0(-1659687944) + text6;
	}

	public static byte[] smethod_2(this string string_0)
	{
		return Encoding.UTF8.GetBytes(string_0);
	}

	public static byte[] smethod_3(this byte[] byte_0)
	{
		return Encoding.UTF8.GetBytes(Convert.ToBase64String(byte_0));
	}

	public static byte[] smethod_4(this byte[] byte_0)
	{
		return Convert.FromBase64String(byte_0.smethod_0());
	}

	public static byte[] smethod_5(this byte[] byte_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			return mD5CryptoServiceProvider.ComputeHash(byte_0);
		}
		finally
		{
			((IDisposable)mD5CryptoServiceProvider).Dispose();
		}
	}
}
