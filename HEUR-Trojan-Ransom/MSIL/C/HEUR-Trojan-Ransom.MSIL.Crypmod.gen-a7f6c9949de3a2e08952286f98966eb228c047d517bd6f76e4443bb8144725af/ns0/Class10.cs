using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class10
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 328)]
	private struct Struct1
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[164];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class10()
	{
		char[] array = new char[8];
		array[1] = '㙂';
		array[5] = 'ⴝ';
		array[4] = 'ᖑ';
		array[0] = '㵤';
		array[2] = '\u1bee';
		array[7] = 'ෂ';
		array[6] = '᧑';
		array[3] = '㧣';
		array_1 = new string[25];
		array_0 = array;
	}
}
