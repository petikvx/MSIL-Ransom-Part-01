using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("BCD4BEDE-F4A5-4A62-9071-D7A60174E376")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWifiListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnChange([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsIWifiAccessPoint[] accessPoints, uint aLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnError(int error);
}
