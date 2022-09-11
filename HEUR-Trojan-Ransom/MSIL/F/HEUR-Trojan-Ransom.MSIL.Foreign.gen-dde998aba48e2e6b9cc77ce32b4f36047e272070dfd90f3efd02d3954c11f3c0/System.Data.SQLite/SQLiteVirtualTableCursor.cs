using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public class SQLiteVirtualTableCursor : IDisposable, ISQLiteNativeHandle
{
	protected static readonly int InvalidRowIndex;

	private int rowIndex;

	private SQLiteVirtualTable table;

	private int indexNumber;

	private string indexString;

	private SQLiteValue[] values;

	private IntPtr nativeHandle;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0013;

	public virtual SQLiteVirtualTable Table
	{
		get
		{
			CheckDisposed();
			return table;
		}
	}

	public virtual int IndexNumber
	{
		get
		{
			CheckDisposed();
			return indexNumber;
		}
	}

	public virtual string IndexString
	{
		get
		{
			CheckDisposed();
			return indexString;
		}
	}

	public virtual SQLiteValue[] Values
	{
		get
		{
			CheckDisposed();
			return values;
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

	public SQLiteVirtualTableCursor(SQLiteVirtualTable table)
		: this()
	{
		this.table = table;
	}

	private SQLiteVirtualTableCursor()
	{
		rowIndex = InvalidRowIndex;
	}

	protected virtual int TryPersistValues(SQLiteValue[] values)
	{
		int num = 0;
		if (values != null)
		{
			foreach (SQLiteValue sQLiteValue in values)
			{
				if (sQLiteValue != null && sQLiteValue.Persist())
				{
					num++;
				}
			}
		}
		return num;
	}

	public virtual void Filter(int indexNumber, string indexString, SQLiteValue[] values)
	{
		CheckDisposed();
		if (values != null && TryPersistValues(values) != values.Length)
		{
			throw new SQLiteException(_0013(107380058));
		}
		this.indexNumber = indexNumber;
		this.indexString = indexString;
		this.values = values;
	}

	public virtual int GetRowIndex()
	{
		return rowIndex;
	}

	public virtual void NextRowIndex()
	{
		rowIndex++;
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
			throw new ObjectDisposedException(typeof(SQLiteVirtualTableCursor).Name);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			disposed = true;
		}
	}

	~SQLiteVirtualTableCursor()
	{
		Dispose(disposing: false);
	}

	static SQLiteVirtualTableCursor()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteVirtualTableCursor));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0013(107401390), _0013(107401353)).Replace(_0013(107401348), _0013(107401343)));
		if (StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) && flag && executingAssembly.FullName!.EndsWith(_0013(107401370)))
		{
			return;
		}
		throw new SecurityException(_0013(107401313));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
