using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("31da1ce2-aec4-4c26-ac66-d622935c3bf4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBrowserDOMWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow OpenURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aOpener, short aWhere, short aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr OpenURIInFrame([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIOpenURIInFrameParams @params, short aWhere, short aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsTabContentWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanClose();
}
