using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a5f255ab-4801-4161-8816-277ac92f6ad1")]
public interface nsIAsyncInputStream : nsIInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Available();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Read(IntPtr aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsNonBlocking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseWithStatus(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncWait([MarshalAs(UnmanagedType.Interface)] nsIInputStreamCallback aCallback, uint aFlags, uint aRequestedCount, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);
}
