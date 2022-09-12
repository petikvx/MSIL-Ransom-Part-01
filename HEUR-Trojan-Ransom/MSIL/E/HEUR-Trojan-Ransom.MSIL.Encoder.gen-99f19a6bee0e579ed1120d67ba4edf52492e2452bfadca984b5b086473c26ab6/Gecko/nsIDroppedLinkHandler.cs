using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6B58A5A7-76D0-4E93-AB2E-4DE108683FF8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDroppedLinkHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanDropLink([MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aEvent, [MarshalAs(UnmanagedType.U1)] bool aAllowSameDocument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DropLink([MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aEvent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.U1)] bool aDisallowInherit, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
