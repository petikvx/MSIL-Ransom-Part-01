using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3ab244a9-f09d-44da-9e3f-ee4d67367f2d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIScriptableUnescapeHTML
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unescape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocumentFragment ParseFragment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase fragment, [MarshalAs(UnmanagedType.U1)] bool isXML, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
}
