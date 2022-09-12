using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e0a4d4b3-f34e-44bd-b1f2-4e3bde9b6915")]
public interface nsISelection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetAnchorNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAnchorOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetFocusNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFocusOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsCollapsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Collapsed();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRangeCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMRange GetRangeAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Collapse([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CollapseNative(IntPtr parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Extend([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExtendNative(IntPtr parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CollapseToStart();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CollapseToEnd();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ContainsNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node, [MarshalAs(UnmanagedType.U1)] bool partlyContained);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAllChildren([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAllRanges();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteFromDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Modify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase alter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase granularity);
}
