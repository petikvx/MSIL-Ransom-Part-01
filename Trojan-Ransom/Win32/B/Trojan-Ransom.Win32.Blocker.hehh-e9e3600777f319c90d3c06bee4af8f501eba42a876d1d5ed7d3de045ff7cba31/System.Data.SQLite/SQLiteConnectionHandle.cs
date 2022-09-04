using System.Runtime.InteropServices;

namespace System.Data.SQLite;

internal class SQLiteConnectionHandle : CriticalHandle
{
	public override bool IsInvalid => handle == IntPtr.Zero;

	public static implicit operator IntPtr(SQLiteConnectionHandle db)
	{
		return db.handle;
	}

	public static implicit operator SQLiteConnectionHandle(IntPtr db)
	{
		return new SQLiteConnectionHandle(db);
	}

	private SQLiteConnectionHandle(IntPtr db)
		: this()
	{
		SetHandle(db);
	}

	internal SQLiteConnectionHandle()
		: base(IntPtr.Zero)
	{
	}

	protected override bool ReleaseHandle()
	{
		try
		{
			SQLiteBase.CloseConnection(this);
		}
		catch (SQLiteException)
		{
		}
		return true;
	}
}
