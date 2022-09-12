using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b29aac15-7ec4-4ab3-a53b-08f78aed3b34")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDownloadManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDownload AddDownload(short aDownloadType, [MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI aTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName, [MarshalAs(UnmanagedType.Interface)] nsIMIMEInfo aMIMEInfo, long aStartTime, [MarshalAs(UnmanagedType.Interface)] nsIFile aTempFile, [MarshalAs(UnmanagedType.Interface)] nsICancelable aCancelable, [MarshalAs(UnmanagedType.U1)] bool aIsPrivate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDownload GetDownload(uint aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDownloadByGUID([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.Interface)] nsIDownloadManagerResult aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelDownload(uint aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDownload(uint aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDownloadsByTimeframe(long aBeginTime, long aEndTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PauseDownload(uint aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResumeDownload(uint aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RetryDownload(uint aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection GetDBConnectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection GetPrivateDBConnectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanCleanUpAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanCleanUpPrivateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CleanUp();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CleanUpPrivate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetActiveDownloadCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetActivePrivateDownloadCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetActiveDownloadsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetActivePrivateDownloadsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddListener([MarshalAs(UnmanagedType.Interface)] nsIDownloadProgressListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddPrivacyAwareListener([MarshalAs(UnmanagedType.Interface)] nsIDownloadProgressListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIDownloadProgressListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetDefaultDownloadsDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetUserDownloadsDirectoryAttribute();
}
