using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a1101145-0025-411e-8873-fdf57bf28128")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIParserUtils
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Sanitize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase src, uint flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertToPlainText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase src, uint flags, uint wrapCol, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocumentFragment ParseFragment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase fragment, uint flags, [MarshalAs(UnmanagedType.U1)] bool isXML, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
}
