using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

public class GClass4
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

	static GClass4()
	{
		string_0 = GClass11.smethod_0("1");
		string_1 = GClass11.smethod_0("2Ĵȶ");
		byte_0 = null;
		bool_0 = false;
		int_0 = 0;
		if (string_0 == GClass11.smethod_0("0"))
		{
			bool_0 = true;
			dictionary_0 = new Dictionary<int, string>();
		}
		int_0 = Convert.ToInt32(string_1);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream(GClass11.smethod_0("]Ĝȑ\u0347ЖՃ\u0615ܬ\u087bर\u0a7fନబപ\u0e35༣ဦᄥሡጾᐪᕷᘥᝬᠣ\u1938\u1a6f\u1b3cᱫᵯḸὦ‴ℰ∳⌺\u2434╼"));
		int num = Convert.ToInt32(stream.Length);
		byte[] buffer = new byte[num];
		stream.Read(buffer, 0, num);
		byte_0 = GClass5.smethod_3(buffer);
		buffer = null;
		stream.Close();
	}
}
