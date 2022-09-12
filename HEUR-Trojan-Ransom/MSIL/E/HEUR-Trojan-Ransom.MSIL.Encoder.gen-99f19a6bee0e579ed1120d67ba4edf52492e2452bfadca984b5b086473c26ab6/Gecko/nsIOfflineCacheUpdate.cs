using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e9029838-3553-4192-a00b-f0f11073a6eb")]
public interface nsIOfflineCacheUpdate
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPartialAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsUpgradeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUpdateDomainAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUpdateDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetManifestURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSucceededAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument, [MarshalAs(UnmanagedType.Interface)] nsIFile aCustomProfileDir, uint aAppId, [MarshalAs(UnmanagedType.U1)] bool aInBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitPartial([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aClientID, [MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitForUpdateCheck([MarshalAs(UnmanagedType.Interface)] nsIURI aManifestURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, uint aAppID, [MarshalAs(UnmanagedType.U1)] bool aInBrowser, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddDynamicURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Schedule();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIOfflineCacheUpdateObserver aObserver, [MarshalAs(UnmanagedType.U1)] bool aHoldWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIOfflineCacheUpdateObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetByteProgressAttribute();
}
