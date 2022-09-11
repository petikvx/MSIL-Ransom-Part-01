namespace System.Data.SQLite;

public sealed class SQLiteVirtualTable : IDisposable, ISQLiteNativeHandle
{
	private const int ModuleNameIndex = 0;

	private const int DatabaseNameIndex = 1;

	private const int TableNameIndex = 2;

	private string[] arguments;

	private SQLiteIndex index;

	private IntPtr nativeHandle;

	private bool disposed;

	public virtual string[] Arguments
	{
		get
		{
			CheckDisposed();
			return arguments;
		}
	}

	public virtual string ModuleName
	{
		get
		{
			CheckDisposed();
			string[] array = Arguments;
			if (array != null && array.Length > 0)
			{
				return array[0];
			}
			return null;
		}
	}

	public virtual string DatabaseName
	{
		get
		{
			CheckDisposed();
			string[] array = Arguments;
			if (array != null && array.Length > 1)
			{
				return array[1];
			}
			return null;
		}
	}

	public virtual string TableName
	{
		get
		{
			CheckDisposed();
			string[] array = Arguments;
			if (array != null && array.Length > 2)
			{
				return array[2];
			}
			return null;
		}
	}

	public virtual SQLiteIndex Index
	{
		get
		{
			CheckDisposed();
			return index;
		}
	}

	public virtual IntPtr NativeHandle
	{
		get
		{
			CheckDisposed();
			return nativeHandle;
		}
		internal set
		{
			nativeHandle = value;
		}
	}

	public SQLiteVirtualTable(string[] arguments)
	{
		this.arguments = arguments;
	}

	public virtual bool BestIndex(SQLiteIndex index)
	{
		CheckDisposed();
		this.index = index;
		return true;
	}

	public virtual bool Rename(string name)
	{
		CheckDisposed();
		if (arguments != null && arguments.Length > 2)
		{
			arguments[2] = name;
			return true;
		}
		return false;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteVirtualTable).Name);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			disposed = true;
		}
	}

	~SQLiteVirtualTable()
	{
		Dispose(disposing: false);
	}
}
