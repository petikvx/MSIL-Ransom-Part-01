using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal class Class19
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly byte[] byte_0;

	private static readonly Dictionary<int, string> dictionary_0;

	private static readonly bool bool_0;

	private static readonly int int_0;

	public static string smethod_0(int int_1)
	{
		int_1 -= int_0;
		if (bool_0)
		{
			dictionary_0.TryGetValue(int_1, out var value);
			if (value != null)
			{
				return value;
			}
		}
		int num = 0;
		int index = int_1;
		int num2 = byte_0[index++];
		if (((uint)num2 & 0x80u) != 0)
		{
			num = ((((uint)num2 & 0x40u) != 0) ? (((num2 & 0x1F) << 24) + (byte_0[index++] << 16) + (byte_0[index++] << 8) + byte_0[index++]) : (((num2 & 0x3F) << 8) + byte_0[index++]));
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
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, index, num));
			string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (bool_0)
			{
				try
				{
					dictionary_0.Add(int_1, text);
				}
				catch
				{
				}
			}
			return text;
		}
		catch
		{
			return null;
		}
	}

	static Class19()
	{
		string_0 = "0";
		string_1 = "21";
		byte_0 = null;
		bool_0 = false;
		int_0 = 0;
		if (string_0 == "1")
		{
			bool_0 = true;
			dictionary_0 = new Dictionary<int, string>();
		}
		int_0 = Convert.ToInt32(string_1);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream("{c8b04d48-ec35-42e6-b9f8-95ef4d11d66b}");
		int num = Convert.ToInt32(stream.Length);
		byte_0 = new byte[num];
		stream.Read(byte_0, 0, num);
		stream.Close();
	}
}
