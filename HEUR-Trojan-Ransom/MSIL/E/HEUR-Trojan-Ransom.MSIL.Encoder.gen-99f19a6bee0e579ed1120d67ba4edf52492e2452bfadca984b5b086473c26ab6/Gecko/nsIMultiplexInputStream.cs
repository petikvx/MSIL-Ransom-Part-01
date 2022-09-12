using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a076fd12-1dd1-11b2-b19a-d53b5dffaade")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMultiplexInputStream : nsIInputStream
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
	uint GetCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveStream(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetStream(uint index);
}
