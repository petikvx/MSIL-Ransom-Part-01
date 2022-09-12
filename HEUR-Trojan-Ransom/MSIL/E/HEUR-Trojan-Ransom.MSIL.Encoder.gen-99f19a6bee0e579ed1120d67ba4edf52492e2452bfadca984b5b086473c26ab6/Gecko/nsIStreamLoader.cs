using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("323bcff1-7513-4e1f-a541-1c9213c2ed1b")]
public interface nsIStreamLoader : nsIStreamListener, nsIRequestObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIStreamLoaderObserver aStreamObserver, [MarshalAs(UnmanagedType.Interface)] nsIRequestObserver aRequestObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNumBytesReadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRequest GetRequestAttribute();
}
