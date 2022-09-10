using System;
using System.Runtime.InteropServices;

namespace ns1;

public class LlButton
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 56)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[28];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static LlButton()
	{
		char[] array = new char[8];
		array[4] = '⩘';
		array[7] = '▙';
		array[1] = '☶';
		array[2] = 'ᏼ';
		array[0] = '⍋';
		array[3] = '㭰';
		array[5] = 'Ꮇ';
		array[6] = 'ኣ';
		array_1 = new string[3];
		object_0 = array;
	}
}
