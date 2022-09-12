using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a796816d-7d47-4348-9ab8-c7aeb3216a7d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITimerCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Notify([MarshalAs(UnmanagedType.Interface)] nsITimer timer);
}
