using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using ns3;

namespace ns2;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct3
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct3 struct3_0/* Not supported: data(00 00 24 00 00 00 19 0D AF 2D CC 2E B5 14 44 09 D3 27 0C 2B D4 36 0D 0D FB 2D CC 2E E5 14 44 09 9F 27 08 2B D6 36 41 0D A6 2D D2 2E B2 14 41 09 83 27 04 2B CA 36 19 0D AF 2D 9C 2E B0 14 12 09 8A 27 09 2B D0 36 13 0D A9 2D C8 2E E6 14) */;

	static Class5()
	{
		char_1 = new char[39]
		{
			'\0', '$', '\0', 'ങ', '\u2daf', '⻌', 'ᒵ', '\u0944', '⟓', '⬌',
			'㛔', '\u0d0d', '\u2dfb', '⻌', 'ᓥ', '\u0944', '➟', '⬈', '㛖', '\u0d41',
			'ⶦ', '⻒', 'ᒲ', '\u0941', '➃', '⬄', '㛊', 'ങ', '\u2daf', '⺜',
			'ᒰ', 'ऒ', '➊', '⬉', '㛐', 'ഓ', 'ⶩ', '⻈', 'ᓦ'
		};
		char[] array = new char[8];
		array[0] = 'ഠ';
		array[4] = 'ढ';
		array[5] = '➲';
		array[2] = '\u2eff';
		array[7] = '㛧';
		array[6] = '⬼';
		array[1] = '\u2d9e';
		array[3] = 'ᓓ';
		string_0 = new string[1];
		char_0 = array;
	}

	internal static string smethod_0(int int_0, int int_1)
	{
		int num = int_0 ^ 0x4848D2C8 ^ int_1;
		char[] array = char_1;
		int num2 = array[num];
		string result;
		if ((result = string_0[num2]) != null)
		{
			return result;
		}
		int num3 = array[num + 1];
		num3 = (int)((uint)array[num + 2] << 16) + num3;
		char[] array2 = new char[num3];
		char[] array3 = char_0;
		int num4 = array3.Length;
		num += 3;
		for (int num5 = 0; num5 < num3; num5 = 1 + num5)
		{
			array2[num5] = (char)(array[num + num5] ^ array3[(num5 + num2) % num4]);
		}
		result = new string(array2);
		string_0[num2] = result;
		return result;
	}

	internal static void smethod_1(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				Class6.Class7.Class9.smethod_9(object_0, 438, 491);
				return;
			case 120:
				Monitor.Exit(object_0);
				return;
			}
		}
	}

	internal static byte[] smethod_2(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 50:
				return Class6.smethod_8(memoryStream_0, 387, 481);
			}
		}
	}
}
