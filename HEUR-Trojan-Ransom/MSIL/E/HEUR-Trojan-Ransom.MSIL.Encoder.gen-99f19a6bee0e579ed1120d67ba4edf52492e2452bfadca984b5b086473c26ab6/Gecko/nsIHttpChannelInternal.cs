using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("332d5f9c-991c-45e3-922f-99e6fe0deb60")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpChannelInternal
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetDocumentURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocumentURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRequestVersion(ref uint major, ref uint minor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetResponseVersion(ref uint major, ref uint minor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TakeAllSecurityMessages(IntPtr aMessages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCookie([MarshalAs(UnmanagedType.LPStr)] string aCookieHeader);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetupFallbackChannel([MarshalAs(UnmanagedType.LPStr)] string aFallbackKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetThirdPartyFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetThirdPartyFlagsAttribute(uint aThirdPartyFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetForceAllowThirdPartyCookieAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetForceAllowThirdPartyCookieAttribute([MarshalAs(UnmanagedType.U1)] bool aForceAllowThirdPartyCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanceledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetChannelIsForDownloadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChannelIsForDownloadAttribute([MarshalAs(UnmanagedType.U1)] bool aChannelIsForDownload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLocalAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aLocalAddress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLocalPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRemoteAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRemoteAddress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRemotePortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCacheKeysRedirectChain(IntPtr cacheKeys);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HTTPUpgrade([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocolName, [MarshalAs(UnmanagedType.Interface)] nsIHttpUpgradeListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowSpdyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowSpdyAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowSpdy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetResponseTimeoutEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResponseTimeoutEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aResponseTimeoutEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetInitialRwinAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInitialRwinAttribute(uint aInitialRwin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetApiRedirectToURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowAltSvcAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowAltSvcAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowAltSvc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceIntercepted(ulong aInterceptionID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetResponseSynthesizedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCorsIncludeCredentialsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCorsIncludeCredentialsAttribute([MarshalAs(UnmanagedType.U1)] bool aCorsIncludeCredentials);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCorsModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCorsModeAttribute(uint aCorsMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRedirectModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRedirectModeAttribute(uint aRedirectMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetTopWindowURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNetworkInterfaceIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNetworkInterfaceId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNetworkInterfaceIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNetworkInterfaceId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetProxyURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCorsPreflightParameters(IntPtr unsafeHeaders);
}
