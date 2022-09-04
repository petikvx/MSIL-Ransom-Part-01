using System.Runtime.InteropServices;

namespace System.Data.SQLite;

internal class SQLite3_UTF16 : SQLite3
{
	internal SQLite3_UTF16(SQLiteDateFormats fmt)
		: base(fmt)
	{
	}

	public override string ToString(IntPtr b, int nbytelen)
	{
		return UTF16ToString(b, nbytelen);
	}

	public static string UTF16ToString(IntPtr b, int nbytelen)
	{
		if (nbytelen != 0 && !(b == IntPtr.Zero))
		{
			if (nbytelen == -1)
			{
				return Marshal.PtrToStringUni(b);
			}
			return Marshal.PtrToStringUni(b, nbytelen / 2);
		}
		return "";
	}

	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool)
	{
		if (_sql != null)
		{
			return;
		}
		_usePool = usePool;
		if (usePool)
		{
			_fileName = strFilename;
			_sql = SQLiteConnectionPool.Remove(strFilename, maxPoolSize, out _poolVersion);
		}
		if (_sql == null)
		{
			IntPtr db;
			int num = UnsafeNativeMethods.sqlite3_open16_interop(SQLiteConvert.ToUTF8(strFilename), (int)flags, out db);
			if (num > 0)
			{
				throw new SQLiteException(num, null);
			}
			_sql = db;
		}
		_functionsArray = SQLiteFunction.BindFunctions(this);
	}

	internal override void Bind_DateTime(SQLiteStatement stmt, int index, DateTime dt)
	{
		Bind_Text(stmt, index, ToString(dt));
	}

	internal override void Bind_Text(SQLiteStatement stmt, int index, string value)
	{
		int num = UnsafeNativeMethods.sqlite3_bind_text16(stmt._sqlite_stmt, index, value, value.Length * 2, (IntPtr)(-1));
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override DateTime GetDateTime(SQLiteStatement stmt, int index)
	{
		return ToDateTime(GetText(stmt, index));
	}

	internal override string ColumnName(SQLiteStatement stmt, int index)
	{
		int len;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_name16_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override string GetText(SQLiteStatement stmt, int index)
	{
		int len;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_text16_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override string ColumnOriginalName(SQLiteStatement stmt, int index)
	{
		int len;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_origin_name16_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override string ColumnDatabaseName(SQLiteStatement stmt, int index)
	{
		int len;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_database_name16_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override string ColumnTableName(SQLiteStatement stmt, int index)
	{
		int len;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_table_name16_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override string GetParamValueText(IntPtr ptr)
	{
		int len;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_value_text16_interop(ptr, out len), len);
	}

	internal override void ReturnError(IntPtr context, string value)
	{
		UnsafeNativeMethods.sqlite3_result_error16(context, value, value.Length * 2);
	}

	internal override void ReturnText(IntPtr context, string value)
	{
		UnsafeNativeMethods.sqlite3_result_text16(context, value, value.Length * 2, (IntPtr)(-1));
	}
}
