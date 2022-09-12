using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("450cd2d4-f0fd-424d-b365-b1251f80fd53")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStringInputStream : nsIInputStream
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
	void SetData([MarshalAs(UnmanagedType.LPStr)] string data, int dataLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AdoptData(IntPtr data, int dataLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShareData([MarshalAs(UnmanagedType.LPStr)] string data, int dataLen);
}
