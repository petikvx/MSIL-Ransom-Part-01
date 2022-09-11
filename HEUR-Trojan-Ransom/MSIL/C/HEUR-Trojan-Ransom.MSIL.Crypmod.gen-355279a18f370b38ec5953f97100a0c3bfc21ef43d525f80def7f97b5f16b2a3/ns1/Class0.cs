using System;
using System.Runtime.InteropServices;

namespace ns1;

internal sealed class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[24];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class0()
	{
		char[] array = new char[8];
		array[1] = '㌑';
		array[5] = 'ᮇ';
		array[0] = '㒊';
		array[2] = 'ⶣ';
		array[4] = 'ὠ';
		array[3] = 'ᠱ';
		array[7] = '\u09d0';
		array[6] = '㪡';
		array_0 = new string[3];
		object_0 = array;
	}
}
