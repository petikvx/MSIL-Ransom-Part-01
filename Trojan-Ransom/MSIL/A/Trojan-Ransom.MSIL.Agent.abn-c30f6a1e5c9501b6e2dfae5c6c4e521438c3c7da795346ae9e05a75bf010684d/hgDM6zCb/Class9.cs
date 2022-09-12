using System;
using System.Runtime.InteropServices;

namespace hgDM6zCb;

internal sealed class Class9
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[10];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static void smethod_0(byte[] byte_1, int int_0)
	{
		Class2.byte_0[int_0] = (byte)(Class2.byte_0[int_0] ^ byte_1[int_0 % byte_1.Length]);
	}

	static Class9()
	{
		char[] array = new char[8];
		array[3] = '\u1baa';
		array[4] = '㨘';
		array[5] = '⢈';
		array[7] = '㍫';
		array[2] = 'ࡔ';
		array[0] = '\u2c2f';
		array[6] = 'Ⓣ';
		array[1] = '\u2ded';
		object_0 = new string[2];
		array_0 = array;
	}
}
