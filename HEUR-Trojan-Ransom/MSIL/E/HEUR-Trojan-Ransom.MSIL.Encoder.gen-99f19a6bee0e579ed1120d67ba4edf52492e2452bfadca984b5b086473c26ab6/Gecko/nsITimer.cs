using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3de4b105-363c-482c-a409-baac83a01bfc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITimer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver, uint aDelay, uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithFuncCallback(IntPtr aCallback, IntPtr aClosure, uint aDelay, uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithCallback([MarshalAs(UnmanagedType.Interface)] nsITimerCallback aCallback, uint aDelay, uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithNamedFuncCallback(IntPtr aCallback, IntPtr aClosure, uint aDelay, uint aType, [MarshalAs(UnmanagedType.LPStr)] string aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithNameableFuncCallback(IntPtr aCallback, IntPtr aClosure, uint aDelay, uint aType, IntPtr aNameCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDelayAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDelayAttribute(uint aDelay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute(uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClosureAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITimerCallback GetCallbackAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEventTarget GetTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTargetAttribute([MarshalAs(UnmanagedType.Interface)] nsIEventTarget aTarget);
}
