using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c0e461cb-0e5e-284c-b97d-cffeec467eba")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMozSAXXMLDeclarationHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleXMLDeclaration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase version, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase encoding, [MarshalAs(UnmanagedType.U1)] bool standalone);
}
