using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("32407c50-46c7-11e3-8f96-0800200c9a66")]
public interface nsIUsbTetheringCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void UsbTetheringEnabledChange(ref JsVal error);
}
