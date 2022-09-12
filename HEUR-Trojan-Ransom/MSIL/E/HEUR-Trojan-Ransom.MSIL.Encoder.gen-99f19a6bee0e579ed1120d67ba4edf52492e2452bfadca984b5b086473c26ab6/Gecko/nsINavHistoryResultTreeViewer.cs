using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f8b518c0-1faf-11df-8a39-0800200c9a66")]
public interface nsINavHistoryResultTreeViewer : nsINavHistoryResultObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeInserted([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aParent, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, uint aNewIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeRemoved([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aParent, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aItem, uint aOldIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeMoved([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aOldParent, uint aOldIndex, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aNewParent, uint aNewIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeTitleChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeURIChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeIconChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeHistoryDetailsChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, long aNewVisitDate, uint aNewAccessCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeTagsChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeKeywordChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewKeyword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeAnnotationChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAnnoName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeDateAddedChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, long aNewValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NodeLastModifiedChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode, long aNewValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ContainerStateChanged([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aContainerNode, uint aOldState, uint aNewState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InvalidateContainer([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode aContainerNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SortingChanged(ushort sortingMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Batching([MarshalAs(UnmanagedType.U1)] bool aToggleMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsINavHistoryResult GetResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetResultAttribute([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResult aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryResultNode NodeForTreeIndex(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TreeIndexForNode([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultNode aNode);
}
