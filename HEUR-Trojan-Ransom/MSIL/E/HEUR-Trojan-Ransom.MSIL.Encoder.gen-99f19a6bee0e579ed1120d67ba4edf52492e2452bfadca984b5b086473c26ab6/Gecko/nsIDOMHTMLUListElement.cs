using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8ba1ee8d-36a4-43fc-9148-5144c2a29c96")]
public interface nsIDOMHTMLUListElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCompactAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCompactAttribute([MarshalAs(UnmanagedType.U1)] bool aCompact);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
}
