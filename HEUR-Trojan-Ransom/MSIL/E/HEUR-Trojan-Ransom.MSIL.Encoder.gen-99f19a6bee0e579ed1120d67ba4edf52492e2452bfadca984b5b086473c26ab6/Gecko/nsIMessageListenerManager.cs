using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b949bfec-bb7d-47bc-b387-ac6a9b655072")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMessageListenerManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener, [MarshalAs(UnmanagedType.U1)] bool listenWhenClosed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWeakMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWeakMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MarkForCC();
}
