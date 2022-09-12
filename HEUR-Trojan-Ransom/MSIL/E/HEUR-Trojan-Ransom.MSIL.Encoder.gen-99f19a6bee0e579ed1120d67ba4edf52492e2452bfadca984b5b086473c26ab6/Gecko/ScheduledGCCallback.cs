using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("71000535-b0fd-44d1-8ce0-909760e3953c")]
public interface ScheduledGCCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Callback();
}
