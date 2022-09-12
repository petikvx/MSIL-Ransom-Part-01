using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8f8a23d0-5472-11d3-bbc8-0000861d1237")]
public interface nsISocketProviderService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISocketProvider GetSocketProvider([MarshalAs(UnmanagedType.LPStr)] string socketType);
}
