using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class1
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 26)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[13];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0()
	{
		Class4.smethod_0();
		Class5.smethod_0();
	}

	public static void smethod_1(AppDomain appDomain_0)
	{
	}

	public static void smethod_2(AppDomain appDomain_0)
	{
		try
		{
			Class6.smethod_0(appDomain_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}

	static Class1()
	{
		char[] array = new char[8];
		array[1] = '\u007f';
		array[6] = 'ই';
		array[0] = 'ㆴ';
		array[4] = 'ṯ';
		array[3] = 'ϐ';
		array[5] = 'ᬱ';
		array[2] = '㙢';
		array[7] = '⎝';
		object_0 = new string[2];
		array_0 = array;
	}
}
