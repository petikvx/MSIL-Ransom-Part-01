using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3756047a-fa2b-4b45-9948-3b5f8fc375e7")]
public interface nsIProxiedProtocolHandler : nsIProtocolHandler
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
	nsIChannel NewProxiedChannel2([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo proxyInfo, uint proxyResolveFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI proxyURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel NewProxiedChannel([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo proxyInfo, uint proxyResolveFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI proxyURI);
}
