using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0e602c9e-1977-422a-a8e4-fe0d4a4f78d0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISyncMessageSender : nsIMessageListenerManager, nsIMessageSender
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener, [MarshalAs(UnmanagedType.U1)] bool listenWhenClosed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddWeakMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveWeakMessageListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, [MarshalAs(UnmanagedType.Interface)] nsIMessageListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool MarkForCC();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SendAsyncMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, ref JsVal obj, ref JsVal objects, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal SendSyncMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, ref JsVal obj, ref JsVal objects, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal SendRpcMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, ref JsVal obj, ref JsVal objects, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, IntPtr jsContext, int argc);
}
