using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("154c64fd-a69e-4105-89f8-bd7dfe621372")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISubstitutingProtocolHandler : nsIProtocolHandler
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
	void SetSubstitution([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase root, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetSubstitution([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase root);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasSubstitution([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase root);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResolveURI([MarshalAs(UnmanagedType.Interface)] nsIURI resURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
