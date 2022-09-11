using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class1
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[16];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0()
	{
		Class6.appDomain_0.AssemblyResolve += Class9.smethod_2;
	}

	static Class1()
	{
		char[] array = new char[8];
		array[2] = '⛮';
		array[5] = 'ǣ';
		array[3] = 'ㆯ';
		array[6] = 'ছ';
		array[1] = '⿏';
		array[7] = '\u0d01';
		array[4] = 'ᙰ';
		array[0] = 'औ';
		object_0 = new string[2];
		array_0 = array;
	}
}
