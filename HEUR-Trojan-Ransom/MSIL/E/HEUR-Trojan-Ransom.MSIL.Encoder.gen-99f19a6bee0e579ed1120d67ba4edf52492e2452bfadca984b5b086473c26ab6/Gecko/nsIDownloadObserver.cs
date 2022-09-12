using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("44b3153e-a54e-4077-a527-b0325e40924e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDownloadObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnDownloadComplete([MarshalAs(UnmanagedType.Interface)] nsIDownloader downloader, [MarshalAs(UnmanagedType.Interface)] nsIRequest request, [MarshalAs(UnmanagedType.Interface)] nsISupports ctxt, int status, [MarshalAs(UnmanagedType.Interface)] nsIFile result);
}
