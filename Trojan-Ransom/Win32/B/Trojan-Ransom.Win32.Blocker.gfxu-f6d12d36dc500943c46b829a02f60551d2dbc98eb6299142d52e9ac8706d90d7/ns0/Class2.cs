using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using ns4;

namespace ns0;

internal sealed class Class2 : Computer
{
	internal sealed class Class3
	{
		internal sealed class Class4
		{
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct1
	{
	}

	internal static readonly char[] char_0;

	internal static readonly char[] char_1;

	internal static readonly string[] string_0;

	internal static Struct1 struct1_0/* Not supported: data(00 00 05 00 00 00 69 14 09 29 38 02 A8 0A BD 35) */;

	public Class2()
	{
		Class42.hMqjKD0znI7T7();
		((Computer)this)._002Ector();
		try
		{
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)this);
			throw;
		}
	}

	static Class2()
	{
		Class42.hMqjKD0znI7T7();
		int num = default(int);
		int num2 = default(int);
		char[] array = default(char[]);
		try
		{
			num = 2;
			num2 = 1;
			num = 4;
			num = 6;
			char[] array_ = new char[8];
			Class24.smethod_55((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 134, 174);
			char_1 = array_;
			array = new char[8];
			num = 9;
			num2 = 3;
			num = 4;
			num = 7;
			array[1] = '⤼';
			array[4] = '㗿';
			num = 0;
			array[7] = '㞸';
			num = 3;
			num2 = 4;
			num = 4;
			num = 8;
			array[6] = '\u0fab';
			array[2] = 'ȉ';
			array[0] = 'ᑄ';
			num = 1;
			num2 = 0;
			num = 4;
			num = 13;
			array[3] = 'ઑ';
			array[5] = '⾩';
			string_0 = new string[1];
			num = 12;
			num2 = 2;
			num = 4;
			num = 5;
			char_0 = array;
			Class24.smethod_17();
		}
		catch (Exception exception_)
		{
			int num3 = default(int);
			int num4 = default(int);
			Class24.smethod_21(exception_, (object)array, (object)num2, (object)num3, (object)num, (object)num4);
			throw;
		}
	}
}
