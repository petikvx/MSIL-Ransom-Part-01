using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using dgdwl;
using whjwk;

namespace pwxbu;

public class rlvqy
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 404)]
	private struct otyqu
	{
	}

	private static readonly object P;

	private static readonly object o = new char[202];

	private static readonly Array J;

	internal static byte x/* Not supported: data(00) */;

	public static IEnumerable<TypeInfo> Fuckit
	{
		get
		{
			Type[] array = new Type[1] { vyrbz.b.GetTypes()[2] };
			TypeInfo[] array2 = new TypeInfo[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				xhocx.e(array, i, array2);
			}
			return array2;
		}
	}

	static rlvqy()
	{
		char[] array = new char[8];
		array[6] = 'ᤒ';
		array[4] = 'ㇲ';
		array[3] = '㘩';
		array[7] = '㧋';
		array[1] = '⾩';
		array[5] = '㇏';
		array[0] = '㴁';
		array[2] = '\u0ada';
		J = new string[11];
		P = array;
	}
}
