using System;
using System.Runtime.InteropServices;

namespace ns1;

public class LlButton
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 64)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[32];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static LlButton()
	{
		char[] array = new char[8];
		array[6] = 'अ';
		array[5] = '\u07b3';
		array[2] = '㋍';
		array[0] = '⠽';
		array[3] = '␘';
		array[4] = '㦶';
		array[1] = 'ᤑ';
		array[7] = 'ᨷ';
		object_1 = new string[3];
		array_0 = array;
	}
}
