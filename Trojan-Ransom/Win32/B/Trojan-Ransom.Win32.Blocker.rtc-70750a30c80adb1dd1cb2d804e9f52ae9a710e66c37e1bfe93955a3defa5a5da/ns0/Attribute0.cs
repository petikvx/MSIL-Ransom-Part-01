using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Attribute0 : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1158)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	public Attribute0(string string_1)
	{
	}

	static Attribute0()
	{
		char_1 = new char[579];
		char[] array = new char[8];
		array[4] = 'ຎ';
		array[0] = 'ᡒ';
		array[6] = '\u1ccb';
		array[7] = 'v';
		array[1] = 'ᛲ';
		array[2] = '⊥';
		array[3] = 'ᆓ';
		array[5] = 'こ';
		string_0 = new string[32];
		char_0 = array;
	}
}
