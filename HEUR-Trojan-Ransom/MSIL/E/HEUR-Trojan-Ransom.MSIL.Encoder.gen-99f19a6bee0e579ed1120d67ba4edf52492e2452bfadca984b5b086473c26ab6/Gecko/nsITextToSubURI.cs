using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8B042E24-6F87-11d3-B3C8-00805F8A6670")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITextToSubURI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string ConvertAndEscape([MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string UnEscapeAndConvert([MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.LPStr)] string text);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnEscapeURIForUI([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIFragment, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnEscapeNonAsciiURI([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIFragment, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
