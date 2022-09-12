using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("23ac257d-ef3c-4033-b424-be7fef91a86c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITaskbarProgress
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProgressState(IntPtr state, ulong currentValue, ulong maxValue);
}
