using System.Runtime.InteropServices;

namespace System.Data.SQLite;

internal class SQLiteStatementHandle : CriticalHandle
{
	public override bool IsInvalid => handle == IntPtr.Zero;

	public static implicit operator IntPtr(SQLiteStatementHandle stmt)
	{
		return stmt.handle;
	}

	public static implicit operator SQLiteStatementHandle(IntPtr stmt)
	{
		return new SQLiteStatementHandle(stmt);
	}

	private SQLiteStatementHandle(IntPtr stmt)
		: this()
	{
		SetHandle(stmt);
	}

	internal SQLiteStatementHandle()
		: base(IntPtr.Zero)
	{
	}

	protected override bool ReleaseHandle()
	{
		try
		{
			SQLiteBase.FinalizeStatement(this);
		}
		catch (SQLiteException)
		{
		}
		return true;
	}
}
