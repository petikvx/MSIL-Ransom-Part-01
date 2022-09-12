using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e03e6c5e-0d84-4c0b-8739-e6b8d51922de")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIClipboardDragDropHooks
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AllowStartDrag([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent @event);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AllowDrop([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent @event, [MarshalAs(UnmanagedType.Interface)] nsIDragSession session);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnCopyOrDrag([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aEvent, [MarshalAs(UnmanagedType.Interface)] nsITransferable trans);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnPasteOrDrop([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent @event, [MarshalAs(UnmanagedType.Interface)] nsITransferable trans);
}
