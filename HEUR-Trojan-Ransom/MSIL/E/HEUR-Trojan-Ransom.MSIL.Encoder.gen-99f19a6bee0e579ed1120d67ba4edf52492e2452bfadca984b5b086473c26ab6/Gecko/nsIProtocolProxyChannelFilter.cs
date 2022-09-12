using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("245b0880-82c5-4e6e-be6d-bc586aa55a90")]
public interface nsIProtocolProxyChannelFilter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProxyInfo ApplyFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyService aProxyService, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxy);
}
