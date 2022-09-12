using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("840d0d00-e83e-4a29-b3c7-67e96e90a499")]
public interface nsIXHRSendable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSendInfo([MarshalAs(UnmanagedType.Interface)] ref nsIInputStream body, ref ulong contentLength, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase contentType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase charset);
}
