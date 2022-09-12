using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9f9b51f5-340e-47ce-85ae-9eb077c6cd39")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIApplicationUpdateService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckForBackgroundUpdates();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUpdateChecker GetBackgroundCheckerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUpdate SelectUpdate([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsIUpdate[] updates, uint updateCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddDownloadListener([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDownloadListener([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DownloadUpdate([MarshalAs(UnmanagedType.Interface)] nsIUpdate update, [MarshalAs(UnmanagedType.U1)] bool background, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ApplyOsUpdate([MarshalAs(UnmanagedType.Interface)] nsIUpdate update);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetUpdatesDirectory();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PauseDownload();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDownloadingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanCheckForUpdatesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanApplyUpdatesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsOtherInstanceHandlingUpdatesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanStageUpdatesAttribute();
}
