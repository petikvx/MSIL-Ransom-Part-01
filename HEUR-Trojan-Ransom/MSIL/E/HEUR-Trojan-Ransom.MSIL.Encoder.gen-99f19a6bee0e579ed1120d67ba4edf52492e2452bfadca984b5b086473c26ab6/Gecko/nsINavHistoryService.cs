using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8a1f527e-c9d7-4a51-bf0c-d86f0379b701")]
public interface nsINavHistoryService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetDatabaseStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasHistoryEntriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPageTitle([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkPageAsFollowedBookmark([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkPageAsTyped([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkPageAsFollowedLink([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanAddURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryQuery GetNewQuery();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryQueryOptions GetNewQueryOptions();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryResult ExecuteQuery([MarshalAs(UnmanagedType.Interface)] nsINavHistoryQuery aQuery, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryQueryOptions options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryResult ExecuteQueries([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsINavHistoryQuery[] aQueries, uint aQueryCount, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryQueryOptions options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void QueryStringToQueries([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aQueryString, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref nsINavHistoryQuery[] aQueries, ref uint aResultCount, [MarshalAs(UnmanagedType.Interface)] ref nsINavHistoryQueryOptions options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void QueriesToQueryString([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsINavHistoryQuery[] aQueries, uint aQueryCount, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryQueryOptions options, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsINavHistoryObserver observer, [MarshalAs(UnmanagedType.U1)] bool ownsWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsINavHistoryObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetObservers(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsINavHistoryObserver[] observers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RunInBatchMode([MarshalAs(UnmanagedType.Interface)] nsINavHistoryBatchCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aClosure);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHistoryDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearEmbedVisits();
}
