using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f62d8b6b-3c4e-4a9f-a897-db605d0b7a0f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINavHistoryResultObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeInserted([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aParent, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, uint aNewIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeRemoved([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aParent, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aItem, uint aOldIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeMoved([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aOldParent, uint aOldIndex, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aNewParent, uint aNewIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeTitleChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeURIChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeIconChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeHistoryDetailsChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, long aNewVisitDate, uint aNewAccessCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeTagsChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeKeywordChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewKeyword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeAnnotationChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAnnoName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeDateAddedChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, long aNewValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NodeLastModifiedChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, long aNewValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ContainerStateChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aContainerNode, uint aOldState, uint aNewState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateContainer([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aContainerNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SortingChanged(ushort sortingMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Batching([MarshalAs(UnmanagedType.U1)] bool aToggleMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryResult GetResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResultAttribute([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResult aResult);
}
