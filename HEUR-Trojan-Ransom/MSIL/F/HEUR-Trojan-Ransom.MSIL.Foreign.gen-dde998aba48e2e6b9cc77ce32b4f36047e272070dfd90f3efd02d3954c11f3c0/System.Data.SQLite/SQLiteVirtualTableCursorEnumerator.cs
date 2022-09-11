using System.Collections;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public class SQLiteVirtualTableCursorEnumerator : SQLiteVirtualTableCursor, IEnumerator
{
	private IEnumerator enumerator;

	private bool endOfEnumerator;

	private bool disposed;

	[NonSerialized]
	internal static GetString _007F;

	public virtual object Current
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			if (enumerator == null)
			{
				return null;
			}
			return enumerator.Current;
		}
	}

	public virtual bool EndOfEnumerator
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			return endOfEnumerator;
		}
	}

	public virtual bool IsOpen
	{
		get
		{
			CheckDisposed();
			return enumerator != null;
		}
	}

	public SQLiteVirtualTableCursorEnumerator(SQLiteVirtualTable table, IEnumerator enumerator)
		: base(table)
	{
		this.enumerator = enumerator;
		endOfEnumerator = true;
	}

	public virtual bool MoveNext()
	{
		CheckDisposed();
		CheckClosed();
		if (enumerator == null)
		{
			return false;
		}
		endOfEnumerator = !enumerator.MoveNext();
		if (!endOfEnumerator)
		{
			NextRowIndex();
		}
		return !endOfEnumerator;
	}

	public virtual void Reset()
	{
		CheckDisposed();
		CheckClosed();
		if (enumerator != null)
		{
			enumerator.Reset();
		}
	}

	public virtual void Close()
	{
		if (enumerator != null)
		{
			enumerator = null;
		}
	}

	public virtual void CheckClosed()
	{
		CheckDisposed();
		if (!IsOpen)
		{
			throw new InvalidOperationException(_007F(107378470));
		}
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteVirtualTableCursorEnumerator).Name);
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

	static SQLiteVirtualTableCursorEnumerator()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteVirtualTableCursorEnumerator));
	}
}
