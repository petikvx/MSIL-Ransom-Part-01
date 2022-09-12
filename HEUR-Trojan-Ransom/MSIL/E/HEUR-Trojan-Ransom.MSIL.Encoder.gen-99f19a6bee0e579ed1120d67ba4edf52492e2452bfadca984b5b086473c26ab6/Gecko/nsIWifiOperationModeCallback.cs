using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9ede8720-f8bc-11e2-b778-0800200c9a66")]
public interface nsIWifiOperationModeCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void WifiOperationModeResult(ref JsVal error);
}
