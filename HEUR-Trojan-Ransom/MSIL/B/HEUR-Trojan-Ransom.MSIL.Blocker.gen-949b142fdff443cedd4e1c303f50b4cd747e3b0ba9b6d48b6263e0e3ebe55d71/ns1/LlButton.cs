using System;
using System.Runtime.InteropServices;

namespace ns1;

public class LlButton
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 56)]
	private struct Struct1
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[28];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	static LlButton()
	{
		char[] array = new char[8];
		array[3] = 'љ';
		array[4] = '\u030e';
		array[7] = '≺';
		array[5] = 'ܒ';
		array[0] = 'ǻ';
		array[2] = '➣';
		array[6] = 'ˡ';
		array[1] = 'ᑢ';
		array_2 = new string[3];
		array_0 = array;
	}
}
