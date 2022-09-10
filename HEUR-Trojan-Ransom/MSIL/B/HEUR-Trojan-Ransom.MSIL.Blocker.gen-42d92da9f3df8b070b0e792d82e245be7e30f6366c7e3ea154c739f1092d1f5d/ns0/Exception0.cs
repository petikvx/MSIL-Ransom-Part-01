using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Exception0 : InternalBufferOverflowException
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[18];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static Exception0()
	{
		char[] array = new char[8];
		array[5] = '₲';
		array[6] = '⥯';
		array[7] = '㭱';
		array[4] = '⠵';
		array[3] = '\u206a';
		array[0] = 'ซ';
		array[1] = 'Ꮳ';
		array[2] = '㑥';
		object_1 = new string[2];
		array_0 = array;
	}
}
