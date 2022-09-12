using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("90a9d790-3bca-421e-a73b-98f68e13c917")]
public interface nsIInputStreamTee : nsIInputStream
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
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSourceAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOutputStream GetSinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSinkAttribute([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aSink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEventTarget GetEventTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEventTargetAttribute([MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);
}
