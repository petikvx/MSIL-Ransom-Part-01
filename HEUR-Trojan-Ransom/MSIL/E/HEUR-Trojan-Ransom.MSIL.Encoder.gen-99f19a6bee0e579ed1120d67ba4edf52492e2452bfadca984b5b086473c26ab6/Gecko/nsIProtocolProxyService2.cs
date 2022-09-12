using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b2e5b2c0-e21e-4845-b336-be6d60a38951")]
public interface nsIProtocolProxyService2 : nsIProtocolProxyService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsICancelable AsyncResolve([MarshalAs(UnmanagedType.Interface)] nsISupports aChannelOrURI, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIProxyInfo NewProxyInfo([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, uint aFlags, uint aFailoverTimeout, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aFailoverProxy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIProxyInfo NewProxyInfoWithAuth([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUsername, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPassword, uint aFlags, uint aFailoverTimeout, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aFailoverProxy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIProxyInfo GetFailoverForProxy([MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RegisterFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyFilter aFilter, uint aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RegisterChannelFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyChannelFilter aFilter, uint aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void UnregisterFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyFilter aFilter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void UnregisterChannelFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyChannelFilter aFilter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetProxyConfigTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReloadPAC();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICancelable AsyncResolve2([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyCallback aCallback);
}
