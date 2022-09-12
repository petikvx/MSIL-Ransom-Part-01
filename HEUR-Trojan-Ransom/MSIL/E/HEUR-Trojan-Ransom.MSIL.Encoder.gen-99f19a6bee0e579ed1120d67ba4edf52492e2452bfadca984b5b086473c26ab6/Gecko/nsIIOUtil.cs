using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e8152f7f-4209-4c63-ad23-c3d2aa0c5a49")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIIOUtil
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool InputStreamIsBuffered([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OutputStreamIsBuffered([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream);
}
