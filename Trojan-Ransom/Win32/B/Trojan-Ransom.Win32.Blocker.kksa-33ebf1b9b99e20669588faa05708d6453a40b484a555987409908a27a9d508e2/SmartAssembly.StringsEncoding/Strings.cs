using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace SmartAssembly.StringsEncoding;

public class Strings
{
	private static string MustUseCache;

	private static string OffsetValue;

	private static byte[] bytes;

	private static Hashtable hashtable;

	private static bool cacheStrings;

	private static int offset;

	[DoNotPrune]
	[DoNotMove]
	public static string Get(int stringID)
	{
		stringID -= offset;
		if (cacheStrings)
		{
			string text = (string)hashtable[stringID];
			if (text != null)
			{
				return text;
			}
		}
		int num = 0;
		int index = stringID;
		int num2 = bytes[index++];
		if (((uint)num2 & 0x80u) != 0)
		{
			num = ((((uint)num2 & 0x40u) != 0) ? (((num2 & 0x1F) << 24) + (bytes[index++] << 16) + (bytes[index++] << 8) + bytes[index++]) : (((num2 & 0x3F) << 8) + bytes[index++]));
		}
		else
		{
			num = num2;
			if (num == 0)
			{
				return string.Empty;
			}
		}
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(bytes, index, num));
			string text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (cacheStrings)
			{
				try
				{
					hashtable.Add(stringID, text2);
				}
				catch
				{
				}
			}
			return text2;
		}
		catch
		{
			return null;
		}
	}

	static Strings()
	{
		MustUseCache = "0";
		OffsetValue = "211";
		bytes = null;
		hashtable = null;
		cacheStrings = false;
		offset = 0;
		if (MustUseCache == "1")
		{
			cacheStrings = true;
			hashtable = new Hashtable();
		}
		offset = Convert.ToInt32(OffsetValue);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream("{ac2e0e89-7c9e-4711-8ec2-cd2d16e0638f}");
		int num = Convert.ToInt32(stream.Length);
		bytes = new byte[num];
		stream.Read(bytes, 0, num);
		stream.Close();
	}
}
