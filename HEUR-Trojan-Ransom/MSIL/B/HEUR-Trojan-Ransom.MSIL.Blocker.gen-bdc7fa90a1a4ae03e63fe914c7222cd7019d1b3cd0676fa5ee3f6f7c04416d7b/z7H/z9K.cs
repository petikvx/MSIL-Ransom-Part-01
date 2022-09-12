using System;
using System.Runtime.InteropServices;

namespace z7H;

internal sealed class z9K
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4122)]
	private struct c8E
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2046)]
	private struct Tm9
	{
	}

	internal sealed class x8X
	{
	}

	internal sealed class Yz2
	{
	}

	private static readonly Array r;

	private static readonly object a;

	private static readonly Array M;

	internal static byte d/* Not supported: data(00) */;

	private static readonly Array P;

	private static readonly object e;

	private static readonly Array U;

	internal static byte I/* Not supported: data(00) */;

	static z9K()
	{
		e = new char[1023];
		char[] array = new char[8];
		array[1] = 'ⱇ';
		array[4] = 'ᄍ';
		array[2] = '㩱';
		array[5] = '⇋';
		array[0] = 'ಝ';
		array[3] = 'ᖦ';
		array[6] = 'ኦ';
		array[7] = 'ᰉ';
		U = new string[65];
		P = array;
		a = new char[2061];
		char[] array2 = new char[8];
		array2[3] = 'ࢾ';
		array2[0] = '\u1716';
		array2[5] = '\u1ada';
		array2[7] = '㩫';
		array2[4] = 'ᾟ';
		array2[6] = '⒃';
		array2[1] = 'ኘ';
		array2[2] = '᭪';
		M = new string[86];
		r = array2;
	}
}
