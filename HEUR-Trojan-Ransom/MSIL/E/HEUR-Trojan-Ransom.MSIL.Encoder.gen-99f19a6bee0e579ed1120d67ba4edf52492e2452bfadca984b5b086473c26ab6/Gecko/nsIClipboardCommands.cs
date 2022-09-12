using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b8100c90-73be-11d2-92a5-00105a1b0d64")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIClipboardCommands
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanCutSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanCopySelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanCopyLinkLocation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanCopyImageLocation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanCopyImageContents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanPaste();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CutSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopySelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyLinkLocation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyImageLocation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyImageContents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Paste();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectNone();
}
