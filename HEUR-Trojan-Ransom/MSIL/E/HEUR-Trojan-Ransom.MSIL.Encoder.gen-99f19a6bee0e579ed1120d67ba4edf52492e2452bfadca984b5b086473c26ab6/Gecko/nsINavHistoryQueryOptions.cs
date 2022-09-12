using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8198dfa7-8061-4766-95cb-fa86b3c00a47")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINavHistoryQueryOptions
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetSortingModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSortingModeAttribute(ushort aSortingMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSortingAnnotationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSortingAnnotation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSortingAnnotationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSortingAnnotation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetResultTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResultTypeAttribute(ushort aResultType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetExcludeItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExcludeItemsAttribute([MarshalAs(UnmanagedType.U1)] bool aExcludeItems);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetExcludeQueriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExcludeQueriesAttribute([MarshalAs(UnmanagedType.U1)] bool aExcludeQueries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetExcludeReadOnlyFoldersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExcludeReadOnlyFoldersAttribute([MarshalAs(UnmanagedType.U1)] bool aExcludeReadOnlyFolders);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetExpandQueriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExpandQueriesAttribute([MarshalAs(UnmanagedType.U1)] bool aExpandQueries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIncludeHiddenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIncludeHiddenAttribute([MarshalAs(UnmanagedType.U1)] bool aIncludeHidden);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMaxResultsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxResultsAttribute(uint aMaxResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetQueryTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetQueryTypeAttribute(ushort aQueryType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAsyncEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsyncEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aAsyncEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryQueryOptions Clone();
}
