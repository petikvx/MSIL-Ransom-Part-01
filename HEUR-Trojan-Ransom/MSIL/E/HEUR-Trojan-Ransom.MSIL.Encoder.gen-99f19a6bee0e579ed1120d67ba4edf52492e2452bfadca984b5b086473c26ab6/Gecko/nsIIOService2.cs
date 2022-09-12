using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("52c5804b-0d3c-4d4f-8654-1c36fd310e69")]
public interface nsIIOService2 : nsIIOService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIProtocolHandler GetProtocolHandler([MarshalAs(UnmanagedType.LPStr)] string aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetProtocolFlags([MarshalAs(UnmanagedType.LPStr)] string aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI NewFileURI([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewChannelFromURI2([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewChannelFromURIWithLoadInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewChannelFromURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewChannel2([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewChannel([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetOfflineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aOffline);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetConnectivityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetAppOffline(uint appId, int state);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsAppOffline(uint appId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetAppOfflineState(uint appId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool AllowPort(int aPort, [MarshalAs(UnmanagedType.LPStr)] string aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ExtractScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase urlString, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetManageOfflineStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetManageOfflineStatusAttribute([MarshalAs(UnmanagedType.U1)] bool aManageOfflineStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewChannelFromURIWithProxyFlags2([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aProxyURI, uint aProxyFlags, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewChannelFromURIWithProxyFlags([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aProxyURI, uint aProxyFlags);
}
