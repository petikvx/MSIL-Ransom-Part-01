using System;
using System.Runtime.InteropServices;

namespace Fcueorm;

internal sealed class Class7
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 65716)]
	private struct K
	{
	}

	private static readonly Array O;

	private static readonly object Q = new char[32858];

	private static readonly Array L;

	internal static byte S/* Not supported: data(00) */;

	internal static Type Gram()
	{
		return typeof(Class2.Moarte);
	}

	internal static string Mishu()
	{
		return "TVqQAAMAAAAEAAAA//8AALgAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgAAAAA4fug4AtAnNI";
	}

	static Class7()
	{
		char[] array = new char[8];
		array[6] = '㼽';
		array[7] = 'ਫ';
		array[1] = '\u082c';
		array[4] = '⨁';
		array[3] = 'ᇾ';
		array[2] = 'ص';
		array[0] = '㤹';
		array[5] = 'ㅃ';
		L = new string[14];
		O = array;
	}
}
