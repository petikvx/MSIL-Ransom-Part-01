using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace d;

internal sealed class B : TabControl
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 34)]
	private struct j
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[17];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0(byte[] byte_1)
	{
		for (int i = 0; O.smethod_0(byte_1, i); i++)
		{
			byte_1[i] = g.smethod_0(byte_1, i);
		}
	}

	static B()
	{
		char[] array = new char[8];
		array[5] = '⡵';
		array[7] = '\u0b3f';
		array[2] = '㗊';
		array[6] = 'ჾ';
		array[4] = '⹂';
		array[1] = '\u1a7b';
		array[0] = 'က';
		array[3] = 'ɑ';
		object_1 = new string[2];
		array_0 = array;
	}
}
