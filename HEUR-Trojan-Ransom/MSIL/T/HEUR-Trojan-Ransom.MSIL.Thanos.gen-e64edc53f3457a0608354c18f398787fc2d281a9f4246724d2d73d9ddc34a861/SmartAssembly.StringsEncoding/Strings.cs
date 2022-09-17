using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using SmartAssembly.Zip;

namespace SmartAssembly.StringsEncoding;

public sealed class Strings
{
	public static class DynProx
	{
		public static string Get(int int_0)
		{
			int_0 ^= 0x666BEEF;
			int_0 -= offset;
			if (!cacheStrings)
			{
				return GetFromResource(int_0);
			}
			return GetCachedOrResource(int_0);
		}
	}

	private static readonly string MustUseCache;

	private static readonly string OffsetValue;

	private static readonly byte[] bytes;

	private static readonly Dictionary<int, string> hashtable;

	private static readonly object hashtableLock;

	private static readonly bool cacheStrings;

	private static readonly int offset;

	public static string Get(int int_0)
	{
		return DynProx.Get(int_0);
	}

	public static string GetCachedOrResource(int int_0)
	{
		lock (hashtableLock)
		{
			hashtable.TryGetValue(int_0, out var value);
			if (value != null)
			{
				return value;
			}
		}
		return GetFromResource(int_0);
	}

	public static string GetFromResource(int int_0)
	{
		int index = int_0;
		int num = bytes[index++];
		int num2;
		if (((uint)num & 0x80u) != 0)
		{
			num2 = ((((uint)num & 0x40u) != 0) ? (((num & 0x1F) << 24) + (bytes[index++] << 16) + (bytes[index++] << 8) + bytes[index++]) : (((num & 0x3F) << 8) + bytes[index++]));
		}
		else
		{
			num2 = num;
			if (num2 == 0)
			{
				return string.Empty;
			}
		}
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(bytes, index, num2));
			string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (cacheStrings)
			{
				CacheString(int_0, text);
			}
			return text;
		}
		catch
		{
			return null;
		}
	}

	public static void CacheString(int int_0, string string_0)
	{
		try
		{
			lock (hashtableLock)
			{
				hashtable.Add(int_0, string_0);
			}
		}
		catch
		{
		}
	}

	static Strings()
	{
		MustUseCache = "1";
		OffsetValue = "58";
		bytes = null;
		hashtableLock = new object();
		cacheStrings = false;
		offset = 0;
		if (MustUseCache == "1")
		{
			cacheStrings = true;
			hashtable = new Dictionary<int, string>();
		}
		offset = Convert.ToInt32(OffsetValue);
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{7e613094-6e2a-4562-bae2-db4e82bf94f8}");
		int num = Convert.ToInt32(stream.Length);
		byte[] array = new byte[num];
		stream.Read(array, 0, num);
		bytes = SimpleZip.Unzip(array);
		array = null;
	}
}
