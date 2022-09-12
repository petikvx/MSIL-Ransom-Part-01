using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0197720d-37ed-4e75-8956-d0d296e4d8a6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIChannelEventSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncOnChannelRedirect([MarshalAs(UnmanagedType.Interface)] nsIChannel oldChannel, [MarshalAs(UnmanagedType.Interface)] nsIChannel newChannel, uint flags, [MarshalAs(UnmanagedType.Interface)] nsIAsyncVerifyRedirectCallback callback);
}
