using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("23c26a56-adff-440c-8caf-95c2dc2e399b")]
public interface nsISAXLexicalHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Comment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase chars);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartDTD([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase publicId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase systemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndDTD();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartCDATA();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndCDATA();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartEntity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndEntity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);
}
