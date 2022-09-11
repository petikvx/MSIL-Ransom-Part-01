using System.Runtime.InteropServices;
using System.Threading;

namespace System.Data.SQLite;

internal sealed class SQLiteStatementHandle : CriticalHandle
{
	private SQLiteConnectionHandle cnn;

	public override bool IsInvalid => handle == IntPtr.Zero;

	public static implicit operator IntPtr(SQLiteStatementHandle stmt)
	{
		return stmt?.handle ?? IntPtr.Zero;
	}

	internal SQLiteStatementHandle(SQLiteConnectionHandle cnn, IntPtr stmt)
		: this()
	{
		this.cnn = cnn;
		SetHandle(stmt);
	}

	private SQLiteStatementHandle()
		: base(IntPtr.Zero)
	{
	}

	protected override bool ReleaseHandle()
	{
		try
		{
			IntPtr intPtr = Interlocked.Exchange(ref handle, IntPtr.Zero);
			if (intPtr != IntPtr.Zero)
			{
				SQLiteBase.FinalizeStatement(cnn, intPtr);
			}
		}
		catch (SQLiteException)
		{
		}
		finally
		{
			SetHandleAsInvalid();
		}
		return true;
	}
}
