using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1beb70d3-70f3-4742-98cc-a3d301b26c0c")]
public interface nsIAndroidBridge
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleGeckoMessage(ref JsVal message, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAndroidBrowserApp GetBrowserAppAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBrowserAppAttribute([MarshalAs(UnmanagedType.Interface)] nsIAndroidBrowserApp aBrowserApp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAndroidDisplayport GetDisplayPort([MarshalAs(UnmanagedType.U1)] bool aPageSizeUpdate, [MarshalAs(UnmanagedType.U1)] bool isBrowserContentDisplayed, int tabId, [MarshalAs(UnmanagedType.Interface)] nsIAndroidViewport metrics);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ContentDocumentChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsContentDocumentDisplayed();
}
