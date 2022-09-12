using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9cc51754-2eb3-4b46-ae99-38a61881c622")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIThreadInternal : nsIEventTarget, nsIThread
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsOnCurrentThread();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DispatchFromC(IntPtr @event, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Dispatch([MarshalAs(UnmanagedType.Interface)] nsIRunnable @event, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetPRThreadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Shutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool HasPendingEvents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool ProcessNextEvent([MarshalAs(UnmanagedType.U1)] bool mayWait);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AsyncShutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIThreadObserver GetObserverAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetObserverAttribute([MarshalAs(UnmanagedType.Interface)] nsIThreadObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIThreadObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIThreadObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEventTarget PushEventQueue();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PopEventQueue([MarshalAs(UnmanagedType.Interface)] nsIEventTarget aInnermostTarget);
}
