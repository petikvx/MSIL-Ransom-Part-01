using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8b396020-69d3-451f-80c1-1a96a7da25a9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHTMLObjectResizer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetResizedObjectAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetObjectResizingEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetObjectResizingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aObjectResizingEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowResizers([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aResizedElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HideResizers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RefreshResizers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MouseDown(int aX, int aY, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTarget, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aMouseEvent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MouseUp(int aX, int aY, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MouseMove([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aMouseEvent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObjectResizeEventListener([MarshalAs(UnmanagedType.Interface)] nsIHTMLObjectResizeListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObjectResizeEventListener([MarshalAs(UnmanagedType.Interface)] nsIHTMLObjectResizeListener aListener);
}
