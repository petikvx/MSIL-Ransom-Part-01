using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f3c50361-14fe-11d3-bf87-00105a1b0627")]
public interface nsIDOMXULCommandDispatcher
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFocusedElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusedElementAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aFocusedElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetFocusedWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusedWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aFocusedWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCommandUpdater([MarshalAs(UnmanagedType.Interface)] nsIDOMElement updater, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase events, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase targets);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveCommandUpdater([MarshalAs(UnmanagedType.Interface)] nsIDOMElement updater);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateCommands([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase eventName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIController GetControllerForCommand([MarshalAs(UnmanagedType.LPStr)] string command);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIControllers GetControllers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AdvanceFocus();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RewindFocus();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AdvanceFocusIntoSubtree([MarshalAs(UnmanagedType.Interface)] nsIDOMElement elt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSuppressFocusScrollAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSuppressFocusScrollAttribute([MarshalAs(UnmanagedType.U1)] bool aSuppressFocusScroll);
}
