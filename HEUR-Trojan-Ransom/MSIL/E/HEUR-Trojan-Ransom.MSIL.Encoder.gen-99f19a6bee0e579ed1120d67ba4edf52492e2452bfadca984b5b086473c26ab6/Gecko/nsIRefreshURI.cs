using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a5e61a3c-51bd-45be-ac0c-e87b71860656")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRefreshURI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RefreshURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aMillis, [MarshalAs(UnmanagedType.U1)] bool aRepeat, [MarshalAs(UnmanagedType.U1)] bool aMetaRefresh);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceRefreshURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aMillis, [MarshalAs(UnmanagedType.U1)] bool aMetaRefresh);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetupRefreshURI([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetupRefreshURIFromHeader([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeader);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelRefreshURITimers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRefreshPendingAttribute();
}
