using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("56c5c7d3-6fd3-43f8-9429-4397e111453a")]
public interface nsIExternalURLHandlerService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIHandlerInfo GetURLHandlerInfoFromOS([MarshalAs(UnmanagedType.Interface)] nsIURI aURL, [MarshalAs(UnmanagedType.U1)] ref bool aFound);
}
