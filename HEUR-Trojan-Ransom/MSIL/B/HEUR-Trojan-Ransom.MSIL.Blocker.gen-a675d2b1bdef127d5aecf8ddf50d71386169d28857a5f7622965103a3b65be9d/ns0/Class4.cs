using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 104)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[52];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal virtual int vmethod_0(byte byte_1, int int_0, char char_0, int int_1)
	{
		return vmethod_0(byte_1, int_0, char_0, int_1);
	}

	internal static ResolveEventHandler smethod_0()
	{
		return Class0.smethod_0;
	}

	static Class4()
	{
		char[] array = new char[8];
		array[7] = 'ⳛ';
		array[2] = '㣐';
		array[3] = '\u20d4';
		array[5] = '⁏';
		array[6] = '⭌';
		array[4] = '\u1ae7';
		array[0] = '㺩';
		array[1] = 'տ';
		object_1 = new string[7];
		array_0 = array;
	}
}
