using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a6931ebf-8493-4014-90e2-99f406999982")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWifiScanResultsReady
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Onready(uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] nsIWifiScanResult[] results);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Onfailure();
}
