using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3232f40a-e94b-432d-9496-096abf1387bd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWinTaskbar
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAvailableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultGroupIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultGroupId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITaskbarTabPreview CreateTaskbarTabPreview([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell, [MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewController controller);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITaskbarWindowPreview GetTaskbarWindowPreview([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITaskbarProgress GetTaskbarProgress([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITaskbarOverlayIconController GetOverlayIconController([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIJumpListBuilder CreateJumpListBuilder();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetGroupIdForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIdentifier);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrepareFullScreen([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.U1)] bool aFullScreen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrepareFullScreenHWND(IntPtr aWindow, [MarshalAs(UnmanagedType.U1)] bool aFullScreen);
}
