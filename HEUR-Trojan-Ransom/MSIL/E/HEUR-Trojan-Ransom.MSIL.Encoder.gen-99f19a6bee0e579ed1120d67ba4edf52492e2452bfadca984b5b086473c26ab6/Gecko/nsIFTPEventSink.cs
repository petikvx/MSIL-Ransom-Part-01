using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("455d4234-0330-43d2-bbfb-99afbecbfeb0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFTPEventSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnFTPControlLog([MarshalAs(UnmanagedType.U1)] bool server, [MarshalAs(UnmanagedType.LPStr)] string msg);
}
