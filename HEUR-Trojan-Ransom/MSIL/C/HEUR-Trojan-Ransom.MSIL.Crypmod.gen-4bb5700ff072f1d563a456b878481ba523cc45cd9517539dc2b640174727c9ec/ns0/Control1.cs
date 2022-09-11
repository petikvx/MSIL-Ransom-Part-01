using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ForMe;

namespace ns0;

internal sealed class Control1 : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[18];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0()
	{
		Program.Main();
	}

	static Control1()
	{
		char[] array = new char[8];
		array[2] = 'ⶠ';
		array[6] = '㛠';
		array[1] = 'అ';
		array[5] = '\u193c';
		array[0] = 'ᄴ';
		array[3] = '■';
		array[7] = '⧑';
		array[4] = 'ᡛ';
		array_0 = new string[2];
		object_0 = array;
	}
}
