using System;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using ns7;
using ns8;

namespace ns6;

internal sealed class Class2 : TextBox
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 182)]
	private struct Struct1
	{
	}

	private static readonly Array e;

	private static readonly object L = new char[91];

	private static readonly object U;

	internal static byte A/* Not supported: data(00) */;

	internal static byte[] smethod_0()
	{
		return Class3.smethod_1(Class4.smethod_0());
	}

	static Class2()
	{
		char[] array = new char[8];
		array[0] = '㝝';
		array[4] = 'Ꮞ';
		array[6] = '㵵';
		array[3] = 'ᦚ';
		array[7] = 'ᘳ';
		array[5] = 'ᾉ';
		array[1] = '㣽';
		array[2] = '\u2451';
		U = new string[7];
		e = array;
	}
}
