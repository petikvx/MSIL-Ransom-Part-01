using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

internal abstract class Class15
{
	internal static IntPtr smethod_0(int int_0)
	{
		return new IntPtr((int_0 + 3) & -4);
	}

	internal static long smethod_1(BinaryWriter binaryWriter_0)
	{
		long num = binaryWriter_0.BaseStream.Position;
		if (num % 2L != 0L)
		{
			long num2 = 2L - num % 2L;
			smethod_6(binaryWriter_0, (ushort)num2);
			num += num2;
		}
		return num;
	}

	internal static long smethod_2(BinaryWriter binaryWriter_0)
	{
		long num = binaryWriter_0.BaseStream.Position;
		if (num % 4L != 0L)
		{
			long num2 = 4L - num % 4L;
			smethod_6(binaryWriter_0, (ushort)num2);
			num += num2;
		}
		return num;
	}

	internal static ushort smethod_3(uint uint_0)
	{
		return (ushort)((uint_0 & 0xFFFF0000u) >> 16);
	}

	internal static ushort smethod_4(uint uint_0)
	{
		return (ushort)(uint_0 & 0xFFFFu);
	}

	internal static void smethod_5(BinaryWriter binaryWriter_0, long long_0, long long_1)
	{
		long position = binaryWriter_0.BaseStream.Position;
		binaryWriter_0.Seek((int)long_1, SeekOrigin.Begin);
		binaryWriter_0.Write((ushort)long_0);
		binaryWriter_0.Seek((int)position, SeekOrigin.Begin);
	}

	internal static long smethod_6(BinaryWriter binaryWriter_0, ushort ushort_0)
	{
		while (ushort_0-- > 0)
		{
			binaryWriter_0.Write((byte)0);
		}
		return binaryWriter_0.BaseStream.Position;
	}

	[SpecialName]
	public static ushort smethod_7()
	{
		return smethod_9(0, 0);
	}

	[SpecialName]
	public static ushort smethod_8()
	{
		return smethod_9(9, 1);
	}

	public static ushort smethod_9(int int_0, int int_1)
	{
		return (ushort)(((ushort)int_1 << 10) | (ushort)int_0);
	}

	internal static byte[] smethod_10<T>(T gparam_0)
	{
		int num = Marshal.SizeOf((object)gparam_0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)gparam_0, intPtr, fDeleteOld: false);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	internal static List<string> smethod_11<T>(uint uint_0)
	{
		List<string> list = new List<string>();
		foreach (T value in Enum.GetValues(typeof(T)))
		{
			uint num = Convert.ToUInt32(value);
			if ((uint_0 & num) != 0 || uint_0 == num)
			{
				list.Add(value.ToString());
			}
		}
		return list;
	}

	internal static string smethod_12<T>(uint uint_0)
	{
		List<string> list = new List<string>();
		list.AddRange(smethod_11<T>(uint_0));
		return string.Join(" | ", list.ToArray());
	}
}
