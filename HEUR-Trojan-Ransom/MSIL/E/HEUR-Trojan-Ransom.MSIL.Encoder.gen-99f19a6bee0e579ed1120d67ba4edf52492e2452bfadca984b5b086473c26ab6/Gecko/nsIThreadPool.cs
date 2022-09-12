using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("cacd4a2e-2655-4ff8-894c-10c15883cd0a")]
public interface nsIThreadPool : nsIEventTarget
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsOnCurrentThread();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DispatchFromC(IntPtr @event, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Dispatch([MarshalAs(UnmanagedType.Interface)] nsIRunnable @event, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Shutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetThreadLimitAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetThreadLimitAttribute(uint aThreadLimit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIdleThreadLimitAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIdleThreadLimitAttribute(uint aIdleThreadLimit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIdleThreadTimeoutAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIdleThreadTimeoutAttribute(uint aIdleThreadTimeout);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetThreadStackSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetThreadStackSizeAttribute(uint aThreadStackSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIThreadPoolListener GetListenerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIThreadPoolListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetName([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);
}
