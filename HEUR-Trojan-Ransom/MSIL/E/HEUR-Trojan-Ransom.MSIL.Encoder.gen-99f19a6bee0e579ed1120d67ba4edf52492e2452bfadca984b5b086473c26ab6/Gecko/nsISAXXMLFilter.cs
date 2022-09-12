using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("77a22cf0-6cdf-11da-be43-001422106990")]
public interface nsISAXXMLFilter : nsIStreamListener, nsIRequestObserver, nsISAXXMLReader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISAXContentHandler GetContentHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContentHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXContentHandler aContentHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISAXDTDHandler GetDtdHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDtdHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXDTDHandler aDtdHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISAXErrorHandler GetErrorHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetErrorHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXErrorHandler aErrorHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIMozSAXXMLDeclarationHandler GetDeclarationHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDeclarationHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsIMozSAXXMLDeclarationHandler aDeclarationHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISAXLexicalHandler GetLexicalHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLexicalHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXLexicalHandler aLexicalHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFeature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.U1)] bool value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetFeature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsISupports value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ParseFromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, [MarshalAs(UnmanagedType.LPStr)] string contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.LPStr)] string contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISAXXMLReader GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXXMLReader aParent);
}
