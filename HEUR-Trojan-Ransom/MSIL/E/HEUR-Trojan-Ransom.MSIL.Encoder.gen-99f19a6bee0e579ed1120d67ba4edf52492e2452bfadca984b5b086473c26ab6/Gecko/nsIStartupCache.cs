using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("25957820-90a1-428c-8739-b0845d3cc534")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStartupCache
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetBuffer([MarshalAs(UnmanagedType.LPStr)] string aID, ref IntPtr aBuffer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutBuffer([MarshalAs(UnmanagedType.LPStr)] string aID, [MarshalAs(UnmanagedType.LPStr)] string aBuffer, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateCache();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IgnoreDiskCache();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIObjectOutputStream GetDebugObjectOutputStream([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool StartupWriteComplete();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetStartupWriteTimer();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RecordAgesAlways();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIObserver GetObserverAttribute();
}
