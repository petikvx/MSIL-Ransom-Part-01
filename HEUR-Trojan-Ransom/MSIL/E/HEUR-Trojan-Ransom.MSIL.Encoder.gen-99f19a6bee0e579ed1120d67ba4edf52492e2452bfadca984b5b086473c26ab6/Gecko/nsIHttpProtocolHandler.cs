using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c48126d9-2ddd-485b-a51a-378e917e75f8")]
public interface nsIHttpProtocolHandler : nsIProtocolHandler, nsIProxiedProtocolHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetDefaultPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetProtocolFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewChannel2([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadinfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewChannel([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool AllowPort(int port, [MarshalAs(UnmanagedType.LPStr)] string scheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewProxiedChannel2([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo proxyInfo, uint proxyResolveFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI proxyURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIChannel NewProxiedChannel([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo proxyInfo, uint proxyResolveFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI proxyURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUserAgentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUserAgent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAppName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAppVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlatformAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPlatform);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOscpuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOscpu);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMiscAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMisc);
}
