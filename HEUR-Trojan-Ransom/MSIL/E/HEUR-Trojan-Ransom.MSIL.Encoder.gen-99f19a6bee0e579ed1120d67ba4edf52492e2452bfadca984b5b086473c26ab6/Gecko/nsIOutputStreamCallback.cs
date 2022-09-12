using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("40dbcdff-9053-42c5-a57c-3ec910d0f148")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIOutputStreamCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnOutputStreamReady([MarshalAs(UnmanagedType.Interface)] nsIAsyncOutputStream aStream);
}
