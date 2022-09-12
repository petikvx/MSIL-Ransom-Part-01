using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ea51e0b8-871c-4b85-92da-6f400394c5ec")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHTTPHeaderListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NewResponseHeader([MarshalAs(UnmanagedType.LPStr)] string headerName, [MarshalAs(UnmanagedType.LPStr)] string headerValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StatusLine([MarshalAs(UnmanagedType.LPStr)] string line);
}
