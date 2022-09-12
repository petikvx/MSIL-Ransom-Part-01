using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal class Class4
{
	internal static readonly byte[] byte_0;

	internal readonly int int_0;

	static Class4()
	{
		if (byte_0 == null)
		{
			string s = "UGV0eWEgYW5kIEdvbGRlbkV5ZSBCVUlMREVSJA==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			byte_0 = Class5.smethod_3(97L, manifestResourceStream);
		}
	}

	internal static string smethod_0(int int_1)
	{
		int num = 0;
		if ((byte_0[int_1] & 0x80) == 0)
		{
			num = byte_0[int_1];
			int_1++;
		}
		else if ((byte_0[int_1] & 0x40) == 0)
		{
			num = (byte_0[int_1] & -129) << 8;
			num |= byte_0[int_1 + 1];
			int_1 += 2;
		}
		else
		{
			num = (byte_0[int_1] & -193) << 24;
			num |= byte_0[int_1 + 1] << 16;
			num |= byte_0[int_1 + 2] << 8;
			num |= byte_0[int_1 + 3];
			int_1 += 4;
		}
		if (num < 1)
		{
			return string.Empty;
		}
		string @string = Encoding.Unicode.GetString(byte_0, int_1, num);
		return string.Intern(@string);
	}
}
