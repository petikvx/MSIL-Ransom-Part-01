using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("366ee63e-a413-477d-9ad6-8d6863e89401")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsPIPlacesDatabase
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection GetDBConnectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStoragePendingStatement AsyncExecuteLegacyQueries([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsINavHistoryQuery[] aQueries, uint aQueryCount, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryQueryOptions aOptions, mozIStorageStatementCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAsyncShutdownClient GetShutdownClientAttribute();
}
