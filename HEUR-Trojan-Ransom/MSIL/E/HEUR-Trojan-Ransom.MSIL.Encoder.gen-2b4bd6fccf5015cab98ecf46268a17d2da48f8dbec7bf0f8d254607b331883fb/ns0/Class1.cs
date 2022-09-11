using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class1
{
	internal enum Enum0
	{
		const_0 = 7000,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15,
		const_16,
		const_17,
		const_18,
		const_19,
		const_20,
		const_21,
		const_22,
		const_23,
		const_24,
		const_25
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 434)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[217];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static byte[] smethod_0()
	{
		return Class5.smethod_0(Class0.smethod_0(), new byte[31]
		{
			194, 96, 26, 22, 51, 187, 47, 131, 174, 58,
			13, 11, 138, 1, 20, 155, 10, 227, 215, 89,
			78, 188, 116, 30, 86, 88, 225, 183, 160, 148,
			133
		});
	}

	static Class1()
	{
		char[] array = new char[8];
		array[6] = '\u0b3b';
		array[3] = '㇟';
		array[1] = '߃';
		array[4] = 'ý';
		array[2] = 'ਸ਼';
		array[5] = '\u193e';
		array[0] = '≺';
		array[7] = '㑧';
		object_1 = new string[20];
		object_0 = array;
	}
}
