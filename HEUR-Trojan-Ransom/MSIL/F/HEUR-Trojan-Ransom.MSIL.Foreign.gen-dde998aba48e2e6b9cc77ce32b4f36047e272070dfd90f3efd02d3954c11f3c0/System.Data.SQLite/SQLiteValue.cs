using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteValue : ISQLiteNativeHandle
{
	private IntPtr pValue;

	private bool persisted;

	private object value;

	[NonSerialized]
	internal static GetString _0089;

	public IntPtr NativeHandle => pValue;

	public bool Persisted => persisted;

	public object Value
	{
		get
		{
			if (!persisted)
			{
				throw new InvalidOperationException(_0089(107380038));
			}
			return value;
		}
	}

	private SQLiteValue(IntPtr pValue)
	{
		this.pValue = pValue;
	}

	private void PreventNativeAccess()
	{
		pValue = IntPtr.Zero;
	}

	internal static SQLiteValue[] ArrayFromSizeAndIntPtr(int argc, IntPtr argv)
	{
		if (argc < 0)
		{
			return null;
		}
		if (argv == IntPtr.Zero)
		{
			return null;
		}
		SQLiteValue[] array = new SQLiteValue[argc];
		int num = 0;
		int num2 = 0;
		while (num < array.Length)
		{
			IntPtr intPtr = SQLiteMarshal.ReadIntPtr(argv, num2);
			array[num] = ((intPtr != IntPtr.Zero) ? new SQLiteValue(intPtr) : null);
			num++;
			num2 += IntPtr.Size;
		}
		return array;
	}

	public TypeAffinity GetTypeAffinity()
	{
		if (pValue == IntPtr.Zero)
		{
			return TypeAffinity.None;
		}
		return UnsafeNativeMethods.sqlite3_value_type(pValue);
	}

	public int GetBytes()
	{
		if (pValue == IntPtr.Zero)
		{
			return 0;
		}
		return UnsafeNativeMethods.sqlite3_value_bytes(pValue);
	}

	public int GetInt()
	{
		if (pValue == IntPtr.Zero)
		{
			return 0;
		}
		return UnsafeNativeMethods.sqlite3_value_int(pValue);
	}

	public long GetInt64()
	{
		if (pValue == IntPtr.Zero)
		{
			return 0L;
		}
		return UnsafeNativeMethods.sqlite3_value_int64(pValue);
	}

	public double GetDouble()
	{
		if (pValue == IntPtr.Zero)
		{
			return 0.0;
		}
		return UnsafeNativeMethods.sqlite3_value_double(pValue);
	}

	public string GetString()
	{
		if (pValue == IntPtr.Zero)
		{
			return null;
		}
		int len = 0;
		IntPtr intPtr = UnsafeNativeMethods.sqlite3_value_text_interop(pValue, ref len);
		return SQLiteString.StringFromUtf8IntPtr(intPtr, len);
	}

	public byte[] GetBlob()
	{
		if (pValue == IntPtr.Zero)
		{
			return null;
		}
		return SQLiteBytes.FromIntPtr(UnsafeNativeMethods.sqlite3_value_blob(pValue), GetBytes());
	}

	public bool Persist()
	{
		switch (GetTypeAffinity())
		{
		case TypeAffinity.Uninitialized:
			value = null;
			PreventNativeAccess();
			return persisted = true;
		case TypeAffinity.Int64:
			value = GetInt64();
			PreventNativeAccess();
			return persisted = true;
		case TypeAffinity.Double:
			value = GetDouble();
			PreventNativeAccess();
			return persisted = true;
		case TypeAffinity.Text:
			value = GetString();
			PreventNativeAccess();
			return persisted = true;
		case TypeAffinity.Blob:
			value = GetBytes();
			PreventNativeAccess();
			return persisted = true;
		case TypeAffinity.Null:
			value = DBNull.Value;
			PreventNativeAccess();
			return persisted = true;
		default:
			return false;
		}
	}

	static SQLiteValue()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteValue));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0089(107401337), _0089(107401300)), _0089(107401295), _0089(107401290)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0089(107401317)))
		{
			return;
		}
		throw new SecurityException(_0089(107401260));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
