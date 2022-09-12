using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9fc39136-f08b-46d3-b232-96f4b7b0e235")]
public interface nsISearchInstallCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSuccess([MarshalAs(UnmanagedType.Interface)] nsISearchEngine engine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnError(uint errorCode);
}
