using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8a0b2908-21b0-45d7-b14d-30df0f92afc7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFeedProcessor : nsIStreamListener, nsIRequestObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedResultListener GetListenerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedResultListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.Interface)] nsIURI uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseFromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, [MarshalAs(UnmanagedType.Interface)] nsIURI uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver requestObserver, [MarshalAs(UnmanagedType.Interface)] nsIURI uri);
}
