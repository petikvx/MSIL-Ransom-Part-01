using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal static class SQLiteMarshal
{
	[NonSerialized]
	internal static GetString _0012;

	public static IntPtr IntPtrForOffset(IntPtr pointer, int offset)
	{
		return new IntPtr(pointer.ToInt64() + offset);
	}

	public static int RoundUp(int size, int alignment)
	{
		int num = alignment - 1;
		return (size + num) & ~num;
	}

	public static int NextOffsetOf(int offset, int size, int alignment)
	{
		return RoundUp(offset + size, alignment);
	}

	public static int ReadInt32(IntPtr pointer, int offset)
	{
		return Marshal.ReadInt32(pointer, offset);
	}

	public static long ReadInt64(IntPtr pointer, int offset)
	{
		return Marshal.ReadInt64(pointer, offset);
	}

	public static double ReadDouble(IntPtr pointer, int offset)
	{
		return BitConverter.Int64BitsToDouble(Marshal.ReadInt64(pointer, offset));
	}

	public static IntPtr ReadIntPtr(IntPtr pointer, int offset)
	{
		return Marshal.ReadIntPtr(pointer, offset);
	}

	public static void WriteInt32(IntPtr pointer, int offset, int value)
	{
		Marshal.WriteInt32(pointer, offset, value);
	}

	public static void WriteInt64(IntPtr pointer, int offset, long value)
	{
		Marshal.WriteInt64(pointer, offset, value);
	}

	public static void WriteDouble(IntPtr pointer, int offset, double value)
	{
		Marshal.WriteInt64(pointer, offset, BitConverter.DoubleToInt64Bits(value));
	}

	public static void WriteIntPtr(IntPtr pointer, int offset, IntPtr value)
	{
		Marshal.WriteIntPtr(pointer, offset, value);
	}

	public static int GetHashCode(object value, bool identity)
	{
		if (identity)
		{
			return RuntimeHelpers.GetHashCode(value);
		}
		return value?.GetHashCode() ?? 0;
	}

	static SQLiteMarshal()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteMarshal));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0012(107401394), _0012(107401357)), _0012(107401352), _0012(107401347)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0012(107401374)))
		{
			return;
		}
		throw new SecurityException(_0012(107401317));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
