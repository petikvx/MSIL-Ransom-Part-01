using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("00000001-0000-0000-c000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CreateInstance([MarshalAs(UnmanagedType.Interface)] nsISupports aOuter, ref Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LockFactory([MarshalAs(UnmanagedType.U1)] bool @lock);
}
