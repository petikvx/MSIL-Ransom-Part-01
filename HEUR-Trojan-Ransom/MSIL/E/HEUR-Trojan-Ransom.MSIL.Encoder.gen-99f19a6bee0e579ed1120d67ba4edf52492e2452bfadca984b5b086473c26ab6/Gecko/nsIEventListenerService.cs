using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("77aab5f7-213d-4db4-9f22-e46dfb774f15")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEventListenerService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetListenerInfoFor([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aEventTarget, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsIEventListenerInfo[] aOutArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEventTargetChainFor([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aEventTarget, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsIDOMEventTarget[] aOutArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasListenersFor([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aEventTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSystemEventListener([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget target, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSystemEventListener([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget target, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool useCapture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddListenerForAllEvents([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget target, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture, [MarshalAs(UnmanagedType.U1)] bool aWantsUntrusted, [MarshalAs(UnmanagedType.U1)] bool aSystemEventGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveListenerForAllEvents([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget target, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.U1)] bool aUseCapture, [MarshalAs(UnmanagedType.U1)] bool aSystemEventGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddListenerChangeListener([MarshalAs(UnmanagedType.Interface)] nsIListenerChangeListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveListenerChangeListener([MarshalAs(UnmanagedType.Interface)] nsIListenerChangeListener aListener);
}
