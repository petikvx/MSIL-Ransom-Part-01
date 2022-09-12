using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2dfe3a50-ab2f-11db-abbd-0800200c9a66")]
public interface extIEventListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEvent(extIEventItem aEvent);
}
