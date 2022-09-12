using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6f883680-ab9d-11d4-9978-00b0d02354a0")]
public interface nsIEntropyCollector
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RandomUpdate(IntPtr entropy, int bufLen);
}
