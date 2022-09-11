using System;
using System.Reflection;
using System.Runtime.InteropServices;
using hospitally;

namespace a;

internal sealed class l
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 668)]
	private struct B
	{
	}

	private static readonly Array c;

	private static readonly Array h = new char[334];

	private static readonly object E;

	internal static byte f/* Not supported: data(00) */;

	internal static Assembly u()
	{
		return T.C()(Form1.Dexy());
	}

	static l()
	{
		char[] array = new char[8];
		array[3] = 'ᢤ';
		array[7] = '㩻';
		array[2] = 'ⵜ';
		array[5] = '㠄';
		array[4] = '╛';
		array[6] = '㞙';
		array[0] = 'ㆲ';
		array[1] = 'ヮ';
		E = new string[46];
		c = array;
	}
}
