using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f424abd3-32b4-456c-9f45-b7e3376cb0d1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProtocolProxyFilter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProxyInfo ApplyFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyService aProxyService, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxy);
}
