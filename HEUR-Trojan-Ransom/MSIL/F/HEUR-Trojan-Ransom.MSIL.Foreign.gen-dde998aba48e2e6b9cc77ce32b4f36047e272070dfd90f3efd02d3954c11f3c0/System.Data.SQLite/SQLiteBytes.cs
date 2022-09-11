using System.Runtime.InteropServices;

namespace System.Data.SQLite;

internal static class SQLiteBytes
{
	public static byte[] FromIntPtr(IntPtr pValue, int length)
	{
		if (pValue == IntPtr.Zero)
		{
			return null;
		}
		if (length == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[length];
		Marshal.Copy(pValue, array, 0, length);
		return array;
	}

	public static IntPtr ToIntPtr(byte[] value)
	{
		if (value == null)
		{
			return IntPtr.Zero;
		}
		int num = value.Length;
		if (num == 0)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = SQLiteMemory.Allocate(num);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		Marshal.Copy(value, 0, intPtr, num);
		return intPtr;
	}
}
