using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1f94055c-42e7-4a30-96a1-6a804f1c2d1e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMRange
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetStartContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStartOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetEndContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEndOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCollapsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetCommonAncestorContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStart([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnd([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStartBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStartAfter([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEndBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEndAfter([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Collapse([MarshalAs(UnmanagedType.U1)] bool toStart);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectNodeContents([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short CompareBoundaryPoints(ushort how, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange sourceRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteContents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocumentFragment ExtractContents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocumentFragment CloneContents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SurroundContents([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newParent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMRange CloneRange();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Detach();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocumentFragment CreateContextualFragment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase fragment);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsPointInRange([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short ComparePoint([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IntersectsNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMClientRectList GetClientRects();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMClientRect GetBoundingClientRect();
}
