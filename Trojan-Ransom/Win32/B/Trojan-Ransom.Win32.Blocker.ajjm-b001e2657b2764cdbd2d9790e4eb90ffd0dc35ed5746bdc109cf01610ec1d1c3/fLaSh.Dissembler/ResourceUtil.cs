using System;
using System.IO;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public abstract class ResourceUtil
{
	public static int NEUTRALLANGID => MAKELANGID(0, 0);

	public static bool IsIntResource(IntPtr value)
	{
		if ((uint)(int)value > 65535u)
		{
			return false;
		}
		return true;
	}

	public static uint GetResourceID(IntPtr value)
	{
		if (!IsIntResource(value))
		{
			throw new NotSupportedException(value.ToString());
		}
		return (uint)(int)value;
	}

	public static string GetResourceName(IntPtr value)
	{
		if (IsIntResource(value))
		{
			return value.ToString();
		}
		return Marshal.PtrToStringUni(value);
	}

	public static IntPtr Align(int p)
	{
		return new IntPtr((p + 3) & -4);
	}

	public static IntPtr Align(IntPtr p)
	{
		return Align(p.ToInt32());
	}

	public static long smethod_0(BinaryWriter w)
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

	public static long smethod_1(BinaryWriter w)
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

	public static void WriteAt(BinaryWriter w, long value, long address)
	{
		long position = w.BaseStream.Position;
		w.Seek((int)address, SeekOrigin.Begin);
		w.Write((ushort)value);
		w.Seek((int)position, SeekOrigin.Begin);
	}

	public static long Pad(BinaryWriter w, ushort len)
	{
		while (len-- > 0)
		{
			w.Write((byte)0);
		}
		return w.BaseStream.Position;
	}

	public static int MAKELANGID(int primary, int sub)
	{
		return ((ushort)sub << 10) | (ushort)primary;
	}

	public static int PRIMARYLANGID(int lcid)
	{
		return (ushort)lcid & 0x3FF;
	}

	public static int SUBLANGID(int lcid)
	{
		return (ushort)lcid >> 10;
	}

	public static byte[] GetByts<T>(T anything)
	{
		int num = Marshal.SizeOf((object)anything);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)anything, intPtr, fDeleteOld: false);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}
}
