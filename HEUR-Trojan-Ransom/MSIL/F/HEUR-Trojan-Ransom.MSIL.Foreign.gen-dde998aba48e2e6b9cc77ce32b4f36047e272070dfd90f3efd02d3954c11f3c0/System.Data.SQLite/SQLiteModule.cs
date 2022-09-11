using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public abstract class SQLiteModule : IDisposable, ISQLiteManagedModule
{
	private sealed class SQLiteNativeModule : IDisposable, ISQLiteNativeModule
	{
		private const bool DefaultLogErrors = true;

		private const bool DefaultLogExceptions = true;

		private const string ModuleNotAvailableErrorMessage = "native module implementation not available";

		private SQLiteModule module;

		private bool disposed;

		[NonSerialized]
		internal static GetString _0091;

		public SQLiteNativeModule(SQLiteModule module)
		{
			this.module = module;
		}

		private static SQLiteErrorCode ModuleNotAvailableTableError(IntPtr pVtab)
		{
			SetTableError(null, pVtab, logErrors: true, logExceptions: true, _0091(107378841));
			return SQLiteErrorCode.Error;
		}

		private static SQLiteErrorCode ModuleNotAvailableCursorError(IntPtr pCursor)
		{
			SetCursorError(null, pCursor, logErrors: true, logExceptions: true, _0091(107378841));
			return SQLiteErrorCode.Error;
		}

		public SQLiteErrorCode xCreate(IntPtr pDb, IntPtr pAux, int argc, IntPtr argv, ref IntPtr pVtab, ref IntPtr pError)
		{
			if (module == null)
			{
				pError = SQLiteString.Utf8IntPtrFromString(_0091(107378841));
				return SQLiteErrorCode.Error;
			}
			return module.xCreate(pDb, pAux, argc, argv, ref pVtab, ref pError);
		}

		public SQLiteErrorCode xConnect(IntPtr pDb, IntPtr pAux, int argc, IntPtr argv, ref IntPtr pVtab, ref IntPtr pError)
		{
			if (module == null)
			{
				pError = SQLiteString.Utf8IntPtrFromString(_0091(107378841));
				return SQLiteErrorCode.Error;
			}
			return module.xConnect(pDb, pAux, argc, argv, ref pVtab, ref pError);
		}

		public SQLiteErrorCode xBestIndex(IntPtr pVtab, IntPtr pIndex)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xBestIndex(pVtab, pIndex);
		}

		public SQLiteErrorCode xDisconnect(IntPtr pVtab)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xDisconnect(pVtab);
		}

		public SQLiteErrorCode xDestroy(IntPtr pVtab)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xDestroy(pVtab);
		}

		public SQLiteErrorCode xOpen(IntPtr pVtab, ref IntPtr pCursor)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xOpen(pVtab, ref pCursor);
		}

		public SQLiteErrorCode xClose(IntPtr pCursor)
		{
			if (module == null)
			{
				return ModuleNotAvailableCursorError(pCursor);
			}
			return module.xClose(pCursor);
		}

		public SQLiteErrorCode xFilter(IntPtr pCursor, int idxNum, IntPtr idxStr, int argc, IntPtr argv)
		{
			if (module == null)
			{
				return ModuleNotAvailableCursorError(pCursor);
			}
			return module.xFilter(pCursor, idxNum, idxStr, argc, argv);
		}

		public SQLiteErrorCode xNext(IntPtr pCursor)
		{
			if (module == null)
			{
				return ModuleNotAvailableCursorError(pCursor);
			}
			return module.xNext(pCursor);
		}

		public int xEof(IntPtr pCursor)
		{
			if (module == null)
			{
				ModuleNotAvailableCursorError(pCursor);
				return 1;
			}
			return module.xEof(pCursor);
		}

		public SQLiteErrorCode xColumn(IntPtr pCursor, IntPtr pContext, int index)
		{
			if (module == null)
			{
				return ModuleNotAvailableCursorError(pCursor);
			}
			return module.xColumn(pCursor, pContext, index);
		}

		public SQLiteErrorCode xRowId(IntPtr pCursor, ref long rowId)
		{
			if (module == null)
			{
				return ModuleNotAvailableCursorError(pCursor);
			}
			return module.xRowId(pCursor, ref rowId);
		}

		public SQLiteErrorCode xUpdate(IntPtr pVtab, int argc, IntPtr argv, ref long rowId)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xUpdate(pVtab, argc, argv, ref rowId);
		}

		public SQLiteErrorCode xBegin(IntPtr pVtab)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xBegin(pVtab);
		}

		public SQLiteErrorCode xSync(IntPtr pVtab)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xSync(pVtab);
		}

		public SQLiteErrorCode xCommit(IntPtr pVtab)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xCommit(pVtab);
		}

		public SQLiteErrorCode xRollback(IntPtr pVtab)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xRollback(pVtab);
		}

		public int xFindFunction(IntPtr pVtab, int nArg, IntPtr zName, ref SQLiteCallback callback, ref IntPtr pClientData)
		{
			if (module == null)
			{
				ModuleNotAvailableTableError(pVtab);
				return 0;
			}
			return module.xFindFunction(pVtab, nArg, zName, ref callback, ref pClientData);
		}

		public SQLiteErrorCode xRename(IntPtr pVtab, IntPtr zNew)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xRename(pVtab, zNew);
		}

		public SQLiteErrorCode xSavepoint(IntPtr pVtab, int iSavepoint)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xSavepoint(pVtab, iSavepoint);
		}

		public SQLiteErrorCode xRelease(IntPtr pVtab, int iSavepoint)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xRelease(pVtab, iSavepoint);
		}

		public SQLiteErrorCode xRollbackTo(IntPtr pVtab, int iSavepoint)
		{
			if (module == null)
			{
				return ModuleNotAvailableTableError(pVtab);
			}
			return module.xRollbackTo(pVtab, iSavepoint);
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
				throw new ObjectDisposedException(typeof(SQLiteNativeModule).Name);
			}
		}

		private void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (module != null)
				{
					module = null;
				}
				disposed = true;
			}
		}

		~SQLiteNativeModule()
		{
			Dispose(disposing: false);
		}

		static SQLiteNativeModule()
		{
			Strings.CreateGetStringDelegate(typeof(SQLiteNativeModule));
			bool flag = false;
			Assembly assembly = global::_0005._001B();
			Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0091(107401413), _0091(107401376)), _0091(107401371), _0091(107401366)));
			if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0091(107401393)))
			{
				return;
			}
			throw new SecurityException(_0091(107401336));
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
	}

	private static readonly int DefaultModuleVersion;

	private UnsafeNativeMethods.sqlite3_module nativeModule;

	private UnsafeNativeMethods.xDestroyModule destroyModule;

	private IntPtr disposableModule;

	private Dictionary<IntPtr, SQLiteVirtualTable> tables;

	private Dictionary<IntPtr, SQLiteVirtualTableCursor> cursors;

	private Dictionary<string, SQLiteFunction> functions;

	private bool logErrors;

	private bool logExceptions;

	private bool declared;

	private string name;

	private bool disposed;

	[NonSerialized]
	internal static GetString _009D;

	protected virtual bool LogErrorsNoThrow
	{
		get
		{
			return logErrors;
		}
		set
		{
			logErrors = value;
		}
	}

	protected virtual bool LogExceptionsNoThrow
	{
		get
		{
			return logExceptions;
		}
		set
		{
			logExceptions = value;
		}
	}

	public virtual bool LogErrors
	{
		get
		{
			CheckDisposed();
			return LogErrorsNoThrow;
		}
		set
		{
			CheckDisposed();
			LogErrorsNoThrow = value;
		}
	}

	public virtual bool LogExceptions
	{
		get
		{
			CheckDisposed();
			return LogExceptionsNoThrow;
		}
		set
		{
			CheckDisposed();
			LogExceptionsNoThrow = value;
		}
	}

	public virtual bool Declared
	{
		get
		{
			CheckDisposed();
			return declared;
		}
		internal set
		{
			declared = value;
		}
	}

	public virtual string Name
	{
		get
		{
			CheckDisposed();
			return name;
		}
	}

	public SQLiteModule(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException(_009D(107379482));
		}
		this.name = name;
		tables = new Dictionary<IntPtr, SQLiteVirtualTable>();
		cursors = new Dictionary<IntPtr, SQLiteVirtualTableCursor>();
		functions = new Dictionary<string, SQLiteFunction>();
	}

	internal bool CreateDisposableModule(IntPtr pDb)
	{
		if (disposableModule != IntPtr.Zero)
		{
			return true;
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = SQLiteString.Utf8IntPtrFromString(name);
			UnsafeNativeMethods.sqlite3_module module = AllocateNativeModule();
			destroyModule = xDestroyModule;
			disposableModule = UnsafeNativeMethods.sqlite3_create_disposable_module(pDb, intPtr, ref module, IntPtr.Zero, destroyModule);
			return disposableModule != IntPtr.Zero;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	private void xDestroyModule(IntPtr pClientData)
	{
		disposableModule = IntPtr.Zero;
	}

	private UnsafeNativeMethods.sqlite3_module AllocateNativeModule()
	{
		return AllocateNativeModule(GetNativeModuleImpl());
	}

	private UnsafeNativeMethods.sqlite3_module AllocateNativeModule(ISQLiteNativeModule module)
	{
		nativeModule = default(UnsafeNativeMethods.sqlite3_module);
		nativeModule.iVersion = DefaultModuleVersion;
		if (module != null)
		{
			nativeModule.xCreate = module.xCreate;
			nativeModule.xConnect = module.xConnect;
			nativeModule.xBestIndex = module.xBestIndex;
			nativeModule.xDisconnect = module.xDisconnect;
			nativeModule.xDestroy = module.xDestroy;
			nativeModule.xOpen = module.xOpen;
			nativeModule.xClose = module.xClose;
			nativeModule.xFilter = module.xFilter;
			nativeModule.xNext = module.xNext;
			nativeModule.xEof = module.xEof;
			nativeModule.xColumn = module.xColumn;
			nativeModule.xRowId = module.xRowId;
			nativeModule.xUpdate = module.xUpdate;
			nativeModule.xBegin = module.xBegin;
			nativeModule.xSync = module.xSync;
			nativeModule.xCommit = module.xCommit;
			nativeModule.xRollback = module.xRollback;
			nativeModule.xFindFunction = module.xFindFunction;
			nativeModule.xRename = module.xRename;
			nativeModule.xSavepoint = module.xSavepoint;
			nativeModule.xRelease = module.xRelease;
			nativeModule.xRollbackTo = module.xRollbackTo;
		}
		else
		{
			nativeModule.xCreate = xCreate;
			nativeModule.xConnect = xConnect;
			nativeModule.xBestIndex = xBestIndex;
			nativeModule.xDisconnect = xDisconnect;
			nativeModule.xDestroy = xDestroy;
			nativeModule.xOpen = xOpen;
			nativeModule.xClose = xClose;
			nativeModule.xFilter = xFilter;
			nativeModule.xNext = xNext;
			nativeModule.xEof = xEof;
			nativeModule.xColumn = xColumn;
			nativeModule.xRowId = xRowId;
			nativeModule.xUpdate = xUpdate;
			nativeModule.xBegin = xBegin;
			nativeModule.xSync = xSync;
			nativeModule.xCommit = xCommit;
			nativeModule.xRollback = xRollback;
			nativeModule.xFindFunction = xFindFunction;
			nativeModule.xRename = xRename;
			nativeModule.xSavepoint = xSavepoint;
			nativeModule.xRelease = xRelease;
			nativeModule.xRollbackTo = xRollbackTo;
		}
		return nativeModule;
	}

	private UnsafeNativeMethods.sqlite3_module CopyNativeModule(UnsafeNativeMethods.sqlite3_module module)
	{
		UnsafeNativeMethods.sqlite3_module result = default(UnsafeNativeMethods.sqlite3_module);
		result.iVersion = module.iVersion;
		result.xCreate = ((module.xCreate != null) ? module.xCreate : new UnsafeNativeMethods.xCreate(xCreate)).Invoke;
		result.xConnect = ((module.xConnect != null) ? module.xConnect : new UnsafeNativeMethods.xConnect(xConnect)).Invoke;
		result.xBestIndex = ((module.xBestIndex != null) ? module.xBestIndex : new UnsafeNativeMethods.xBestIndex(xBestIndex)).Invoke;
		result.xDisconnect = ((module.xDisconnect != null) ? module.xDisconnect : new UnsafeNativeMethods.xDisconnect(xDisconnect)).Invoke;
		result.xDestroy = ((module.xDestroy != null) ? module.xDestroy : new UnsafeNativeMethods.xDestroy(xDestroy)).Invoke;
		result.xOpen = ((module.xOpen != null) ? module.xOpen : new UnsafeNativeMethods.xOpen(xOpen)).Invoke;
		result.xClose = ((module.xClose != null) ? module.xClose : new UnsafeNativeMethods.xClose(xClose)).Invoke;
		result.xFilter = ((module.xFilter != null) ? module.xFilter : new UnsafeNativeMethods.xFilter(xFilter)).Invoke;
		result.xNext = ((module.xNext != null) ? module.xNext : new UnsafeNativeMethods.xNext(xNext)).Invoke;
		result.xEof = ((module.xEof != null) ? module.xEof : new UnsafeNativeMethods.xEof(xEof)).Invoke;
		result.xColumn = ((module.xColumn != null) ? module.xColumn : new UnsafeNativeMethods.xColumn(xColumn)).Invoke;
		result.xRowId = ((module.xRowId != null) ? module.xRowId : new UnsafeNativeMethods.xRowId(xRowId)).Invoke;
		result.xUpdate = ((module.xUpdate != null) ? module.xUpdate : new UnsafeNativeMethods.xUpdate(xUpdate)).Invoke;
		result.xBegin = ((module.xBegin != null) ? module.xBegin : new UnsafeNativeMethods.xBegin(xBegin)).Invoke;
		result.xSync = ((module.xSync != null) ? module.xSync : new UnsafeNativeMethods.xSync(xSync)).Invoke;
		result.xCommit = ((module.xCommit != null) ? module.xCommit : new UnsafeNativeMethods.xCommit(xCommit)).Invoke;
		result.xRollback = ((module.xRollback != null) ? module.xRollback : new UnsafeNativeMethods.xRollback(xRollback)).Invoke;
		result.xFindFunction = ((module.xFindFunction != null) ? module.xFindFunction : new UnsafeNativeMethods.xFindFunction(xFindFunction)).Invoke;
		result.xRename = ((module.xRename != null) ? module.xRename : new UnsafeNativeMethods.xRename(xRename)).Invoke;
		result.xSavepoint = ((module.xSavepoint != null) ? module.xSavepoint : new UnsafeNativeMethods.xSavepoint(xSavepoint)).Invoke;
		result.xRelease = ((module.xRelease != null) ? module.xRelease : new UnsafeNativeMethods.xRelease(xRelease)).Invoke;
		result.xRollbackTo = ((module.xRollbackTo != null) ? module.xRollbackTo : new UnsafeNativeMethods.xRollbackTo(xRollbackTo)).Invoke;
		return result;
	}

	private SQLiteErrorCode CreateOrConnect(bool create, IntPtr pDb, IntPtr pAux, int argc, IntPtr argv, ref IntPtr pVtab, ref IntPtr pError)
	{
		try
		{
			string fileName = SQLiteString.StringFromUtf8IntPtr(UnsafeNativeMethods.sqlite3_db_filename(pDb, IntPtr.Zero));
			using SQLiteConnection connection = new SQLiteConnection(pDb, fileName, ownHandle: false);
			SQLiteVirtualTable table = null;
			string error = null;
			if ((create && Create(connection, pAux, SQLiteString.StringArrayFromUtf8SizeAndIntPtr(argc, argv), ref table, ref error) == SQLiteErrorCode.Ok) || (!create && Connect(connection, pAux, SQLiteString.StringArrayFromUtf8SizeAndIntPtr(argc, argv), ref table, ref error) == SQLiteErrorCode.Ok))
			{
				if (table != null)
				{
					pVtab = TableToIntPtr(table);
					return SQLiteErrorCode.Ok;
				}
				pError = SQLiteString.Utf8IntPtrFromString(_009D(107379473));
			}
			else
			{
				pError = SQLiteString.Utf8IntPtrFromString(error);
			}
		}
		catch (Exception ex)
		{
			pError = SQLiteString.Utf8IntPtrFromString(ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode DestroyOrDisconnect(bool destroy, IntPtr pVtab)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null && ((destroy && Destroy(sQLiteVirtualTable) == SQLiteErrorCode.Ok) || (!destroy && Disconnect(sQLiteVirtualTable) == SQLiteErrorCode.Ok)))
			{
				if (tables != null)
				{
					tables.Remove(pVtab);
				}
				return SQLiteErrorCode.Ok;
			}
		}
		catch (Exception ex)
		{
			try
			{
				if (LogExceptionsNoThrow)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _009D(107379444), destroy ? _009D(107379374) : _009D(107379423), ex));
				}
			}
			catch
			{
			}
		}
		finally
		{
			FreeTable(pVtab);
		}
		return SQLiteErrorCode.Error;
	}

	private static bool SetTableError(SQLiteModule module, IntPtr pVtab, bool logErrors, bool logExceptions, string error)
	{
		try
		{
			if (logErrors)
			{
				SQLiteLog.LogMessage(SQLiteErrorCode.Error, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _009D(107379393), error));
			}
		}
		catch
		{
		}
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			if (pVtab == IntPtr.Zero)
			{
				return false;
			}
			int offset = 0;
			offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
			IntPtr intPtr2 = SQLiteMarshal.ReadIntPtr(pVtab, offset);
			if (intPtr2 != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr2);
				intPtr2 = IntPtr.Zero;
				SQLiteMarshal.WriteIntPtr(pVtab, offset, intPtr2);
			}
			if (error == null)
			{
				return true;
			}
			intPtr = SQLiteString.Utf8IntPtrFromString(error);
			SQLiteMarshal.WriteIntPtr(pVtab, offset, intPtr);
			flag = true;
		}
		catch (Exception ex)
		{
			try
			{
				if (logExceptions)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _009D(107379360), ex));
				}
			}
			catch
			{
			}
		}
		finally
		{
			if (!flag && intPtr != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
		return flag;
	}

	private static bool SetTableError(SQLiteModule module, SQLiteVirtualTable table, bool logErrors, bool logExceptions, string error)
	{
		if (table == null)
		{
			return false;
		}
		IntPtr nativeHandle = table.NativeHandle;
		if (nativeHandle == IntPtr.Zero)
		{
			return false;
		}
		return SetTableError(module, nativeHandle, logErrors, logExceptions, error);
	}

	private static bool SetCursorError(SQLiteModule module, IntPtr pCursor, bool logErrors, bool logExceptions, string error)
	{
		if (pCursor == IntPtr.Zero)
		{
			return false;
		}
		IntPtr intPtr = TableFromCursor(module, pCursor);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		return SetTableError(module, intPtr, logErrors, logExceptions, error);
	}

	private static bool SetCursorError(SQLiteModule module, SQLiteVirtualTableCursor cursor, bool logErrors, bool logExceptions, string error)
	{
		if (cursor == null)
		{
			return false;
		}
		IntPtr nativeHandle = cursor.NativeHandle;
		if (nativeHandle == IntPtr.Zero)
		{
			return false;
		}
		return SetCursorError(module, nativeHandle, logErrors, logExceptions, error);
	}

	protected virtual ISQLiteNativeModule GetNativeModuleImpl()
	{
		return null;
	}

	protected virtual ISQLiteNativeModule CreateNativeModuleImpl()
	{
		return new SQLiteNativeModule(this);
	}

	protected virtual IntPtr AllocateTable()
	{
		int size = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_vtab));
		return SQLiteMemory.Allocate(size);
	}

	protected virtual void ZeroTable(IntPtr pVtab)
	{
		if (!(pVtab == IntPtr.Zero))
		{
			int offset = 0;
			SQLiteMarshal.WriteIntPtr(pVtab, offset, IntPtr.Zero);
			offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
			SQLiteMarshal.WriteInt32(pVtab, offset, 0);
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
			SQLiteMarshal.WriteIntPtr(pVtab, offset, IntPtr.Zero);
		}
	}

	protected virtual void FreeTable(IntPtr pVtab)
	{
		SetTableError(pVtab, null);
		SQLiteMemory.Free(pVtab);
	}

	protected virtual IntPtr AllocateCursor()
	{
		int size = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_vtab_cursor));
		return SQLiteMemory.Allocate(size);
	}

	protected virtual void FreeCursor(IntPtr pCursor)
	{
		SQLiteMemory.Free(pCursor);
	}

	private static IntPtr TableFromCursor(SQLiteModule module, IntPtr pCursor)
	{
		if (pCursor == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		return Marshal.ReadIntPtr(pCursor);
	}

	protected virtual IntPtr TableFromCursor(IntPtr pCursor)
	{
		return TableFromCursor(this, pCursor);
	}

	protected virtual SQLiteVirtualTable TableFromIntPtr(IntPtr pVtab)
	{
		if (pVtab == IntPtr.Zero)
		{
			SetTableError(pVtab, _009D(107379295));
			return null;
		}
		if (tables != null && tables.TryGetValue(pVtab, out var value))
		{
			return value;
		}
		SetTableError(pVtab, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _009D(107379778), pVtab));
		return null;
	}

	protected virtual IntPtr TableToIntPtr(SQLiteVirtualTable table)
	{
		if (table == null || tables == null)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		try
		{
			intPtr = AllocateTable();
			if (intPtr != IntPtr.Zero)
			{
				ZeroTable(intPtr);
				table.NativeHandle = intPtr;
				tables.Add(intPtr, table);
				flag = true;
			}
		}
		finally
		{
			if (!flag && intPtr != IntPtr.Zero)
			{
				FreeTable(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
		return intPtr;
	}

	protected virtual SQLiteVirtualTableCursor CursorFromIntPtr(IntPtr pVtab, IntPtr pCursor)
	{
		if (pCursor == IntPtr.Zero)
		{
			SetTableError(pVtab, _009D(107379701));
			return null;
		}
		if (cursors != null && cursors.TryGetValue(pCursor, out var value))
		{
			return value;
		}
		SetTableError(pVtab, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _009D(107379672), pCursor));
		return null;
	}

	protected virtual IntPtr CursorToIntPtr(SQLiteVirtualTableCursor cursor)
	{
		if (cursor == null || cursors == null)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		try
		{
			intPtr = AllocateCursor();
			if (intPtr != IntPtr.Zero)
			{
				cursor.NativeHandle = intPtr;
				cursors.Add(intPtr, cursor);
				flag = true;
			}
		}
		finally
		{
			if (!flag && intPtr != IntPtr.Zero)
			{
				FreeCursor(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
		return intPtr;
	}

	protected virtual string GetFunctionKey(int argumentCount, string name, SQLiteFunction function)
	{
		return HelperMethods.StringFormat(CultureInfo.InvariantCulture, _009D(107379659), argumentCount, name);
	}

	protected virtual SQLiteErrorCode DeclareTable(SQLiteConnection connection, string sql, ref string error)
	{
		if (connection == null)
		{
			error = _009D(107379646);
			return SQLiteErrorCode.Error;
		}
		SQLiteBase sql2 = connection._sql;
		if (sql2 == null)
		{
			error = _009D(107379621);
			return SQLiteErrorCode.Error;
		}
		if (sql == null)
		{
			error = _009D(107379548);
			return SQLiteErrorCode.Error;
		}
		return sql2.DeclareVirtualTable(this, sql, ref error);
	}

	protected virtual SQLiteErrorCode DeclareFunction(SQLiteConnection connection, int argumentCount, string name, ref string error)
	{
		if (connection == null)
		{
			error = _009D(107379646);
			return SQLiteErrorCode.Error;
		}
		SQLiteBase sql = connection._sql;
		if (sql == null)
		{
			error = _009D(107379621);
			return SQLiteErrorCode.Error;
		}
		return sql.DeclareVirtualFunction(this, argumentCount, name, ref error);
	}

	protected virtual bool SetTableError(IntPtr pVtab, string error)
	{
		return SetTableError(this, pVtab, LogErrorsNoThrow, LogExceptionsNoThrow, error);
	}

	protected virtual bool SetTableError(SQLiteVirtualTable table, string error)
	{
		return SetTableError(this, table, LogErrorsNoThrow, LogExceptionsNoThrow, error);
	}

	protected virtual bool SetCursorError(SQLiteVirtualTableCursor cursor, string error)
	{
		return SetCursorError(this, cursor, LogErrorsNoThrow, LogExceptionsNoThrow, error);
	}

	protected virtual bool SetEstimatedCost(SQLiteIndex index, double? estimatedCost)
	{
		if (index == null || index.Outputs == null)
		{
			return false;
		}
		index.Outputs.EstimatedCost = estimatedCost;
		return true;
	}

	protected virtual bool SetEstimatedCost(SQLiteIndex index)
	{
		return SetEstimatedCost(index, null);
	}

	protected virtual bool SetEstimatedRows(SQLiteIndex index, long? estimatedRows)
	{
		if (index == null || index.Outputs == null)
		{
			return false;
		}
		index.Outputs.EstimatedRows = estimatedRows;
		return true;
	}

	protected virtual bool SetEstimatedRows(SQLiteIndex index)
	{
		return SetEstimatedRows(index, null);
	}

	protected virtual bool SetIndexFlags(SQLiteIndex index, SQLiteIndexFlags? indexFlags)
	{
		if (index == null || index.Outputs == null)
		{
			return false;
		}
		index.Outputs.IndexFlags = indexFlags;
		return true;
	}

	protected virtual bool SetIndexFlags(SQLiteIndex index)
	{
		return SetIndexFlags(index, null);
	}

	private SQLiteErrorCode xCreate(IntPtr pDb, IntPtr pAux, int argc, IntPtr argv, ref IntPtr pVtab, ref IntPtr pError)
	{
		return CreateOrConnect(create: true, pDb, pAux, argc, argv, ref pVtab, ref pError);
	}

	private SQLiteErrorCode xConnect(IntPtr pDb, IntPtr pAux, int argc, IntPtr argv, ref IntPtr pVtab, ref IntPtr pError)
	{
		return CreateOrConnect(create: false, pDb, pAux, argc, argv, ref pVtab, ref pError);
	}

	private SQLiteErrorCode xBestIndex(IntPtr pVtab, IntPtr pIndex)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				SQLiteIndex index = null;
				SQLiteIndex.FromIntPtr(pIndex, includeOutput: true, ref index);
				if (BestIndex(sQLiteVirtualTable, index) == SQLiteErrorCode.Ok)
				{
					SQLiteIndex.ToIntPtr(index, pIndex, includeInput: true);
					return SQLiteErrorCode.Ok;
				}
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xDisconnect(IntPtr pVtab)
	{
		return DestroyOrDisconnect(destroy: false, pVtab);
	}

	private SQLiteErrorCode xDestroy(IntPtr pVtab)
	{
		return DestroyOrDisconnect(destroy: true, pVtab);
	}

	private SQLiteErrorCode xOpen(IntPtr pVtab, ref IntPtr pCursor)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				SQLiteVirtualTableCursor cursor = null;
				if (Open(sQLiteVirtualTable, ref cursor) == SQLiteErrorCode.Ok)
				{
					if (cursor != null)
					{
						pCursor = CursorToIntPtr(cursor);
						if (pCursor != IntPtr.Zero)
						{
							return SQLiteErrorCode.Ok;
						}
						SetTableError(pVtab, _009D(107379551));
					}
					else
					{
						SetTableError(pVtab, _009D(107378966));
					}
				}
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xClose(IntPtr pCursor)
	{
		IntPtr pVtab = IntPtr.Zero;
		try
		{
			pVtab = TableFromCursor(pCursor);
			SQLiteVirtualTableCursor sQLiteVirtualTableCursor = CursorFromIntPtr(pVtab, pCursor);
			if (sQLiteVirtualTableCursor != null && Close(sQLiteVirtualTableCursor) == SQLiteErrorCode.Ok)
			{
				if (cursors != null)
				{
					cursors.Remove(pCursor);
				}
				return SQLiteErrorCode.Ok;
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		finally
		{
			FreeCursor(pCursor);
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xFilter(IntPtr pCursor, int idxNum, IntPtr idxStr, int argc, IntPtr argv)
	{
		IntPtr pVtab = IntPtr.Zero;
		try
		{
			pVtab = TableFromCursor(pCursor);
			SQLiteVirtualTableCursor sQLiteVirtualTableCursor = CursorFromIntPtr(pVtab, pCursor);
			if (sQLiteVirtualTableCursor != null && Filter(sQLiteVirtualTableCursor, idxNum, SQLiteString.StringFromUtf8IntPtr(idxStr), SQLiteValue.ArrayFromSizeAndIntPtr(argc, argv)) == SQLiteErrorCode.Ok)
			{
				return SQLiteErrorCode.Ok;
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xNext(IntPtr pCursor)
	{
		IntPtr pVtab = IntPtr.Zero;
		try
		{
			pVtab = TableFromCursor(pCursor);
			SQLiteVirtualTableCursor sQLiteVirtualTableCursor = CursorFromIntPtr(pVtab, pCursor);
			if (sQLiteVirtualTableCursor != null && Next(sQLiteVirtualTableCursor) == SQLiteErrorCode.Ok)
			{
				return SQLiteErrorCode.Ok;
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private int xEof(IntPtr pCursor)
	{
		IntPtr pVtab = IntPtr.Zero;
		try
		{
			pVtab = TableFromCursor(pCursor);
			SQLiteVirtualTableCursor sQLiteVirtualTableCursor = CursorFromIntPtr(pVtab, pCursor);
			if (sQLiteVirtualTableCursor != null)
			{
				return Eof(sQLiteVirtualTableCursor) ? 1 : 0;
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return 1;
	}

	private SQLiteErrorCode xColumn(IntPtr pCursor, IntPtr pContext, int index)
	{
		IntPtr pVtab = IntPtr.Zero;
		try
		{
			pVtab = TableFromCursor(pCursor);
			SQLiteVirtualTableCursor sQLiteVirtualTableCursor = CursorFromIntPtr(pVtab, pCursor);
			if (sQLiteVirtualTableCursor != null)
			{
				SQLiteContext context = new SQLiteContext(pContext);
				return Column(sQLiteVirtualTableCursor, context, index);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xRowId(IntPtr pCursor, ref long rowId)
	{
		IntPtr pVtab = IntPtr.Zero;
		try
		{
			pVtab = TableFromCursor(pCursor);
			SQLiteVirtualTableCursor sQLiteVirtualTableCursor = CursorFromIntPtr(pVtab, pCursor);
			if (sQLiteVirtualTableCursor != null)
			{
				return RowId(sQLiteVirtualTableCursor, ref rowId);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xUpdate(IntPtr pVtab, int argc, IntPtr argv, ref long rowId)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Update(sQLiteVirtualTable, SQLiteValue.ArrayFromSizeAndIntPtr(argc, argv), ref rowId);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xBegin(IntPtr pVtab)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Begin(sQLiteVirtualTable);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xSync(IntPtr pVtab)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Sync(sQLiteVirtualTable);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xCommit(IntPtr pVtab)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Commit(sQLiteVirtualTable);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xRollback(IntPtr pVtab)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Rollback(sQLiteVirtualTable);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private int xFindFunction(IntPtr pVtab, int nArg, IntPtr zName, ref SQLiteCallback callback, ref IntPtr pClientData)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				string text = SQLiteString.StringFromUtf8IntPtr(zName);
				SQLiteFunction function = null;
				if (FindFunction(sQLiteVirtualTable, nArg, text, ref function, ref pClientData))
				{
					if (function != null)
					{
						string functionKey = GetFunctionKey(nArg, text, function);
						functions[functionKey] = function;
						callback = function.ScalarCallback;
						return 1;
					}
					SetTableError(pVtab, _009D(107378957));
				}
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return 0;
	}

	private SQLiteErrorCode xRename(IntPtr pVtab, IntPtr zNew)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Rename(sQLiteVirtualTable, SQLiteString.StringFromUtf8IntPtr(zNew));
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xSavepoint(IntPtr pVtab, int iSavepoint)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Savepoint(sQLiteVirtualTable, iSavepoint);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xRelease(IntPtr pVtab, int iSavepoint)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return Release(sQLiteVirtualTable, iSavepoint);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	private SQLiteErrorCode xRollbackTo(IntPtr pVtab, int iSavepoint)
	{
		try
		{
			SQLiteVirtualTable sQLiteVirtualTable = TableFromIntPtr(pVtab);
			if (sQLiteVirtualTable != null)
			{
				return RollbackTo(sQLiteVirtualTable, iSavepoint);
			}
		}
		catch (Exception ex)
		{
			SetTableError(pVtab, ex.ToString());
		}
		return SQLiteErrorCode.Error;
	}

	public abstract SQLiteErrorCode Create(SQLiteConnection connection, IntPtr pClientData, string[] arguments, ref SQLiteVirtualTable table, ref string error);

	public abstract SQLiteErrorCode Connect(SQLiteConnection connection, IntPtr pClientData, string[] arguments, ref SQLiteVirtualTable table, ref string error);

	public abstract SQLiteErrorCode BestIndex(SQLiteVirtualTable table, SQLiteIndex index);

	public abstract SQLiteErrorCode Disconnect(SQLiteVirtualTable table);

	public abstract SQLiteErrorCode Destroy(SQLiteVirtualTable table);

	public abstract SQLiteErrorCode Open(SQLiteVirtualTable table, ref SQLiteVirtualTableCursor cursor);

	public abstract SQLiteErrorCode Close(SQLiteVirtualTableCursor cursor);

	public abstract SQLiteErrorCode Filter(SQLiteVirtualTableCursor cursor, int indexNumber, string indexString, SQLiteValue[] values);

	public abstract SQLiteErrorCode Next(SQLiteVirtualTableCursor cursor);

	public abstract bool Eof(SQLiteVirtualTableCursor cursor);

	public abstract SQLiteErrorCode Column(SQLiteVirtualTableCursor cursor, SQLiteContext context, int index);

	public abstract SQLiteErrorCode RowId(SQLiteVirtualTableCursor cursor, ref long rowId);

	public abstract SQLiteErrorCode Update(SQLiteVirtualTable table, SQLiteValue[] values, ref long rowId);

	public abstract SQLiteErrorCode Begin(SQLiteVirtualTable table);

	public abstract SQLiteErrorCode Sync(SQLiteVirtualTable table);

	public abstract SQLiteErrorCode Commit(SQLiteVirtualTable table);

	public abstract SQLiteErrorCode Rollback(SQLiteVirtualTable table);

	public abstract bool FindFunction(SQLiteVirtualTable table, int argumentCount, string name, ref SQLiteFunction function, ref IntPtr pClientData);

	public abstract SQLiteErrorCode Rename(SQLiteVirtualTable table, string newName);

	public abstract SQLiteErrorCode Savepoint(SQLiteVirtualTable table, int savepoint);

	public abstract SQLiteErrorCode Release(SQLiteVirtualTable table, int savepoint);

	public abstract SQLiteErrorCode RollbackTo(SQLiteVirtualTable table, int savepoint);

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteModule).Name);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		if (disposing && functions != null)
		{
			functions.Clear();
		}
		try
		{
			if (disposableModule != IntPtr.Zero)
			{
				UnsafeNativeMethods.sqlite3_dispose_module(disposableModule);
				disposableModule = IntPtr.Zero;
			}
		}
		catch (Exception ex)
		{
			try
			{
				if (LogExceptionsNoThrow)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _009D(107378924), ex));
				}
			}
			catch
			{
			}
		}
		disposed = true;
	}

	~SQLiteModule()
	{
		Dispose(disposing: false);
	}

	static SQLiteModule()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteModule));
		DefaultModuleVersion = 2;
	}
}
