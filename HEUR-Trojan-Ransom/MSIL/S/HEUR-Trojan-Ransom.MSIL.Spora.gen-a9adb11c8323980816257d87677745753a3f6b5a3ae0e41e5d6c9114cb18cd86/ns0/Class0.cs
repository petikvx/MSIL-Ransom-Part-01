using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
	private struct Struct0
	{
	}

	private static int int_0;

	private static int[] int_1;

	private static int int_2;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[5];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public static int Int32_0
	{
		get
		{
			return int_2;
		}
		set
		{
			int num = (value + 31) / 32;
			if (num > int_1.Length || num + 256 < int_1.Length)
			{
				int[] destinationArray = new int[num];
				Array.Copy(int_1, destinationArray, (num > int_1.Length) ? int_1.Length : num);
				int_1 = destinationArray;
			}
			if (value > int_2)
			{
				int num2 = (int_2 + 31) / 32 - 1;
				int num3 = int_2 % 32;
				if (num3 > 0)
				{
					int_1[num2] &= (1 << num3) - 1;
				}
				Array.Clear(int_1, num2 + 1, num - num2 - 1);
			}
			int_2 = value;
			int_0++;
		}
	}

	public static void smethod_0<T>(ref T[] gparam_0, int int_3)
	{
		T[] array = gparam_0;
		if (array == null)
		{
			gparam_0 = new T[int_3];
		}
		else if (array.Length != int_3)
		{
			T[] array2 = new T[int_3];
			Array.Copy(array, 0, array2, 0, (array.Length > int_3) ? int_3 : array.Length);
			gparam_0 = array2;
		}
	}

	static Class0()
	{
		char[] array = new char[8];
		array[2] = 'ᔏ';
		array[5] = '㲯';
		array[7] = '㚶';
		array[4] = '⼉';
		array[3] = '\u302c';
		array[0] = 'Ⱝ';
		array[6] = 'ᶒ';
		array[1] = '㿲';
		array_1 = new string[1];
		object_0 = array;
	}
}
