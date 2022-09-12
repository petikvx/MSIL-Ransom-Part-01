using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4a2abaf0-6886-11d3-9382-00104ba0fd40")]
public interface nsIRunnable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Run();
}
