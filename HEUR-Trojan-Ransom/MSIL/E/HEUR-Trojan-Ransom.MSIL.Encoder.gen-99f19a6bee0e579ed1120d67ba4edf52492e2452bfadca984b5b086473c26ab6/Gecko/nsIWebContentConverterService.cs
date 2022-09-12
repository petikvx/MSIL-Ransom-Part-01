using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("de7cc06e-e778-45cb-b7db-7a114e1e75b1")]
public interface nsIWebContentConverterService : nsIWebContentHandlerRegistrar
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RegisterContentHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mimeType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsISupports windowOrBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RegisterProtocolHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase protocol, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsISupports windowOrBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutoHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase contentType, [MarshalAs(UnmanagedType.Interface)] nsIWebContentHandlerInfo handler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebContentHandlerInfo GetAutoHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebContentHandlerInfo GetWebContentHandlerByURI([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase contentType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadPreferredHandler([MarshalAs(UnmanagedType.Interface)] nsIRequest request);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveProtocolHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase protocol, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveContentHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase contentType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentHandlers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase contentType, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsIWebContentHandlerInfo[] handlers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetHandlersForType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase contentType);
}
