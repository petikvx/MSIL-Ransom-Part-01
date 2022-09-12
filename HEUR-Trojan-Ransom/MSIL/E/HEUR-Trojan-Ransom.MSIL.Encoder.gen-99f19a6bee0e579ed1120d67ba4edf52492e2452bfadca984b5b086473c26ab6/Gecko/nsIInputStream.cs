using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("53cdbc97-c2d7-4e30-b2c3-45b2ee79db18")]
public interface nsIInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Available();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Read(IntPtr aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsNonBlocking();
}
