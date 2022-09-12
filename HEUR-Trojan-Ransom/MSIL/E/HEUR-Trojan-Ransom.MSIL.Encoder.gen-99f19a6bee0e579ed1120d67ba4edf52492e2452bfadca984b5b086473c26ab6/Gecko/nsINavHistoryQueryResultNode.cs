using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("62817759-4FEE-44A3-B58C-3E2F5AFC9D0A")]
public interface nsINavHistoryQueryResultNode : nsINavHistoryResultNode, nsINavHistoryContainerResultNode
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsINavHistoryContainerResultNode GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsINavHistoryResult GetParentResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetUriAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetAccessCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetIconAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aIcon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetIndentLevelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetBookmarkIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetItemIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetDateAddedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTagsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetPageGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPageGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetBookmarkGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aBookmarkGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetContainerOpenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContainerOpenAttribute([MarshalAs(UnmanagedType.U1)] bool aContainerOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetHasChildrenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetChildCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsINavHistoryResultNode GetChild(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetChildIndex([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsINavHistoryResultNode FindNodeByDetails([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIString, long aTime, long aItemId, [MarshalAs(UnmanagedType.U1)] bool aRecursive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetQueries(ref uint queryCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsINavHistoryQuery[] queries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryQueryOptions GetQueryOptionsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetFolderItemIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTargetFolderGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aTargetFolderGuid);
}
