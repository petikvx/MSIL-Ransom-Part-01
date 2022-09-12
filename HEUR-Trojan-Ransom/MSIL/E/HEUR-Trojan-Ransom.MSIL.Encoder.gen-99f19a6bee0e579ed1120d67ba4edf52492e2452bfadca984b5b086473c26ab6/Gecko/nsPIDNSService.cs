using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6b16fb1f-5709-4c94-a89f-a22be873c54d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsPIDNSService : nsIDNSService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsICancelable AsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CancelAsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDNSRecord Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsICancelable AsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CancelAsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDNSCacheEntries(IntPtr args);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetMyHostNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMyHostName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Shutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrefetchEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrefetchEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aPrefetchEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOfflineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aOffline);
}
