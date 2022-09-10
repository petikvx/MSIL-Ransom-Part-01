using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ns0;

public class Cell : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[24];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static Cell()
	{
		char[] array = new char[8];
		array[3] = '㖦';
		array[7] = '㢱';
		array[2] = '౸';
		array[6] = 'చ';
		array[4] = 'ᔕ';
		array[1] = 'ઝ';
		array[0] = '㣝';
		array[5] = '㍆';
		object_1 = new string[3];
		object_0 = array;
	}
}
