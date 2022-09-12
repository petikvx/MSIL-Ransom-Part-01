using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("91824160-fb25-11e1-a21f-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWifiTetheringCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void WifiTetheringEnabledChange(ref JsVal error);
}
