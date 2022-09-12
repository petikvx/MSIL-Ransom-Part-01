using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2487F9CA-D05F-4BD1-8F43-5964E746C482")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFocusManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetActiveWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetActiveWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aActiveWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetFocusedWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusedWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aFocusedWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFocusedElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLastFocusMethod([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement MoveFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aStartElement, uint aType, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFocusedElementForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.U1)] bool aDeep, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMWindow aFocusedWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveCaretToFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ElementIsFocusable([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WindowRaised([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WindowLowered([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WindowShown([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.U1)] bool aNeedsFocus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WindowHidden([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireDelayedEvents(IntPtr aDocument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FocusPlugin(IntPtr aPlugin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParentActivated([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.U1)] bool active);
}
