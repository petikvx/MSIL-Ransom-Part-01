using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("10a28f38-32e8-4c63-8aa1-12eaaebc369a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIURIContentListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnStartURIOpen([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DoContent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType, [MarshalAs(UnmanagedType.U1)] bool aIsContentPreferred, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] ref nsIStreamListener aContentHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsPreferred([MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.LPStr)] ref string aDesiredContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanHandleContent([MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.U1)] bool aIsContentPreferred, [MarshalAs(UnmanagedType.LPStr)] ref string aDesiredContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetLoadCookieAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadCookieAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aLoadCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURIContentListener GetParentContentListenerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentContentListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener aParentContentListener);
}
