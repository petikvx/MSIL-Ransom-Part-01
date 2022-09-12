using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e39da69e-2232-4e49-9856-b8a4a6210336")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMDOMRequest : nsIDOMEventTarget
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

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetReadyStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReadyState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetErrorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnsuccessAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnsuccessAttribute(JsVal aOnsuccess, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnerrorAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnerrorAttribute(JsVal aOnerror, IntPtr jsContext);
}
