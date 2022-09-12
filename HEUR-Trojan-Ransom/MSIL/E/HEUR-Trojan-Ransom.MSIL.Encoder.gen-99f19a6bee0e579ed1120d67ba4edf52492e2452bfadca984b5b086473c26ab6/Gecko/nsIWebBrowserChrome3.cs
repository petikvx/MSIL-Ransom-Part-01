using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("542b6625-35a9-426a-8257-c12a345383b0")]
public interface nsIWebBrowserChrome3 : nsIWebBrowserChrome, nsIWebBrowserChrome2
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetStatus(uint statusType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string status);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIWebBrowser GetWebBrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetWebBrowserAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebBrowser aWebBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetChromeFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetChromeFlagsAttribute(uint aChromeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DestroyBrowserWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SizeBrowserTo(int aCX, int aCY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ShowAsModal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsWindowModal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ExitModalEventLoop(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetStatusWithContext(uint statusType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase statusText, [MarshalAs(UnmanagedType.Interface)] nsISupports statusContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnBeforeLinkTraversal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase originalTarget, [MarshalAs(UnmanagedType.Interface)] nsIURI linkURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode linkNode, [MarshalAs(UnmanagedType.U1)] bool isAppTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ShouldLoadURI([MarshalAs(UnmanagedType.Interface)] nsIDocShell aDocShell, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);
}
