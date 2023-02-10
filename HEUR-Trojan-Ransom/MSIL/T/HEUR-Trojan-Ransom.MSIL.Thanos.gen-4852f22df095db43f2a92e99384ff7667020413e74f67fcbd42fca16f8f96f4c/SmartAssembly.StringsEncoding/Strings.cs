using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using SmartAssembly.Zip;

namespace SmartAssembly.StringsEncoding;

public sealed class Strings
{
	private static readonly string MustUseCache;

	private static readonly string OffsetValue;

	private static readonly byte[] bytes;

	private static readonly Dictionary<int, string> hashtable;

	private static readonly object hashtableLock;

	private static readonly bool cacheStrings;

	private static readonly int offset;

	public static string Get(int P_0)
	{
		P_0 ^= 0x666BEEF;
		P_0 -= offset;
		if (!cacheStrings)
		{
			return GetFromResource(P_0);
		}
		return GetCachedOrResource(P_0);
	}

	public static string GetCachedOrResource(int P_0)
	{
		lock (hashtableLock)
		{
			hashtable.TryGetValue(P_0, out var value);
			if (value != null)
			{
				return value;
			}
		}
		return GetFromResource(P_0);
	}

	public static string GetFromResource(int P_0)
	{
		int index = P_0;
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
				CacheString(P_0, text);
			}
			return text;
		}
		catch
		{
			return null;
		}
	}

	public static void CacheString(int P_0, string P_1)
	{
		try
		{
			lock (hashtableLock)
			{
				hashtable.Add(P_0, P_1);
			}
		}
		catch
		{
		}
	}

	static Strings()
	{
		MustUseCache = "1";
		OffsetValue = "151";
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
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{cec564ff-2433-4771-b918-15f58ef6e26c}");
		int num = Convert.ToInt32(stream.Length);
		byte[] array = new byte[num];
		stream.Read(array, 0, num);
		bytes = SimpleZip.Unzip(array);
		array = null;
	}
}
