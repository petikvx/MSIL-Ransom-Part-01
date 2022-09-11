using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1158)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class2()
	{
		char_1 = new char[579];
		char[] array = new char[8];
		array[6] = '㸦';
		array[2] = '⳹';
		array[0] = 'Ъ';
		array[4] = 'љ';
		array[3] = '᪉';
		array[7] = '\u0b5a';
		array[1] = 'ᗠ';
		array[5] = 'ᕅ';
		string_0 = new string[32];
		char_0 = array;
	}
}
