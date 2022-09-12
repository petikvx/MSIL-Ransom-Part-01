using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2a99c757-dfee-4806-bff3-f721440412e0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISAXContentHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase localName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase qName, [MarshalAs(UnmanagedType.Interface)] nsISAXAttributes attributes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase localName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase qName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Characters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ProcessingInstruction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase target, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IgnorableWhitespace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase whitespace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartPrefixMapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase prefix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndPrefixMapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase prefix);
}
