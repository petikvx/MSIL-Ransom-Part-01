using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("cff3efcc-e144-490d-9f23-8b6f6dd09e7f")]
public interface nsINavBookmarkObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnBeginUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnEndUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnItemAdded(long aItemId, long aParentId, int aIndex, ushort aItemType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle, long aDateAdded, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnItemRemoved(long aItemId, long aParentId, int aIndex, ushort aItemType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnItemChanged(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProperty, [MarshalAs(UnmanagedType.U1)] bool aIsAnnotationProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewValue, long aLastModified, ushort aItemType, long aParentId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aOldValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnItemVisited(long aItemId, long aVisitId, long aTime, uint aTransitionType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, long aParentId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnItemMoved(long aItemId, long aOldParentId, int aOldIndex, long aNewParentId, int aNewIndex, ushort aItemType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOldParentGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNewParentGuid);
}
