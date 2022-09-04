using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns6;

internal class Class21
{
	private static string string_0;

	private static string string_1;

	private static byte[] byte_0;

	private static Hashtable hashtable_0;

	private static bool bool_0;

	private static int int_0;

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
			return text2;
		}
		catch
		{
			return null;
		}
	}

	static Class21()
	{
		string_0 = "0";
		string_1 = "68";
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
		using Stream stream = executingAssembly.GetManifestResourceStream("{6aa39610-9d49-4904-b101-b342e6acdb29}");
		int num = Convert.ToInt32(stream.Length);
		byte_0 = new byte[num];
		stream.Read(byte_0, 0, num);
		stream.Close();
	}
}
