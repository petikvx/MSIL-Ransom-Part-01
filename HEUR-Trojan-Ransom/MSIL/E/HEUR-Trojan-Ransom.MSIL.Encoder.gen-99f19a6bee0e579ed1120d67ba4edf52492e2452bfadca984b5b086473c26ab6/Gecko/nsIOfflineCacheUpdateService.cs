using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a297a334-bcae-4779-a564-555593edc96b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIOfflineCacheUpdateService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNumUpdatesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOfflineCacheUpdate GetUpdate(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOfflineCacheUpdate ScheduleUpdate([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOfflineCacheUpdate ScheduleAppUpdate([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, uint aAppID, [MarshalAs(UnmanagedType.U1)] bool aInBrowser, [MarshalAs(UnmanagedType.Interface)] nsIFile aProfileDir);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScheduleOnDocumentStop([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckForUpdate([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, uint aAppID, [MarshalAs(UnmanagedType.U1)] bool aInBrowser, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OfflineAppAllowed([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrefBranch aPrefBranch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OfflineAppAllowedForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIPrefBranch aPrefBranch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AllowOfflineApp([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
}
