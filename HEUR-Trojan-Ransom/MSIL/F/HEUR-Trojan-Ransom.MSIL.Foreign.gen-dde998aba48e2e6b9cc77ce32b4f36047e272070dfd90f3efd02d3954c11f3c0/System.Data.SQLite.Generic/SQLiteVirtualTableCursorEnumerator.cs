using System.Collections;
using System.Collections.Generic;

namespace System.Data.SQLite.Generic;

public sealed class SQLiteVirtualTableCursorEnumerator<T> : SQLiteVirtualTableCursorEnumerator, IDisposable, IEnumerator, IEnumerator<T>
{
	private IEnumerator<T> enumerator;

	private bool disposed;

	T IEnumerator<T>.Current
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			if (enumerator == null)
			{
				return default(T);
			}
			return enumerator.Current;
		}
	}

	public SQLiteVirtualTableCursorEnumerator(SQLiteVirtualTable table, IEnumerator<T> enumerator)
		: base(table, enumerator)
	{
		this.enumerator = enumerator;
	}

	public override void Close()
	{
		if (enumerator != null)
		{
			enumerator = null;
		}
		base.Close();
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteVirtualTableCursorEnumerator<T>).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposed)
			{
				Close();
			}
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}
}
