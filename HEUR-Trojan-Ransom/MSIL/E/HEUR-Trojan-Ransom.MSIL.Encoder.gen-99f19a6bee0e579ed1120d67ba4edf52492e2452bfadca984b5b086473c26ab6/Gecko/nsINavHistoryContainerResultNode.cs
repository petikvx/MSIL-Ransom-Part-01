using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3E9CC95F-0D93-45F1-894F-908EEB9866D7")]
public interface nsINavHistoryContainerResultNode : nsINavHistoryResultNode
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
	bool GetContainerOpenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContainerOpenAttribute([MarshalAs(UnmanagedType.U1)] bool aContainerOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasChildrenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetChildCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryResultNode GetChild(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetChildIndex([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryResultNode FindNodeByDetails([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIString, long aTime, long aItemId, [MarshalAs(UnmanagedType.U1)] bool aRecursive);
}
