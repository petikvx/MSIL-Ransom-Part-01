using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d74c4dc4-bc8c-4f5d-b7f1-121a48750abe")]
public interface nsIXMLHttpRequestUpload : nsIDOMEventTarget, nsIXMLHttpRequestEventTarget
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture, [MarshalAs(UnmanagedType.U1)] bool wantsUntrusted, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddSystemEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture, [MarshalAs(UnmanagedType.U1)] bool aWantsUntrusted, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveSystemEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent evt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new nsIDOMEventTarget GetTargetForDOMEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new nsIDOMEventTarget GetTargetForEventTargetChain();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void PreHandleEvent(IntPtr aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WillHandleEvent(IntPtr aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void PostHandleEvent(IntPtr aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DispatchDOMEvent(IntPtr aEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aDOMEvent, IntPtr aPresContext, IntPtr aEventStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetContextForEventHandlers(ref int aRv);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetJSContextForEventHandlers();
}
