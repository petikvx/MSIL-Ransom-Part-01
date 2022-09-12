using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4dcd6a12-a091-4f38-8360-022929635746")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDownloadHistory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddDownload([MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, long aStartTime, [MarshalAs(UnmanagedType.Interface)] nsIURI aDestination);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAllDownloads();
}
