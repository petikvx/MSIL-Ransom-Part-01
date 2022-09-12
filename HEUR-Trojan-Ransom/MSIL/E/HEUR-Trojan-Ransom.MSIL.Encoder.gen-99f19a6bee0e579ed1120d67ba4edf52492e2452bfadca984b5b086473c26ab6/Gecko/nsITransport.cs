using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2a8c6334-a5e6-4ec3-9865-1256541446fb")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITransport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream OpenInputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOutputStream OpenOutputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close(int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEventSink([MarshalAs(UnmanagedType.Interface)] nsITransportEventSink aSink, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);
}
