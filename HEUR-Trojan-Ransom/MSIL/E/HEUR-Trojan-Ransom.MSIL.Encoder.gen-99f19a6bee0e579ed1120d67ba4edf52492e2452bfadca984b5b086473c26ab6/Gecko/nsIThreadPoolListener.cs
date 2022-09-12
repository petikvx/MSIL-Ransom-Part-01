using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ef194cab-3f86-4b61-b132-e5e96a79e5d1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIThreadPoolListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnThreadCreated();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnThreadShuttingDown();
}
