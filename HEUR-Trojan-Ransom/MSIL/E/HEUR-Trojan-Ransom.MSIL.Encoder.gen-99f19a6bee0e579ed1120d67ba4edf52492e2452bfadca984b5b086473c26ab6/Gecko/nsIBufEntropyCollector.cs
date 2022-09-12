using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("485b87a8-5dd7-4b8d-8ea8-dee53201f899")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBufEntropyCollector : nsIEntropyCollector
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RandomUpdate(IntPtr entropy, int bufLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForwardTo([MarshalAs(UnmanagedType.Interface)] nsIEntropyCollector collector);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DontForward();
}
