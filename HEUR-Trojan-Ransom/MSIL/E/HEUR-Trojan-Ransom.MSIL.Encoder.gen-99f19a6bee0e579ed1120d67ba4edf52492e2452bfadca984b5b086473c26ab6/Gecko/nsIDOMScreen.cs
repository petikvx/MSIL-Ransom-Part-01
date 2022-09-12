using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("82c7924b-4b46-4e5a-a8d2-6edb5fc0a60d")]
public interface nsIDOMScreen : nsIDOMEventTarget
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
	int GetTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPixelDepthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColorDepthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAvailWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAvailHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAvailLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAvailTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMozOrientationAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMozOrientation);
}
