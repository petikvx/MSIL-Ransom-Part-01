using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteContext : ISQLiteNativeHandle
{
	private IntPtr pContext;

	[NonSerialized]
	internal static GetString _0095;

	public IntPtr NativeHandle => pContext;

	internal SQLiteContext(IntPtr pContext)
	{
		this.pContext = pContext;
	}

	public void SetNull()
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_null(pContext);
	}

	public void SetDouble(double value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_double(pContext, value);
	}

	public void SetInt(int value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_int(pContext, value);
	}

	public void SetInt64(long value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_int64(pContext, value);
	}

	public void SetString(string value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		byte[] utf8BytesFromString = SQLiteString.GetUtf8BytesFromString(value);
		if (utf8BytesFromString == null)
		{
			throw new ArgumentNullException(_0095(107394562));
		}
		UnsafeNativeMethods.sqlite3_result_text(pContext, utf8BytesFromString, utf8BytesFromString.Length, (IntPtr)(-1));
	}

	public void SetError(string value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		byte[] utf8BytesFromString = SQLiteString.GetUtf8BytesFromString(value);
		if (utf8BytesFromString == null)
		{
			throw new ArgumentNullException(_0095(107394562));
		}
		UnsafeNativeMethods.sqlite3_result_error(pContext, utf8BytesFromString, utf8BytesFromString.Length);
	}

	public void SetErrorCode(SQLiteErrorCode value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_error_code(pContext, value);
	}

	public void SetErrorTooBig()
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_error_toobig(pContext);
	}

	public void SetErrorNoMemory()
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_error_nomem(pContext);
	}

	public void SetBlob(byte[] value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		if (value == null)
		{
			throw new ArgumentNullException(_0095(107394562));
		}
		UnsafeNativeMethods.sqlite3_result_blob(pContext, value, value.Length, (IntPtr)(-1));
	}

	public void SetZeroBlob(int value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		UnsafeNativeMethods.sqlite3_result_zeroblob(pContext, value);
	}

	public void SetValue(SQLiteValue value)
	{
		if (pContext == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		if (value == null)
		{
			throw new ArgumentNullException(_0095(107394562));
		}
		UnsafeNativeMethods.sqlite3_result_value(pContext, value.NativeHandle);
	}

	static SQLiteContext()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteContext));
	}
}
