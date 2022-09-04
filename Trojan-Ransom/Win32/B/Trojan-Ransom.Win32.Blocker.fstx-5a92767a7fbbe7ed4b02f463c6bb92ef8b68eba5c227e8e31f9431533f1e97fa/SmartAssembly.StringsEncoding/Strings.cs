using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SmartAssembly.StringsEncoding;

public class Strings
{
	private static readonly string MustUseCache;

	private static readonly string OffsetValue;

	private static readonly byte[] bytes;

	private static readonly Dictionary<int, string> hashtable;

	private static readonly bool cacheStrings;

	private static readonly int offset;

	public static string Get(int int_0)
	{
		int_0 -= offset;
		if (cacheStrings)
		{
			hashtable.TryGetValue(int_0, out var value);
			if (value != null)
			{
				return value;
			}
		}
		int num = 0;
		int index = int_0;
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
		string result;
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(bytes, index, num));
			string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (cacheStrings)
			{
				try
				{
					hashtable.Add(int_0, text);
				}
				catch
				{
				}
			}
			result = text;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	static Strings()
	{
		MustUseCache = "0";
		OffsetValue = "112";
		bytes = null;
		cacheStrings = false;
		offset = 0;
		if (MustUseCache == "1")
		{
			cacheStrings = true;
			hashtable = new Dictionary<int, string>();
		}
		offset = Convert.ToInt32(OffsetValue);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream("{b3e62882-790e-4cc5-bc20-f49d874f51ad}");
		int num = Convert.ToInt32(stream.Length);
		bytes = new byte[num];
		stream.Read(bytes, 0, num);
		stream.Close();
	}
}
