using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4286de5a-b2ea-446f-8f70-e2a461f42694")]
public interface nsIIOService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProtocolHandler GetProtocolHandler([MarshalAs(UnmanagedType.LPStr)] string aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetProtocolFlags([MarshalAs(UnmanagedType.LPStr)] string aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI NewFileURI([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewChannelFromURI2([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewChannelFromURIWithLoadInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewChannelFromURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewChannel2([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewChannel([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOfflineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aOffline);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetConnectivityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAppOffline(uint appId, int state);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAppOffline(uint appId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAppOfflineState(uint appId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AllowPort(int aPort, [MarshalAs(UnmanagedType.LPStr)] string aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExtractScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase urlString, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
