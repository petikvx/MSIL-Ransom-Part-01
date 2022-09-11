using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal static class SQLiteString
{
	private static int ThirtyBits;

	private static readonly Encoding Utf8Encoding;

	[NonSerialized]
	internal static GetString _000F;

	public static byte[] GetUtf8BytesFromString(string value)
	{
		if (value == null)
		{
			return null;
		}
		return Utf8Encoding.GetBytes(value);
	}

	public static string GetStringFromUtf8Bytes(byte[] bytes)
	{
		if (bytes == null)
		{
			return null;
		}
		return Utf8Encoding.GetString(bytes);
	}

	public static int ProbeForUtf8ByteLength(IntPtr pValue, int limit)
	{
		int i = 0;
		if (pValue != IntPtr.Zero && limit > 0)
		{
			for (; Marshal.ReadByte(pValue, i) != 0 && i < limit; i++)
			{
			}
		}
		return i;
	}

	public static string StringFromUtf8IntPtr(IntPtr pValue)
	{
		return StringFromUtf8IntPtr(pValue, ProbeForUtf8ByteLength(pValue, ThirtyBits));
	}

	public static string StringFromUtf8IntPtr(IntPtr pValue, int length)
	{
		if (pValue == IntPtr.Zero)
		{
			return null;
		}
		if (length > 0)
		{
			byte[] array = new byte[length];
			Marshal.Copy(pValue, array, 0, length);
			return GetStringFromUtf8Bytes(array);
		}
		return string.Empty;
	}

	public static IntPtr Utf8IntPtrFromString(string value)
	{
		if (value == null)
		{
			return IntPtr.Zero;
		}
		IntPtr zero = IntPtr.Zero;
		byte[] utf8BytesFromString = GetUtf8BytesFromString(value);
		if (utf8BytesFromString == null)
		{
			return IntPtr.Zero;
		}
		int num = utf8BytesFromString.Length;
		zero = SQLiteMemory.Allocate(num + 1);
		if (zero == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		Marshal.Copy(utf8BytesFromString, 0, zero, num);
		Marshal.WriteByte(zero, num, 0);
		return zero;
	}

	public static string[] StringArrayFromUtf8SizeAndIntPtr(int argc, IntPtr argv)
	{
		if (argc < 0)
		{
			return null;
		}
		if (argv == IntPtr.Zero)
		{
			return null;
		}
		string[] array = new string[argc];
		int num = 0;
		int num2 = 0;
		while (num < array.Length)
		{
			IntPtr intPtr = SQLiteMarshal.ReadIntPtr(argv, num2);
			array[num] = ((intPtr != IntPtr.Zero) ? StringFromUtf8IntPtr(intPtr) : null);
			num++;
			num2 += IntPtr.Size;
		}
		return array;
	}

	public static IntPtr[] Utf8IntPtrArrayFromStringArray(string[] values)
	{
		if (values == null)
		{
			return null;
		}
		IntPtr[] array = new IntPtr[values.Length];
		for (int i = 0; i < array.Length; i++)
		{
			ref IntPtr reference = ref array[i];
			reference = Utf8IntPtrFromString(values[i]);
		}
		return array;
	}

	static SQLiteString()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteString));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_000F(107401393), _000F(107401356)).Replace(_000F(107401351), _000F(107401346)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_000F(107401373)))
		{
			throw new SecurityException(_000F(107401316));
		}
		ThirtyBits = 1073741823;
		Utf8Encoding = Encoding.UTF8;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
