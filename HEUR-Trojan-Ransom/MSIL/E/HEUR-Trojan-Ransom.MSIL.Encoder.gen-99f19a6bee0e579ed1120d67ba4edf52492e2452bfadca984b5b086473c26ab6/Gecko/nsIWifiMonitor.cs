using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F289701E-D9AF-4685-BC2F-E4226FF7C018")]
public interface nsIWifiMonitor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartWatching([MarshalAs(UnmanagedType.Interface)] nsIWifiListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopWatching([MarshalAs(UnmanagedType.Interface)] nsIWifiListener aListener);
}
