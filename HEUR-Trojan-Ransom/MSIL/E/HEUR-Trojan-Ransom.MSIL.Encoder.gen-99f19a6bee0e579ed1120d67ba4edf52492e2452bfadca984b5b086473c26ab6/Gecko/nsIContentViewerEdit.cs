using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("35BE2D7E-F29B-48EC-BF7E-80A30A724DE3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentViewerEdit
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopySelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCopyableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyLinkLocation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyImage(int aCopyFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInImageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContents([MarshalAs(UnmanagedType.LPStr)] string aMimeType, [MarshalAs(UnmanagedType.U1)] bool aSelectionOnly, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanGetContentsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCommandNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
}
