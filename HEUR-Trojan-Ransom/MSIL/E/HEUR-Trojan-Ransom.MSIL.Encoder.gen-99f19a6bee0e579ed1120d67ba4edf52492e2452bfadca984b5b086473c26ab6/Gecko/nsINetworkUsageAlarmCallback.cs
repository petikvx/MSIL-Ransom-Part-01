using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0706bfa2-ac2d-11e2-9a8d-7b6d988d4767")]
public interface nsINetworkUsageAlarmCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NetworkUsageAlarmResult(ref JsVal error);
}
