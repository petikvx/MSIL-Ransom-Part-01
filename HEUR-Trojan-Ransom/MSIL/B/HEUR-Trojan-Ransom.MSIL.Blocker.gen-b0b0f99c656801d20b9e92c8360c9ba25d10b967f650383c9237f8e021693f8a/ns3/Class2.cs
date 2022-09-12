using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using ns10;
using ns11;
using ns8;

namespace ns3;

internal sealed class Class2 : Assembly
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 198)]
	private struct Struct0
	{
	}

	private static readonly object B;

	private static readonly object T = new char[99];

	private static readonly object p;

	internal static byte X/* Not supported: data(00) */;

	private static IEnumerable<TypeInfo> d
	{
		get
		{
			Type[] types = Class6.e.GetTypes();
			TypeInfo[] array = new TypeInfo[types.Length];
			GClass0.smethod_1(types, array);
			return array;
		}
	}

	internal static void smethod_0()
	{
		foreach (TypeInfo item in d)
		{
			GControl0.smethod_0(item);
		}
	}

	static Class2()
	{
		char[] array = new char[8];
		array[1] = '⎪';
		array[0] = '㰍';
		array[6] = 'Ӗ';
		array[3] = '㯫';
		array[5] = '⣽';
		array[4] = 'ā';
		array[7] = '℄';
		array[2] = 'ᦍ';
		p = new string[6];
		B = array;
	}
}
