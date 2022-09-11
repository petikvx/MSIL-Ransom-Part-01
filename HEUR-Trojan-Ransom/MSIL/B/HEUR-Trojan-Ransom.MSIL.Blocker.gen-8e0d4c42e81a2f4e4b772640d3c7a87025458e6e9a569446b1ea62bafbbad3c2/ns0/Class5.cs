using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 264)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[132];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class5()
	{
		char[] array = new char[8];
		array[3] = '᮹';
		array[5] = '⊻';
		array[0] = 'ᓔ';
		array[4] = 'ᶢ';
		array[2] = '㊗';
		array[6] = '㞪';
		array[1] = 'ᔅ';
		array[7] = 'Ё';
		array_1 = new string[14];
		object_0 = array;
	}
}
