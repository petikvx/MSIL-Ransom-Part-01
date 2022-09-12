using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3bc96351-53b0-47a1-a888-c74c64b60f25")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRilSendWorkerMessageCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandleResponse(ref JsVal response);
}
