using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2b44eb57-a9c6-4773-9a1e-fe0818739a4c")]
public interface nsIMessageListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReceiveMessage();
}
