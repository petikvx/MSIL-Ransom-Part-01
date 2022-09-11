using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns0;

namespace ns1;

internal sealed class Control2 : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[20];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0()
	{
		GControl1.smethod_0();
		GControl0.smethod_2(Control3.appDomain_0);
	}

	static Control2()
	{
		char[] array = new char[8];
		array[3] = '⏬';
		array[1] = 'Ῥ';
		array[5] = 'ਫ਼';
		array[7] = '㇡';
		array[6] = '⦧';
		array[0] = 'ق';
		array[4] = '㟬';
		array[2] = '᭘';
		array_0 = new string[5];
		object_0 = array;
	}
}
