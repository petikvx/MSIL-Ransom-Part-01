using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("EDA4F520-67F7-484b-A691-8C3226A5B0A6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITransportEventSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnTransportStatus([MarshalAs(UnmanagedType.Interface)] nsITransport aTransport, int aStatus, long aProgress, long aProgressMax);
}
