using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5b1de802-9091-454f-9972-5753c0d0c70e")]
public interface nsISAXXMLReader : nsIStreamListener, nsIRequestObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISAXContentHandler GetContentHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXContentHandler aContentHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISAXDTDHandler GetDtdHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDtdHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXDTDHandler aDtdHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISAXErrorHandler GetErrorHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetErrorHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXErrorHandler aErrorHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMozSAXXMLDeclarationHandler GetDeclarationHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDeclarationHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsIMozSAXXMLDeclarationHandler aDeclarationHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISAXLexicalHandler GetLexicalHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLexicalHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXLexicalHandler aLexicalHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFeature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.U1)] bool value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFeature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsISupports value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseFromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, [MarshalAs(UnmanagedType.LPStr)] string contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.LPStr)] string contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver observer);
}
