using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fafe41a9-a531-4d6d-89bc-588a6522fb4e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDownloader : nsIStreamListener, nsIRequestObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDownloadObserver observer, [MarshalAs(UnmanagedType.Interface)] nsIFile downloadLocation);
}
