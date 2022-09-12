using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a1ca9af6-f865-4fdf-901d-5858bb0ad5ea")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLMenuElement
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

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);
}
