using System.Collections.Generic;

namespace System.Data.SQLite.Generic;

public sealed class SQLiteModuleEnumerable<T> : SQLiteModuleEnumerable
{
	private IEnumerable<T> enumerable;

	private bool disposed;

	public SQLiteModuleEnumerable(string name, IEnumerable<T> enumerable)
		: base(name, enumerable)
	{
		this.enumerable = enumerable;
	}

	public override SQLiteErrorCode Open(SQLiteVirtualTable table, ref SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		cursor = new SQLiteVirtualTableCursorEnumerator<T>(table, enumerable.GetEnumerator());
		return SQLiteErrorCode.Ok;
	}

	public override SQLiteErrorCode Column(SQLiteVirtualTableCursor cursor, SQLiteContext context, int index)
	{
		CheckDisposed();
		if (!(cursor is SQLiteVirtualTableCursorEnumerator<T> sQLiteVirtualTableCursorEnumerator))
		{
			return CursorTypeMismatchError(cursor, typeof(SQLiteVirtualTableCursorEnumerator));
		}
		if (sQLiteVirtualTableCursorEnumerator.EndOfEnumerator)
		{
			return CursorEndOfEnumeratorError(cursor);
		}
		T current = ((IEnumerator<T>)sQLiteVirtualTableCursorEnumerator).Current;
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

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteModuleEnumerable<T>).Name);
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
}
