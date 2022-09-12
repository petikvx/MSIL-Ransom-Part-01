using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6fa79f99-4ce4-4634-840a-867fcfb32dba")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLOptGroupElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);
}
