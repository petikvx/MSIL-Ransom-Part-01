using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("10f8ebdf-1373-4640-9c34-53dee99f526f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWorkerTestCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Onmessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Onerror([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data);
}
