using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ns5;

namespace ns6;

internal class Class14
{
	private static readonly string string_0;

	private static readonly string string_1;

	internal static readonly byte[] byte_0;

	internal static readonly Dictionary<int, string> dictionary_0;

	internal static readonly object object_0;

	internal static readonly bool bool_0;

	private static readonly int int_0;

	public static string smethod_0(int int_1)
	{
		int_1 ^= 0x666BEEF;
		int_1 -= int_0;
		if (!bool_0)
		{
			return Class22.smethod_50(int_1);
		}
		return Class22.smethod_10(int_1);
	}

	static Class14()
	{
		string_0 = "0";
		string_1 = "185";
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
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{8939949e-6626-4d3a-b850-986daf4b35f3}");
		int num = Convert.ToInt32(stream.Length);
		byte_0 = new byte[num];
		stream.Read(byte_0, 0, num);
	}
}
