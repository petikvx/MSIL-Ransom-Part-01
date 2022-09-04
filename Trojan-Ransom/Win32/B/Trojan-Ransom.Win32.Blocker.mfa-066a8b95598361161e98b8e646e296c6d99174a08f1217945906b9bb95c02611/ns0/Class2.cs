using System;
using System.IO;
using System.Reflection;
using System.Text;
using ns3;

namespace ns0;

internal sealed class Class2
{
	internal static readonly byte[] byte_0;

	static Class2()
	{
		if (byte_0 == null)
		{
			string s = "TG9hZGVyLmluc3RhbGxlckxvYWRlci5pbnN0YWxsZXI=";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			byte_0 = Class3.smethod_1(manifestResourceStream);
		}
	}

	internal static string smethod_0(int int_0)
	{
		int num = 0;
		if ((byte_0[int_0] & 0x80) == 0)
		{
			num = byte_0[int_0];
			int_0++;
		}
		else if ((byte_0[int_0] & 0x40) == 0)
		{
			num = (byte_0[int_0] & -129) << 8;
			num |= byte_0[int_0 + 1];
			int_0 += 2;
		}
		else
		{
			num = (byte_0[int_0] & -193) << 24;
			num |= byte_0[int_0 + 1] << 16;
			num |= byte_0[int_0 + 2] << 8;
			num |= byte_0[int_0 + 3];
			int_0 += 4;
		}
		if (num < 1)
		{
			return string.Empty;
		}
		string @string = Encoding.Unicode.GetString(byte_0, int_0, num);
		return string.Intern(@string);
	}
}
