using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6d12e467-2446-46db-9965-e4e93cb87ca5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentProcessMessageManager : nsIMessageListenerManager, nsIMessageSender, nsISyncMessageSender, nsIMessageManagerGlobal
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
	new JsVal SendSyncMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, ref JsVal obj, ref JsVal objects, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new JsVal SendRpcMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase messageName, ref JsVal obj, ref JsVal objects, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Dump([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void PrivateNoteIntentionalCrash();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Atob([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAsciiString, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Btoa([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBase64Data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetInitialProcessDataAttribute(IntPtr jsContext);
}
