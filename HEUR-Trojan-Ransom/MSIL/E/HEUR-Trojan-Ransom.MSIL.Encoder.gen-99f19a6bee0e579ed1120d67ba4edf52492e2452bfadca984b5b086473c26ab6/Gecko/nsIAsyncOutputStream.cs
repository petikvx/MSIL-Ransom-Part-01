using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("beb632d3-d77a-4e90-9134-f9ece69e8200")]
public interface nsIAsyncOutputStream : nsIOutputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Flush();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Write([MarshalAs(UnmanagedType.LPStr)] string aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint WriteFrom([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint WriteSegments(IntPtr aReader, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsNonBlocking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseWithStatus(int reason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncWait([MarshalAs(UnmanagedType.Interface)] nsIOutputStreamCallback aCallback, uint aFlags, uint aRequestedCount, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);
}
