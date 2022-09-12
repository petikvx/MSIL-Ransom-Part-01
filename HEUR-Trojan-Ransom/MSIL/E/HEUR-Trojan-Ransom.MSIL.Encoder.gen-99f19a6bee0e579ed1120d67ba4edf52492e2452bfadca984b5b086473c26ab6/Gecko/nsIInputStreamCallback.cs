using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d1f28e94-3a6e-4050-a5f5-2e81b1fc2a43")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInputStreamCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnInputStreamReady([MarshalAs(UnmanagedType.Interface)] nsIAsyncInputStream aStream);
}
