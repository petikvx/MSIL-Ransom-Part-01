using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ef57c8b6-e09d-4cd4-9222-2a5d2402e15d")]
public interface nsIProtocolProxyService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICancelable AsyncResolve([MarshalAs(UnmanagedType.Interface)] nsISupports aChannelOrURI, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProxyInfo NewProxyInfo([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, uint aFlags, uint aFailoverTimeout, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aFailoverProxy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProxyInfo NewProxyInfoWithAuth([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUsername, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPassword, uint aFlags, uint aFailoverTimeout, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aFailoverProxy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProxyInfo GetFailoverForProxy([MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyFilter aFilter, uint aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterChannelFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyChannelFilter aFilter, uint aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyFilter aFilter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterChannelFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyChannelFilter aFilter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetProxyConfigTypeAttribute();
}
