using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3ade79d4-8cb9-4952-b18d-4f9b63ca0d31")]
public interface nsIWebNavigation
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanGoBackAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanGoForwardAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GoBack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GoForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GotoIndex(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadURI([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aURI, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeaders);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadURIWithOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aURI, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, uint aReferrerPolicy, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeaders, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reload(uint aReloadFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Stop(uint aStopFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetCurrentURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetReferringURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHistory GetSessionHistoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSessionHistoryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHistory aSessionHistory);
}
