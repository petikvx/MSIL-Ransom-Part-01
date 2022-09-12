using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0b6e2c69-5cf5-48b0-9dfd-c95950e2cc7b")]
public interface nsIStreamConverter : nsIStreamListener, nsIRequestObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, [MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);
}
