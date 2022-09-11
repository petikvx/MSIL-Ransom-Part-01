using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public class SQLiteModuleEnumerable : SQLiteModuleCommon
{
	private IEnumerable enumerable;

	private bool objectIdentity;

	private bool disposed;

	[NonSerialized]
	internal static GetString _000E;

	public SQLiteModuleEnumerable(string name, IEnumerable enumerable)
		: this(name, enumerable, objectIdentity: false)
	{
	}

	public SQLiteModuleEnumerable(string name, IEnumerable enumerable, bool objectIdentity)
		: base(name)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException(_000E(107378465));
		}
		this.enumerable = enumerable;
		this.objectIdentity = objectIdentity;
	}

	protected virtual SQLiteErrorCode CursorEndOfEnumeratorError(SQLiteVirtualTableCursor cursor)
	{
		SetCursorError(cursor, _000E(107378416));
		return SQLiteErrorCode.Error;
	}

	public override SQLiteErrorCode Create(SQLiteConnection connection, IntPtr pClientData, string[] arguments, ref SQLiteVirtualTable table, ref string error)
	{
		CheckDisposed();
		if (DeclareTable(connection, GetSqlForDeclareTable(), ref error) == SQLiteErrorCode.Ok)
		{
			table = new SQLiteVirtualTable(arguments);
			return SQLiteErrorCode.Ok;
		}
		return SQLiteErrorCode.Error;
	}

	public override SQLiteErrorCode Connect(SQLiteConnection connection, IntPtr pClientData, string[] arguments, ref SQLiteVirtualTable table, ref string error)
	{
		CheckDisposed();
		if (DeclareTable(connection, GetSqlForDeclareTable(), ref error) == SQLiteErrorCode.Ok)
		{
			table = new SQLiteVirtualTable(arguments);
			return SQLiteErrorCode.Ok;
		}
		return SQLiteErrorCode.Error;
	}

	public override SQLiteErrorCode BestIndex(SQLiteVirtualTable table, SQLiteIndex index)
	{
		CheckDisposed();
		if (!table.BestIndex(index))
		{
			SetTableError(table, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _000E(107378375), table.TableName));
			return SQLiteErrorCode.Error;
		}
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Disconnect(SQLiteVirtualTable table)
	{
		CheckDisposed();
		table.Dispose();
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Destroy(SQLiteVirtualTable table)
	{
		CheckDisposed();
		table.Dispose();
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Open(SQLiteVirtualTable table, ref SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		cursor = new SQLiteVirtualTableCursorEnumerator(table, enumerable.GetEnumerator());
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Close(SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		if (!(cursor is SQLiteVirtualTableCursorEnumerator sQLiteVirtualTableCursorEnumerator))
		{
			return CursorTypeMismatchError(cursor, typeof(SQLiteVirtualTableCursorEnumerator));
		}
		sQLiteVirtualTableCursorEnumerator.Close();
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Filter(SQLiteVirtualTableCursor cursor, int indexNumber, string indexString, SQLiteValue[] values)
	{
		CheckDisposed();
		if (!(cursor is SQLiteVirtualTableCursorEnumerator sQLiteVirtualTableCursorEnumerator))
		{
			return CursorTypeMismatchError(cursor, typeof(SQLiteVirtualTableCursorEnumerator));
		}
		sQLiteVirtualTableCursorEnumerator.Filter(indexNumber, indexString, values);
		sQLiteVirtualTableCursorEnumerator.Reset();
		sQLiteVirtualTableCursorEnumerator.MoveNext();
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Next(SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		if (!(cursor is SQLiteVirtualTableCursorEnumerator sQLiteVirtualTableCursorEnumerator))
		{
			return CursorTypeMismatchError(cursor, typeof(SQLiteVirtualTableCursorEnumerator));
		}
		if (sQLiteVirtualTableCursorEnumerator.EndOfEnumerator)
		{
			return CursorEndOfEnumeratorError(cursor);
		}
		sQLiteVirtualTableCursorEnumerator.MoveNext();
		return SQLiteErrorCode.Ok;
	}

	public override bool Eof(SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		if (!(cursor is SQLiteVirtualTableCursorEnumerator sQLiteVirtualTableCursorEnumerator))
		{
			return ResultCodeToEofResult(CursorTypeMismatchError(cursor, typeof(SQLiteVirtualTableCursorEnumerator)));
		}
		return sQLiteVirtualTableCursorEnumerator.EndOfEnumerator;
	}

	public override SQLiteErrorCode Column(SQLiteVirtualTableCursor cursor, SQLiteContext context, int index)
	{
		CheckDisposed();
		if (!(cursor is SQLiteVirtualTableCursorEnumerator sQLiteVirtualTableCursorEnumerator))
		{
			return CursorTypeMismatchError(cursor, typeof(SQLiteVirtualTableCursorEnumerator));
		}
		if (sQLiteVirtualTableCursorEnumerator.EndOfEnumerator)
		{
			return CursorEndOfEnumeratorError(cursor);
		}
		object current = sQLiteVirtualTableCursorEnumerator.Current;
		if (current != null)
		{
			context.SetString(GetStringFromObject(cursor, current));
		}
		else
		{
			context.SetNull();
		}
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode RowId(SQLiteVirtualTableCursor cursor, ref long rowId)
	{
		CheckDisposed();
		if (!(cursor is SQLiteVirtualTableCursorEnumerator sQLiteVirtualTableCursorEnumerator))
		{
			return CursorTypeMismatchError(cursor, typeof(SQLiteVirtualTableCursorEnumerator));
		}
		if (sQLiteVirtualTableCursorEnumerator.EndOfEnumerator)
		{
			return CursorEndOfEnumeratorError(cursor);
		}
		object current = sQLiteVirtualTableCursorEnumerator.Current;
		rowId = GetRowIdFromObject(cursor, current);
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Update(SQLiteVirtualTable table, SQLiteValue[] values, ref long rowId)
	{
		CheckDisposed();
		SetTableError(table, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _000E(107378338), table.TableName));
		return SQLiteErrorCode.Error;
	}

	public override SQLiteErrorCode Rename(SQLiteVirtualTable table, string newName)
	{
		CheckDisposed();
		if (!table.Rename(newName))
		{
			SetTableError(table, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _000E(107378293), table.TableName, newName));
			return SQLiteErrorCode.Error;
		}
		return SQLiteErrorCode.Ok;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteModuleEnumerable).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			_ = disposed;
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	static SQLiteModuleEnumerable()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteModuleEnumerable));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(global::_0007._007E_0087(global::_0007._007E_0087(_0006._007E_001C(assembly), _000E(107401428), _000E(107401391)), _000E(107401386), _000E(107401381)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _000E(107401408)))
		{
			return;
		}
		throw new SecurityException(_000E(107401351));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
