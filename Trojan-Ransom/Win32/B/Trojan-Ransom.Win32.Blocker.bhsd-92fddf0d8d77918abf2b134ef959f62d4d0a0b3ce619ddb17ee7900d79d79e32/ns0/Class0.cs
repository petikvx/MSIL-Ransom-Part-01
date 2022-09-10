using System.Runtime.InteropServices;

namespace ns0;

internal static class Class0
{
	public struct Struct0
	{
		public uint uint_0;

		public void method_0()
		{
			uint_0 = 0u;
		}

		public void method_1()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void method_2()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void method_4()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public bool method_5()
		{
			return uint_0 < 7;
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 18191)]
	private struct Struct1
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct2
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[8];

	private static readonly string[] string_0;

	internal static byte byte_1/* Not supported: data(00) */;

	public static uint smethod_0(uint uint_0)
	{
		uint_0 -= 2;
		if (uint_0 < 4)
		{
			return uint_0;
		}
		return 3u;
	}

	static Class0()
	{
		char[] array = new char[8];
		array[1] = '\u0cd8';
		array[2] = '〩';
		array[3] = 'ཁ';
		array[5] = '㣿';
		array[4] = '⺥';
		array[0] = 'ဉ';
		array[7] = '㑖';
		array[6] = '⋀';
		string_0 = new string[1];
		char_0 = array;
	}
}
