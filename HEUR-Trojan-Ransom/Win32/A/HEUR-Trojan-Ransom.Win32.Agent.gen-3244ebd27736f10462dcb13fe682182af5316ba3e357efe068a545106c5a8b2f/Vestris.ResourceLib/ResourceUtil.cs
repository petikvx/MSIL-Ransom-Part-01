using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Vestris.ResourceLib;

public abstract class ResourceUtil
{
	public static ushort NEUTRALLANGID => MAKELANGID(0, 0);

	public static ushort USENGLISHLANGID => MAKELANGID(9, 1);

	internal static IntPtr Align(int p)
	{
		return new IntPtr((p + 3) & -4);
	}

	internal static IntPtr Align(IntPtr p)
	{
		return Align(p.ToInt32());
	}

	internal static long PadToWORD(BinaryWriter w)
	{
		long num = w.BaseStream.Position;
		if (num % 2L != 0L)
		{
			long num2 = 2L - num % 2L;
			Pad(w, (ushort)num2);
			num += num2;
		}
		return num;
	}

	internal static long PadToDWORD(BinaryWriter w)
	{
		long num = w.BaseStream.Position;
		if (num % 4L != 0L)
		{
			long num2 = 4L - num % 4L;
			Pad(w, (ushort)num2);
			num += num2;
		}
		return num;
	}

	internal static ushort HiWord(uint value)
	{
		return (ushort)((value & 0xFFFF0000u) >> 16);
	}

	internal static ushort LoWord(uint value)
	{
		return (ushort)(value & 0xFFFFu);
	}

	internal static void WriteAt(BinaryWriter w, long value, long address)
	{
		long position = w.BaseStream.Position;
		w.Seek((int)address, SeekOrigin.Begin);
		w.Write((ushort)value);
		w.Seek((int)position, SeekOrigin.Begin);
	}

	internal static long Pad(BinaryWriter w, ushort len)
	{
		while (len-- > 0)
		{
			w.Write((byte)0);
		}
		return w.BaseStream.Position;
	}

	public static ushort MAKELANGID(int primary, int sub)
	{
		return (ushort)(((ushort)sub << 10) | (ushort)primary);
	}

	public static ushort PRIMARYLANGID(ushort lcid)
	{
		return (ushort)(lcid & 0x3FFu);
	}

	public static ushort SUBLANGID(ushort lcid)
	{
		return (ushort)(lcid >> 10);
	}

	internal static byte[] GetBytes<T>(T anything)
	{
		int num = Marshal.SizeOf((object)anything);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)anything, intPtr, fDeleteOld: false);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	internal static List<string> FlagsToList<T>(uint flagValue)
	{
		List<string> list = new List<string>();
		foreach (T value in Enum.GetValues(typeof(T)))
		{
			uint num = Convert.ToUInt32(value);
			if ((flagValue & num) != 0 || flagValue == num)
			{
				list.Add(value.ToString());
			}
		}
		return list;
	}

	internal static string FlagsToString<T>(uint flagValue)
	{
		List<string> list = new List<string>();
		list.AddRange(FlagsToList<T>(flagValue));
		return string.Join(" | ", list.ToArray());
	}
}
