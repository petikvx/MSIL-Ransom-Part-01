using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("dcbce63c-1dd1-11b2-b94d-91f6d49a3161")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMIMEInputStream : nsIInputStream
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
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAddContentLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAddContentLengthAttribute([MarshalAs(UnmanagedType.U1)] bool aAddContentLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddHeader([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetData([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream);
}
