using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("cc8da053-1776-44c2-9199-b5a629d0a19d")]
public interface nsIThreadObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnDispatchedEvent([MarshalAs(UnmanagedType.Interface)] nsIThreadInternal thread);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnProcessNextEvent([MarshalAs(UnmanagedType.Interface)] nsIThreadInternal thread, [MarshalAs(UnmanagedType.U1)] bool mayWait);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AfterProcessNextEvent([MarshalAs(UnmanagedType.Interface)] nsIThreadInternal thread, [MarshalAs(UnmanagedType.U1)] bool eventWasProcessed);
}
