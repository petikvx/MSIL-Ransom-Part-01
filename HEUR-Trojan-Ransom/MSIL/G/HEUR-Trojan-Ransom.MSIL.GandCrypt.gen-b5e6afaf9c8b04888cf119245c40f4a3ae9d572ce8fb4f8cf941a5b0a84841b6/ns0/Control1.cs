using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control1 : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
	private struct Struct0
	{
	}

	public static AppDomain appDomain_0;

	public static Assembly assembly_0;

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[16];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Control1()
	{
		char[] array = new char[8];
		array[1] = '⧃';
		array[0] = '㙄';
		array[6] = '᧸';
		array[7] = '\u2d2c';
		array[5] = '\u171d';
		array[4] = '៚';
		array[2] = '㣮';
		array[3] = '㦘';
		object_0 = new string[3];
		array_0 = array;
	}
}
