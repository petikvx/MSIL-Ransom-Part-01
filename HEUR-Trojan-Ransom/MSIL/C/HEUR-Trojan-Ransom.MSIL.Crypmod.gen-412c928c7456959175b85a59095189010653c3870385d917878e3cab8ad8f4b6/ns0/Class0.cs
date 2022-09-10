using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[20];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class0()
	{
		char[] array = new char[8];
		array[7] = '\u0332';
		array[2] = 'ⱎ';
		array[6] = '㷈';
		array[5] = '⸶';
		array[1] = '㙇';
		array[0] = 'ࢧ';
		array[3] = 'ڄ';
		array[4] = '∢';
		array_1 = new string[2];
		object_0 = array;
	}
}
