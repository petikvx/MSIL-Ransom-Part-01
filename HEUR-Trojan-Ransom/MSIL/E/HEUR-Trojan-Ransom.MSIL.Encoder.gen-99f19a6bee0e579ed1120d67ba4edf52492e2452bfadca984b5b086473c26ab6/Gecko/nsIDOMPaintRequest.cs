using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9eb5268f-73a4-41da-9790-d21fcefd5ffa")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMPaintRequest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMClientRect GetClientRectAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetReasonAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReason);
}
