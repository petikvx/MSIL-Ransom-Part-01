using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1e004834-6d8f-425a-bc9c-a2812ed43bb7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMemory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HeapMinimize([MarshalAs(UnmanagedType.U1)] bool immediate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsLowMemory();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsLowMemoryPlatform();
}
