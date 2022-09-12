using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e1797597-f4d6-4dd3-a1e1-745ad352cd80")]
public interface nsIUrlClassifierStreamUpdater
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DownloadUpdates([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRequestTables, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRequestBody, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUpdateUrl, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback aSuccessCallback, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback aUpdateErrorCallback, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback aDownloadErrorCallback);
}
