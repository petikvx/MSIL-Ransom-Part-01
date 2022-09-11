using System;
using System.Runtime.InteropServices;
using ns1;

namespace ns0;

internal sealed class Class2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	private struct N
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[18];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static byte[] smethod_0()
	{
		return Class3.smethod_0(Resources.m, new byte[30]
		{
			95, 16, 54, 75, 49, 61, 44, 103, 65, 20,
			109, 114, 30, 45, 110, 15, 115, 67, 32, 40,
			62, 93, 43, 34, 87, 105, 112, 104, 1, 56
		});
	}

	static Class2()
	{
		char[] array = new char[8];
		array[2] = '\u0dd6';
		array[6] = '\u0ac7';
		array[1] = 'Ꮟ';
		array[3] = '┠';
		array[4] = 'ᤗ';
		array[7] = '㴾';
		array[0] = 'ⱄ';
		array[5] = '㗕';
		object_0 = new string[4];
		array_0 = array;
	}
}
