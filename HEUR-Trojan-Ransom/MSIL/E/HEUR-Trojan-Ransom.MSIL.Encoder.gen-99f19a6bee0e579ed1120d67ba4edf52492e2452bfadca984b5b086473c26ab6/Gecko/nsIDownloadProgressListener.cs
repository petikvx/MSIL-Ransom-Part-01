using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7acb07ea-cac2-4c15-a3ad-23aaa789ed51")]
public interface nsIDownloadProgressListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocumentAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnDownloadStateChange(short aState, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStateChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aStateFlags, int aStatus, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnProgressChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, long aCurSelfProgress, long aMaxSelfProgress, long aCurTotalProgress, long aMaxTotalProgress, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aState, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);
}
