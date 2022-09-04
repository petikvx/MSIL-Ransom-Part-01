using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using ns0;
using ns1;

namespace ns5;

internal class Class16
{
	private static string string_0;

	private static string string_1;

	private static byte[] byte_0;

	private static Hashtable hashtable_0;

	private static bool bool_0;

	private static int int_0;

	[Attribute3]
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

	static Class16()
	{
		string_0 = GClass4.smethod_0("0");
		string_1 = GClass4.smethod_0("1Ĳ");
		byte_0 = null;
		hashtable_0 = null;
		bool_0 = false;
		int_0 = 0;
		if (string_0 == GClass4.smethod_0("0"))
		{
			bool_0 = true;
			hashtable_0 = new Hashtable();
		}
		int_0 = Convert.ToInt32(string_1);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream(GClass4.smethod_0("]ŀȐ\u0316цԔ\u0611ݺ\u082cरਤବణമ\u0e35༣\u102fᄡሦጾᑳᔩᘦ\u173bᠣ\u193e\u1a6e\u1b6dᱨᵬḻἲ\u2062ℰ∷⍠\u2436╼"));
		int num = Convert.ToInt32(stream.Length);
		byte[] buffer = new byte[num];
		stream.Read(buffer, 0, num);
		byte_0 = Class19.smethod_1(buffer);
		buffer = null;
		stream.Close();
	}
}
