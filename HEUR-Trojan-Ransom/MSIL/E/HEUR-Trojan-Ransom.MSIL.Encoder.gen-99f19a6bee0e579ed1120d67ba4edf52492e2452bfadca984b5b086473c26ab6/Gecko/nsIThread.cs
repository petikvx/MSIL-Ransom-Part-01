using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("594feb13-6164-4054-b5a1-ad62e10ea15d")]
public interface nsIThread : nsIEventTarget
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsOnCurrentThread();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DispatchFromC(IntPtr @event, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Dispatch([MarshalAs(UnmanagedType.Interface)] nsIRunnable @event, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPRThreadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Shutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasPendingEvents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ProcessNextEvent([MarshalAs(UnmanagedType.U1)] bool mayWait);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncShutdown();
}
