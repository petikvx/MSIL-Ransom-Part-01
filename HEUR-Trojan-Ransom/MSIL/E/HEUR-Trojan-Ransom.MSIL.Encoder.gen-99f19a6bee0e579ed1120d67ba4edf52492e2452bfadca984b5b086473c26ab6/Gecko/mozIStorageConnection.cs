using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4aa2ac47-8d24-4004-9b31-ec0bd85f0cc3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIStorageConnection : mozIStorageAsyncConnection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AsyncClose(mozIStorageCompletionCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AsyncClone([MarshalAs(UnmanagedType.U1)] bool aReadOnly, mozIStorageCompletionCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFile GetDatabaseFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new mozIStorageAsyncStatement CreateAsyncStatement([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSQLStatement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new mozIStoragePendingStatement ExecuteAsync([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] mozIStorageBaseStatement[] aStatements, uint aNumStatements, mozIStorageStatementCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new mozIStoragePendingStatement ExecuteSimpleSQLAsync([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSQLStatement, mozIStorageStatementCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CreateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName, int aNumArguments, mozIStorageFunction aFunction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CreateAggregateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName, int aNumArguments, mozIStorageAggregateFunction aFunction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new mozIStorageProgressHandler SetProgressHandler(int aGranularity, mozIStorageProgressHandler aHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new mozIStorageProgressHandler RemoveProgressHandler();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection Clone([MarshalAs(UnmanagedType.U1)] bool aReadOnly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetDefaultPageSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetConnectionReadyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastInsertRowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAffectedRowsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLastErrorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLastErrorStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aLastErrorString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSchemaVersionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSchemaVersionAttribute(int aSchemaVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageStatement CreateStatement([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSQLStatement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExecuteSimpleSQL([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSQLStatement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool TableExists([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTableName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IndexExists([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aIndexName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetTransactionInProgressAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginTransactionAs(int transactionType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CommitTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RollbackTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateTable([MarshalAs(UnmanagedType.LPStr)] string aTableName, [MarshalAs(UnmanagedType.LPStr)] string aTableSchema);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetGrowthIncrement(int aIncrement, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDatabaseName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableModule([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aModuleName);
}
