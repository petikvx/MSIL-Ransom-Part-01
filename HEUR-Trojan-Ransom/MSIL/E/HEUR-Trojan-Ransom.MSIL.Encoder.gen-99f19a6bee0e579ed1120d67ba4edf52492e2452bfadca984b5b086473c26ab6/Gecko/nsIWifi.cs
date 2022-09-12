using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("08dfefed-5c5d-4468-8c5d-2c65c24692d9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWifi
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Shutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWifiScanResults([MarshalAs(UnmanagedType.Interface)] nsIWifiScanResultsReady callback);
}
