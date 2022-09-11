using System;
using System.Runtime.InteropServices;
using Fm;

namespace ns0;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 26)]
	private struct Struct1
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[13];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static void smethod_0()
	{
		Program.Main();
	}

	static Class5()
	{
		char[] array = new char[8];
		array[5] = '㠾';
		array[3] = '\u1aba';
		array[7] = '㖤';
		array[4] = '㚐';
		array[0] = 'ڇ';
		array[6] = '>';
		array[1] = '⣃';
		array[2] = '⋬';
		array_0 = new string[3];
		object_0 = array;
	}
}
