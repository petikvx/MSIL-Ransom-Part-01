using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d899642a-53e2-4eb4-9d65-4a666a45ee01")]
public interface nsIDOMHTMLOListElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCompactAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCompactAttribute([MarshalAs(UnmanagedType.U1)] bool aCompact);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReversedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReversedAttribute([MarshalAs(UnmanagedType.U1)] bool aReversed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStartAttribute(int aStart);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
}
