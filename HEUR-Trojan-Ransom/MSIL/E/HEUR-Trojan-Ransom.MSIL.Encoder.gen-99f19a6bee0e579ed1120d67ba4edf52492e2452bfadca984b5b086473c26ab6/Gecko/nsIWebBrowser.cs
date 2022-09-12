using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("33e9d001-caab-4ba9-8961-54902f197202")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebBrowser
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWebBrowserListener([MarshalAs(UnmanagedType.Interface)] nsIWeakReference aListener, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWebBrowserListener([MarshalAs(UnmanagedType.Interface)] nsIWeakReference aListener, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebBrowserChrome GetContainerWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContainerWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome aContainerWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURIContentListener GetParentURIContentListenerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentURIContentListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener aParentURIContentListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetContentDOMWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aIsActive);
}
