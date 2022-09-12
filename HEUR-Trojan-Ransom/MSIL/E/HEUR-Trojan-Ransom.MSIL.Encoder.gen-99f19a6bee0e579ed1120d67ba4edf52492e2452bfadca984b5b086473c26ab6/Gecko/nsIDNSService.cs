using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("de5642c6-61fc-4fcf-9a47-03226b0d4e21")]
public interface nsIDNSService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICancelable AsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelAsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDNSRecord Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICancelable AsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelAsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDNSCacheEntries(IntPtr args);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMyHostNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMyHostName);
}
