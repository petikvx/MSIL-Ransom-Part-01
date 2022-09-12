using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("609610de-9954-4a63-8a7c-346350a86403")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProcess
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIFile executable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Kill();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Run([MarshalAs(UnmanagedType.U1)] bool blocking, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] string[] args, uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RunAsync([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] string[] args, uint count, [MarshalAs(UnmanagedType.Interface)] nsIObserver observer, [MarshalAs(UnmanagedType.U1)] bool holdWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Runw([MarshalAs(UnmanagedType.U1)] bool blocking, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] args, uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RunwAsync([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] args, uint count, [MarshalAs(UnmanagedType.Interface)] nsIObserver observer, [MarshalAs(UnmanagedType.U1)] bool holdWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetExitValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsRunningAttribute();
}
