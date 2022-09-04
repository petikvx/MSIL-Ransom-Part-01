using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns5;

internal class Class10
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly byte[] byte_0;

	private static readonly Hashtable hashtable_0;

	private static readonly bool bool_0;

	private static readonly int int_0;

	public static string smethod_0(int int_1)
	{
		int_1 -= int_0;
		if (bool_0)
		{
			string text = (string)hashtable_0[int_1];
			if (text != null)
			{
				return text;
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
		string result;
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, index, num));
			string text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (bool_0)
			{
				try
				{
					hashtable_0.Add(int_1, text2);
				}
				catch
				{
				}
			}
			result = text2;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	static Class10()
	{
		string_0 = "1";
		string_1 = "226";
		byte_0 = null;
		hashtable_0 = null;
		bool_0 = false;
		int_0 = 0;
		if (string_0 == "1")
		{
			bool_0 = true;
			hashtable_0 = new Hashtable();
		}
		int_0 = Convert.ToInt32(string_1);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream("{483cb4e5-5fda-44ff-9ad6-4ba3bfa65cb5}");
		int num = Convert.ToInt32(stream.Length);
		byte[] buffer = new byte[num];
		stream.Read(buffer, 0, num);
		byte_0 = Class24.smethod_118(buffer);
		buffer = null;
		stream.Close();
	}
}
