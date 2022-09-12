using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8bfd34d5-4ddf-4e4b-89dd-9b14f33534c6")]
public interface mozIStorageAsyncConnection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncClose(mozIStorageCompletionCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncClone([MarshalAs(UnmanagedType.U1)] bool aReadOnly, mozIStorageCompletionCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetDatabaseFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageAsyncStatement CreateAsyncStatement([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSQLStatement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStoragePendingStatement ExecuteAsync([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] mozIStorageBaseStatement[] aStatements, uint aNumStatements, mozIStorageStatementCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStoragePendingStatement ExecuteSimpleSQLAsync([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSQLStatement, mozIStorageStatementCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName, int aNumArguments, mozIStorageFunction aFunction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateAggregateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName, int aNumArguments, mozIStorageAggregateFunction aFunction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageProgressHandler SetProgressHandler(int aGranularity, mozIStorageProgressHandler aHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageProgressHandler RemoveProgressHandler();
}
