using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f9d60700-e6dc-4a72-9537-689058655472")]
public interface nsIEventTarget
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsOnCurrentThread();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DispatchFromC(IntPtr @event, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Dispatch([MarshalAs(UnmanagedType.Interface)] nsIRunnable @event, uint flags);
}
