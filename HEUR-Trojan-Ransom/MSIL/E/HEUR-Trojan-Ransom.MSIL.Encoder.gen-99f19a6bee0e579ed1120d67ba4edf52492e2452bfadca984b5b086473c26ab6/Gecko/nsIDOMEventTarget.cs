using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9a78ac3c-9507-4d00-b2d6-10b508d2ec31")]
public interface nsIDOMEventTarget
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture, [MarshalAs(UnmanagedType.U1)] bool wantsUntrusted, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSystemEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture, [MarshalAs(UnmanagedType.U1)] bool aWantsUntrusted, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSystemEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent evt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	nsIDOMEventTarget GetTargetForDOMEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	nsIDOMEventTarget GetTargetForEventTargetChain();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PreHandleEvent(IntPtr aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillHandleEvent(IntPtr aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PostHandleEvent(IntPtr aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DispatchDOMEvent(IntPtr aEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aDOMEvent, IntPtr aPresContext, IntPtr aEventStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetContextForEventHandlers(ref int aRv);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetJSContextForEventHandlers();
}
