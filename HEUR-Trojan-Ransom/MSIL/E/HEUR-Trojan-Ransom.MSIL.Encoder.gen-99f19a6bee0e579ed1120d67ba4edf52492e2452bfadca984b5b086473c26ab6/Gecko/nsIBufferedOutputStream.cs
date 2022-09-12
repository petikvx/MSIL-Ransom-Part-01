using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6476378a-da09-11d3-8cda-0060b0fc14a3")]
public interface nsIBufferedOutputStream : nsIOutputStream
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
	void Init([MarshalAs(UnmanagedType.Interface)] nsIOutputStream sinkToStream, uint bufferSize);
}
