using System;
using System.Runtime.InteropServices;

namespace G;

internal sealed class s
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 430)]
	private struct y
	{
	}

	private static readonly Array l;

	private static readonly Array g = new char[215];

	private static readonly object N;

	internal static byte A/* Not supported: data(00) */;

	public static void Y(AppDomain appDomain_0)
	{
		//IL_0002: Expected O, but got I4
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		string text = (string)0;
		do
		{
			if ((nint)text == 1)
			{
				F.c(appDomain_0).X(m.l);
				text = (string)2;
			}
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 2);
	}

	static s()
	{
		char[] array = new char[8];
		array[1] = '২';
		array[3] = '⸵';
		array[4] = 'ਯ';
		array[0] = '\u059d';
		array[7] = '㤈';
		array[6] = 'ᅗ';
		array[2] = '᧑';
		array[5] = '⫲';
		N = new string[15];
		l = array;
	}
}
