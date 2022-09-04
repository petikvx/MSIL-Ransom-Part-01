using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal class Class6
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly byte[] byte_0;

	private static readonly Dictionary<int, string> dictionary_0;

	private static readonly bool bool_0;

	private static readonly int int_0;

	static Class6()
	{
		string_0 = "1";
		string_1 = "10";
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
		using Stream stream = executingAssembly.GetManifestResourceStream("{94a1ce8d-594a-4f66-a1ea-37431e4a7e11}");
		int num = Convert.ToInt32(stream.Length);
		byte[] buffer = new byte[num];
		stream.Read(buffer, 0, num);
		byte_0 = Class22.smethod_2(buffer);
		buffer = null;
		stream.Close();
	}

	public static string smethod_0(int int_1)
	{
		string value = default(string);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		string text2 = default(string);
		try
		{
			int_1 -= int_0;
			if (bool_0)
			{
				dictionary_0.TryGetValue(int_1, out value);
				if (value != null)
				{
					return value;
				}
			}
			num = 0;
			num2 = int_1;
			num3 = byte_0[num2++];
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
				array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, num2, num));
				text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
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
				text2 = text;
				return text2;
			}
			catch
			{
				text2 = null;
				return text2;
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_30(exception_, int_1, value, num, num2, num3, array, text, text2);
			throw;
		}
	}
}
