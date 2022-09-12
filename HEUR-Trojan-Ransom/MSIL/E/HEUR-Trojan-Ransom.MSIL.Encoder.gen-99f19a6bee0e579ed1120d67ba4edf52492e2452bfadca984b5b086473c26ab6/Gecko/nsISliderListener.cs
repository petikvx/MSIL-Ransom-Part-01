using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e5b3074e-ee18-4538-83b9-2487d90a2a34")]
public interface nsISliderListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ValueChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase which, int newValue, [MarshalAs(UnmanagedType.U1)] bool userChanged);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DragStateChanged([MarshalAs(UnmanagedType.U1)] bool isDragging);
}
