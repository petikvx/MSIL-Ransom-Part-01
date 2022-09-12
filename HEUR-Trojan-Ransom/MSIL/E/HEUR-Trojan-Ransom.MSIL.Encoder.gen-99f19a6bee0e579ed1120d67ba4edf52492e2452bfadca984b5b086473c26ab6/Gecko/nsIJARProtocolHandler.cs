using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("92c3b42c-98c4-11d3-8cd9-0060b0fc14a3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIJARProtocolHandler : nsIProtocolHandler
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
	nsIZipReaderCache GetJARCacheAttribute();
}
