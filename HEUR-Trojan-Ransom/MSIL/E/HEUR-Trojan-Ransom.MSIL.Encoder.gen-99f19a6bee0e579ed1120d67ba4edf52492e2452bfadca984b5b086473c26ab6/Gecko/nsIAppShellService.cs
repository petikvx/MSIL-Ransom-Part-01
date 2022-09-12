using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("83f23c7e-6ce0-433f-9fe2-f287ae8c6e0c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAppShellService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULWindow CreateTopLevelWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aParent, [MarshalAs(UnmanagedType.Interface)] nsIURI aUrl, uint aChromeMask, int aInitialWidth, int aInitialHeight, [MarshalAs(UnmanagedType.Interface)] nsITabParent aOpeningTab);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebNavigation CreateWindowlessBrowser([MarshalAs(UnmanagedType.U1)] bool aIsChrome);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateHiddenWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DestroyHiddenWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetScreenId(uint aScreenId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULWindow GetHiddenWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetHiddenDOMWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULWindow GetHiddenPrivateWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetHiddenPrivateDOMWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHiddenWindowAndJSContext([MarshalAs(UnmanagedType.Interface)] ref nsIDOMWindow aHiddenDOMWindow, ref IntPtr aJSContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetApplicationProvidedHiddenWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasHiddenPrivateWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool StartEventLoopLagTracking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopEventLoopLagTracking();
}
