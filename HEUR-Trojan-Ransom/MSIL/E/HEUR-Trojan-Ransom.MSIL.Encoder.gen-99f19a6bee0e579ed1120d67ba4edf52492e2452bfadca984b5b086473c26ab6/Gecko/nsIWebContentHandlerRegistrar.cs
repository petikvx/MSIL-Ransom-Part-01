using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("65a3fafd-0e4a-4b06-8b4e-6a611da63d98")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebContentHandlerRegistrar
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterContentHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mimeType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsISupports windowOrBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterProtocolHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase protocol, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsISupports windowOrBrowser);
}
