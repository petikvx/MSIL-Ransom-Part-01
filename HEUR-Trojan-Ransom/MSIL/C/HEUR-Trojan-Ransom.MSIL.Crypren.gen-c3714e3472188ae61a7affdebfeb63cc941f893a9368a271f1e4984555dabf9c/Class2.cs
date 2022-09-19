using System;
using System.Runtime.InteropServices;

internal sealed class Class2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1890)]
	private struct Struct3
	{
	}

	internal sealed class Class3
	{
	}

	internal sealed class Class4
	{
		internal sealed class Class5
		{
		}
	}

	private static readonly Array array_0;

	private static readonly object object_0;

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class2()
	{
		object_0 = new char[945];
		char[] array = new char[8];
		array[0] = '㲞';
		array[3] = '\u244e';
		array[7] = 'ʴ';
		array[2] = '9';
		array[4] = '⥙';
		array[5] = '㢏';
		array[1] = 'ↄ';
		array[6] = 'ટ';
		object_1 = new string[38];
		array_0 = array;
	}
}
