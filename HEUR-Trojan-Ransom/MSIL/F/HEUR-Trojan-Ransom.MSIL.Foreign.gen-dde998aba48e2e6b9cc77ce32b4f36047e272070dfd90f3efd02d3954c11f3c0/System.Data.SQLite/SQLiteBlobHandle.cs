using System.Runtime.InteropServices;
using System.Threading;

namespace System.Data.SQLite;

internal sealed class SQLiteBlobHandle : CriticalHandle
{
	private SQLiteConnectionHandle cnn;

	public override bool IsInvalid => handle == IntPtr.Zero;

	public static implicit operator IntPtr(SQLiteBlobHandle blob)
	{
		return blob?.handle ?? IntPtr.Zero;
	}

	internal SQLiteBlobHandle(SQLiteConnectionHandle cnn, IntPtr blob)
		: this()
	{
		this.cnn = cnn;
		SetHandle(blob);
	}

	private SQLiteBlobHandle()
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
				SQLiteBase.CloseBlob(cnn, intPtr);
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
