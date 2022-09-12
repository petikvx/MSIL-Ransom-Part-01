using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4a91aeb3-4100-43ee-a21e-9866268757c5")]
public interface nsIXSLTProcessor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportStylesheet([MarshalAs(UnmanagedType.Interface)] nsIDOMNode style);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocumentFragment TransformToFragment([MarshalAs(UnmanagedType.Interface)] nsIDOMNode source, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument output);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument TransformToDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMNode source);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParameter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase localName, [MarshalAs(UnmanagedType.Interface)] nsIVariant value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetParameter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase localName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveParameter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase localName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearParameters();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();
}
