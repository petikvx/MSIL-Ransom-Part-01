using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("de93dc4c-5eea-4eb7-b6d1-dbf1e0cef65c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICancelableRunnable : nsIRunnable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Run();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel();
}
