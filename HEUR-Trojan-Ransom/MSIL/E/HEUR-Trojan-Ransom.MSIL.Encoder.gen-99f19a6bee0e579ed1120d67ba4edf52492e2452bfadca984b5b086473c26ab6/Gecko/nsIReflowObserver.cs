using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("832e692c-c4a6-11e2-8fd1-dce678957a39")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIReflowObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reflow(DOMHighResTimeStamp start, DOMHighResTimeStamp end);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReflowInterruptible(DOMHighResTimeStamp start, DOMHighResTimeStamp end);
}
