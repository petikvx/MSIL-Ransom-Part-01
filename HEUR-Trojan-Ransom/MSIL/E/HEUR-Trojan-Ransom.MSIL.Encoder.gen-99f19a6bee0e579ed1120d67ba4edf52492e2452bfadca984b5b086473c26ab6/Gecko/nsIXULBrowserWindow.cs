using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a8675fa9-c8b4-4350-9803-c38f344a9e38")]
public interface nsIXULBrowserWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetJSStatus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase status);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOverLink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase link, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnBeforeLinkTraversal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase originalTarget, [MarshalAs(UnmanagedType.Interface)] nsIURI linkURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode linkNode, [MarshalAs(UnmanagedType.U1)] bool isAppTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITabParent ForceInitialBrowserRemote();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ShouldLoadURI([MarshalAs(UnmanagedType.Interface)] nsIDocShell aDocShell, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowTooltip(int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tooltip);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HideTooltip();
}
