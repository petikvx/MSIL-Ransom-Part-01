using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ns2;

internal class Class16
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
		int num2 = int_1;
		int num3 = byte_0[num2++];
		if (((uint)num3 & 0x80u) != 0)
		{
			num = ((((uint)num3 & 0x40u) != 0) ? (((num3 & 0x1F) << 24) + (byte_0[num2++] << 16) + (byte_0[num2++] << 8) + byte_0[num2++]) : (((num3 & 0x3F) << 8) + byte_0[num2++]));
		}
		else
		{
			num = num3;
			if (num == 0)
			{
				return string.Empty;
			}
		}
		try
		{
			byte[] array = Delegate26.delegate26_0(Delegate25.delegate25_1(Delegate24.delegate24_0(), byte_0, num2, num));
			string text = Delegate21.delegate21_0(Delegate25.delegate25_1(Delegate24.delegate24_0(), array, 0, array.Length));
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

	static Class16()
	{
		string_0 = "1";
		string_1 = "251";
		byte_0 = null;
		bool_0 = false;
		int_0 = 0;
		if (Delegate27.delegate27_0(string_0, "1"))
		{
			bool_0 = true;
			dictionary_0 = new Dictionary<int, string>();
		}
		int_0 = Delegate28.delegate28_0(string_1);
		Assembly object_ = Delegate29.delegate29_0();
		Stream stream = Delegate12.delegate12_1(object_, "{681ea88d-af29-4e8a-b8c9-7a0ce1953e9d}");
		try
		{
			int num = Delegate30.delegate30_0(Delegate2.delegate2_1(stream));
			byte_0 = new byte[num];
			Delegate3.delegate3_1(stream, byte_0, 0, num);
			Delegate4.delegate4_3(stream);
		}
		finally
		{
			if (stream != null)
			{
				Delegate4.delegate4_1(stream);
			}
		}
	}
}
