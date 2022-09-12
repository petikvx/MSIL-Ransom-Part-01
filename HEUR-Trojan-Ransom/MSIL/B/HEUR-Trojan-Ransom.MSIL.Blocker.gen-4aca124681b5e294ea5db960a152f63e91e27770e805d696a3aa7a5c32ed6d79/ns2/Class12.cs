using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using ns0;

namespace ns2;

internal sealed class Class12
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly byte[] byte_0;

	private static readonly Dictionary<int, string> dictionary_0;

	private static readonly object object_0;

	private static readonly bool bool_0;

	private static readonly int int_0;

	public static string smethod_0(int int_1)
	{
		int_1 ^= 0x666BEEF;
		int_1 -= int_0;
		if (!bool_0)
		{
			return smethod_2(int_1);
		}
		return smethod_1(int_1);
	}

	public static string smethod_1(int int_1)
	{
		string result;
		lock (object_0)
		{
			dictionary_0.TryGetValue(int_1, out var value);
			if (value != null)
			{
				result = value;
				goto IL_0033;
			}
		}
		return smethod_2(int_1);
		IL_0033:
		return result;
	}

	public static string smethod_2(int int_1)
	{
		int index = int_1;
		int num = byte_0[index++];
		int num2;
		if (((uint)num & 0x80u) != 0)
		{
			num2 = ((((uint)num & 0x40u) != 0) ? (((num & 0x1F) << 24) + (byte_0[index++] << 16) + (byte_0[index++] << 8) + byte_0[index++]) : (((num & 0x3F) << 8) + byte_0[index++]));
		}
		else
		{
			num2 = num;
			if (num2 == 0)
			{
				return string.Empty;
			}
		}
		string result;
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, index, num2));
			string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (bool_0)
			{
				smethod_3(int_1, text);
			}
			result = text;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	public static void smethod_3(int int_1, string string_2)
	{
		try
		{
			lock (object_0)
			{
				dictionary_0.Add(int_1, string_2);
			}
		}
		catch
		{
		}
	}

	static Class12()
	{
		string_0 = "1";
		string_1 = "66";
		byte_0 = null;
		object_0 = new object();
		bool_0 = false;
		int_0 = 0;
		if (string_0 == "1")
		{
			bool_0 = true;
			dictionary_0 = new Dictionary<int, string>();
		}
		int_0 = Convert.ToInt32(string_1);
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{93bf56d9-f10f-4a48-bd0a-eb38f1a7d63c}");
		int num = Convert.ToInt32(stream.Length);
		byte[] buffer = new byte[num];
		stream.Read(buffer, 0, num);
		byte_0 = Class13.smethod_1(buffer);
		buffer = null;
	}
}
