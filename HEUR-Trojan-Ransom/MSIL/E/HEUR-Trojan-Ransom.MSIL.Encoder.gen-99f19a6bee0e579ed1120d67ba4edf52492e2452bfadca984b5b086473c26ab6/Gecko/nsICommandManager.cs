using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("080D2001-F91E-11D4-A73C-F9242928207C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICommandManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCommandObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver aCommandObserver, [MarshalAs(UnmanagedType.LPStr)] string aCommandToObserve);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveCommandObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver aCommandObserver, [MarshalAs(UnmanagedType.LPStr)] string aCommandObserved);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandSupported([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aTargetWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aTargetWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommandState([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aTargetWindow, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aCommandParams);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aCommandParams, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aTargetWindow);
}
