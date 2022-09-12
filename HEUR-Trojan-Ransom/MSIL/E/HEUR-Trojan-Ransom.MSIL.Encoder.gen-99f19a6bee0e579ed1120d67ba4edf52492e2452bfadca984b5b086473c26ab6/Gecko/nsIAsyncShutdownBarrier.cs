using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("50fa8a86-9c91-4256-8389-17d310adec90")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAsyncShutdownBarrier
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAsyncShutdownClient GetClientAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPropertyBag GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Wait([MarshalAs(UnmanagedType.Interface)] nsIAsyncShutdownCompletionCallback aOnReady);
}
