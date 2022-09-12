using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("910c9309-1da0-4dd0-8bdb-a325a38c604e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAsyncShutdownCompletionCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Done();
}
