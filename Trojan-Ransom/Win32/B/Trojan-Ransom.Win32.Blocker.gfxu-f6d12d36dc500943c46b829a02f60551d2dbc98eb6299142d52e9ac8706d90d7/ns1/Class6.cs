using System;
using System.Runtime.InteropServices;
using ns4;

namespace ns1;

internal sealed class Class6
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct3
	{
	}

	internal sealed class Class7
	{
	}

	internal static readonly char[] char_0;

	internal static readonly char[] char_1;

	internal static readonly string[] string_0;

	internal static Struct3 struct3_0/* Not supported: data(00 00 24 00 00 00 5A 03 31 2C C0 0B 11 1F 32 26 BE 3E 6E 03 20 28 47 03 32 2C C4 0B 15 1F 37 26 A1 3E 6F 03 74 28 0C 03 67 2C DB 0B 12 1F 38 26 EE 3E 38 03 3B 28 5E 03 37 2C C1 0B 16 1F 30 26 ED 3E 3E 03 23 28 08 03 36 2C 94 0B 4B 1F) */;

	static Class6()
	{
		Class42.hMqjKD0znI7T7();
		int num = default(int);
		int num2 = default(int);
		char[] array = default(char[]);
		try
		{
			num = 9;
			num2 = 3;
			num = 3;
			char[] array_ = new char[39];
			Class24.smethod_179((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 759, 764);
			char_1 = array_;
			num = 5;
			array = new char[8] { '\0', '\0', '\0', '\0', '\0', '\0', '\u035b', '\0' };
			num2 = 1;
			num = 3;
			array[1] = 'Ⰳ';
			array[7] = '⠖';
			array[4] = '☁';
			num = 2;
			num2 = 6;
			num = 3;
			array[0] = '\u036a';
			array[2] = '௶';
			array[3] = 'έ';
			num = 6;
			num2 = 2;
			num = 3;
			array[5] = '㺌';
			string_0 = new string[1];
			char_0 = array;
		}
		catch (Exception exception_)
		{
			int num3 = default(int);
			Class24.smethod_6(exception_, (object)array, (object)num2, (object)num, (object)num3);
			throw;
		}
	}
}
