using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace SmartAssembly.StringsEncoding;

public class Strings
{
	private static readonly string MustUseCache;

	private static readonly string OffsetValue;

	private static readonly byte[] bytes;

	private static readonly Hashtable hashtable;

	private static readonly bool cacheStrings;

	private static readonly int offset;

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
		OffsetValue = "4";
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
		using Stream stream = executingAssembly.GetManifestResourceStream("{de8d6456-2448-407c-9413-43df6e234186}");
		int num = Convert.ToInt32(stream.Length);
		bytes = new byte[num];
		stream.Read(bytes, 0, num);
		stream.Close();
	}
}
