using System;
using System.Runtime.InteropServices;

namespace ns4;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 76662)]
	private struct l
	{
	}

	internal sealed class x
	{
		internal sealed class r
		{
		}
	}

	private static readonly Array j;

	private static readonly Array o = new char[38331];

	private static readonly Array p;

	internal static byte s/* Not supported: data(00) */;

	internal static bool jjgtgccvy(out AppDomain appDomain)
	{
		string value = null;
		if (string.IsNullOrEmpty(value))
		{
			appDomain = AppDomain.CurrentDomain;
			return true;
		}
		appDomain = null;
		return false;
	}

	static Class5()
	{
		char[] array = new char[8];
		array[1] = '㛰';
		array[2] = 'ኩ';
		array[6] = 'ᨳ';
		array[0] = 'ᙥ';
		array[4] = 'Ⓡ';
		array[7] = 'ㅩ';
		array[3] = 'ؾ';
		array[5] = '㩄';
		p = new string[15];
		j = array;
	}
}
