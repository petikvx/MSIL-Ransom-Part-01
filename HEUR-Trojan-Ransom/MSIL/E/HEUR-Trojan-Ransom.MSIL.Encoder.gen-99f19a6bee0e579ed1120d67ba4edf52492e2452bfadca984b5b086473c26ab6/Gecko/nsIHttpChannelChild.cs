using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("893e29fb-2e84-454e-afc7-41fadbe93fd9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpChannelChild
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCookiesToRequest();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceIntercepted();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClientSetRequestHeadersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetClientSetCorsPreflightParameters(IntPtr args);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveCorsPreflightCacheEntry([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aRequestingPrincipal);
}
