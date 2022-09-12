using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("62b27fc1-6e8c-4225-8ad0-b9d44252973a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStreamListenerTee : nsIStreamListener, nsIRequestObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIStreamListener listener, [MarshalAs(UnmanagedType.Interface)] nsIOutputStream sink, [MarshalAs(UnmanagedType.Interface)] nsIRequestObserver requestObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitAsync([MarshalAs(UnmanagedType.Interface)] nsIStreamListener listener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget eventTarget, [MarshalAs(UnmanagedType.Interface)] nsIOutputStream sink, [MarshalAs(UnmanagedType.Interface)] nsIRequestObserver requestObserver);
}
