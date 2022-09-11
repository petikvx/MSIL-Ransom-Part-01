using System.Collections.Generic;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public class SQLiteModuleNoop : SQLiteModule
{
	private Dictionary<string, SQLiteErrorCode> resultCodes;

	private bool disposed;

	[NonSerialized]
	internal static GetString _001C;

	public SQLiteModuleNoop(string name)
		: base(name)
	{
		resultCodes = new Dictionary<string, SQLiteErrorCode>();
	}

	protected virtual SQLiteErrorCode GetDefaultResultCode()
	{
		return SQLiteErrorCode.Ok;
	}

	protected virtual bool ResultCodeToEofResult(SQLiteErrorCode resultCode)
	{
		if (resultCode != 0)
		{
			return true;
		}
		return false;
	}

	protected virtual bool ResultCodeToFindFunctionResult(SQLiteErrorCode resultCode)
	{
		if (resultCode != 0)
		{
			return false;
		}
		return true;
	}

	protected virtual SQLiteErrorCode GetMethodResultCode(string methodName)
	{
		if (methodName == null || resultCodes == null)
		{
			return GetDefaultResultCode();
		}
		if (resultCodes != null && resultCodes.TryGetValue(methodName, out var value))
		{
			return value;
		}
		return GetDefaultResultCode();
	}

	protected virtual bool SetMethodResultCode(string methodName, SQLiteErrorCode resultCode)
	{
		if (methodName == null || resultCodes == null)
		{
			return false;
		}
		resultCodes[methodName] = resultCode;
		return true;
	}

	public override SQLiteErrorCode Create(SQLiteConnection connection, IntPtr pClientData, string[] arguments, ref SQLiteVirtualTable table, ref string error)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107378787));
	}

	public override SQLiteErrorCode Connect(SQLiteConnection connection, IntPtr pClientData, string[] arguments, ref SQLiteVirtualTable table, ref string error)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107378778));
	}

	public override SQLiteErrorCode BestIndex(SQLiteVirtualTable table, SQLiteIndex index)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107378797));
	}

	public override SQLiteErrorCode Disconnect(SQLiteVirtualTable table)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379264));
	}

	public override SQLiteErrorCode Destroy(SQLiteVirtualTable table)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379279));
	}

	public override SQLiteErrorCode Open(SQLiteVirtualTable table, ref SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379234));
	}

	public override SQLiteErrorCode Close(SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379225));
	}

	public override SQLiteErrorCode Filter(SQLiteVirtualTableCursor cursor, int indexNumber, string indexString, SQLiteValue[] values)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379248));
	}

	public override SQLiteErrorCode Next(SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379239));
	}

	public override bool Eof(SQLiteVirtualTableCursor cursor)
	{
		CheckDisposed();
		return ResultCodeToEofResult(GetMethodResultCode(_001C(107379198)));
	}

	public override SQLiteErrorCode Column(SQLiteVirtualTableCursor cursor, SQLiteContext context, int index)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379193));
	}

	public override SQLiteErrorCode RowId(SQLiteVirtualTableCursor cursor, ref long rowId)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379216));
	}

	public override SQLiteErrorCode Update(SQLiteVirtualTable table, SQLiteValue[] values, ref long rowId)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379207));
	}

	public override SQLiteErrorCode Begin(SQLiteVirtualTable table)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379166));
	}

	public override SQLiteErrorCode Sync(SQLiteVirtualTable table)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379189));
	}

	public override SQLiteErrorCode Commit(SQLiteVirtualTable table)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379180));
	}

	public override SQLiteErrorCode Rollback(SQLiteVirtualTable table)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379139));
	}

	public override bool FindFunction(SQLiteVirtualTable table, int argumentCount, string name, ref SQLiteFunction function, ref IntPtr pClientData)
	{
		CheckDisposed();
		return ResultCodeToFindFunctionResult(GetMethodResultCode(_001C(107379158)));
	}

	public override SQLiteErrorCode Rename(SQLiteVirtualTable table, string newName)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379109));
	}

	public override SQLiteErrorCode Savepoint(SQLiteVirtualTable table, int savepoint)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379100));
	}

	public override SQLiteErrorCode Release(SQLiteVirtualTable table, int savepoint)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379119));
	}

	public override SQLiteErrorCode RollbackTo(SQLiteVirtualTable table, int savepoint)
	{
		CheckDisposed();
		return GetMethodResultCode(_001C(107379074));
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteModuleNoop).Name);
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

	static SQLiteModuleNoop()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteModuleNoop));
	}
}
