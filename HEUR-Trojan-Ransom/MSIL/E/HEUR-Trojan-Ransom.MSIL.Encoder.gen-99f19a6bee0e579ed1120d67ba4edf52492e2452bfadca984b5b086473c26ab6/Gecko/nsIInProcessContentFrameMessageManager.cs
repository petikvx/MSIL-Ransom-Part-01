using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9c6bd4d7-88d2-46d6-8606-f2d57d46f051")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInProcessContentFrameMessageManager : nsIMessageListenerManager, nsIMessageSender, nsISyncMessageSender, nsIMessageManagerGlobal, nsIContentFrameMessageManager
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
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMWindow GetContentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShell GetDocShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetOwnerContent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CacheFrameLoader(IntPtr aFrameLoader);
}
