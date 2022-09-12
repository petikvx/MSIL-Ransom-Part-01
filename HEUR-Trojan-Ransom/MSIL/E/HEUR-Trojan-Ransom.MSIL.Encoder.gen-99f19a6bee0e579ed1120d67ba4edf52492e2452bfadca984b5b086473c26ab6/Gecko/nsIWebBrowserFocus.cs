using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9c5d3c58-1dd1-11b2-a1c9-f3699284657a")]
public interface nsIWebBrowserFocus
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Activate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Deactivate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusAtFirstElement();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusAtLastElement();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetFocusedWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusedWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aFocusedWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFocusedElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusedElementAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aFocusedElement);
}
