using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("68167b0b-ef34-4d79-a09a-8045f7c5140e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITraceableChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStreamListener SetNewListener([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener);
}
