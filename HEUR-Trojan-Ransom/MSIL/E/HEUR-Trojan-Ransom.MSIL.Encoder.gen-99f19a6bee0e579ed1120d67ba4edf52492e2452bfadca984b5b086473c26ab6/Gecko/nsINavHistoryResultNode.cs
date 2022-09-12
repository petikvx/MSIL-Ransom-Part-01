using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("91d104bb-17ef-404b-9f9a-d9ed8de6824c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINavHistoryResultNode
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryContainerResultNode GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryResult GetParentResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUriAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAccessCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIconAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aIcon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndentLevelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetBookmarkIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetItemIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetDateAddedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTagsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPageGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPageGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBookmarkGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aBookmarkGuid);
}
