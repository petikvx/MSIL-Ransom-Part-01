using System;
using System.Runtime.InteropServices;
using ns0;

namespace ns1;

internal sealed class Attribute1 : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct1
	{
	}

	internal readonly string string_0;

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[43];

	private static readonly string[] string_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Attribute1(string string_2)
	{
		string_0 = string_2;
	}

	static Attribute1()
	{
		char[] array = new char[8];
		array[7] = '㲲';
		array[5] = '㿋';
		array[2] = 'ኰ';
		array[0] = '㜥';
		array[1] = '㠮';
		array[4] = 'Ⴗ';
		array[3] = '⼂';
		array[6] = 'ᓬ';
		string_1 = new string[1];
		char_0 = array;
		Attribute0.Class0.smethod_1();
	}
}
