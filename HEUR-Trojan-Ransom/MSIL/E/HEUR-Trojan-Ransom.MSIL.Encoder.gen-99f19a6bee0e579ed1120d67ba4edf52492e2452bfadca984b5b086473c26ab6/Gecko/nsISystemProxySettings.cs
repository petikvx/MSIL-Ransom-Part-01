using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("971591cd-277e-409a-bbf6-0a79879cd307")]
public interface nsISystemProxySettings
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMainThreadOnlyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPACURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPACURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProxyForURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase testSpec, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase testScheme, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase testHost, int testPort, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
