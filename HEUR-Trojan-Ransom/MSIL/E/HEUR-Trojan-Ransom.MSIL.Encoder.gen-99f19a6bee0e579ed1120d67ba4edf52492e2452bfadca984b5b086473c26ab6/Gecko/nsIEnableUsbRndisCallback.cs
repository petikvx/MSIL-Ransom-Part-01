using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("055fd560-46ad-11e3-8f96-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEnableUsbRndisCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableUsbRndisResult([MarshalAs(UnmanagedType.U1)] bool success, [MarshalAs(UnmanagedType.U1)] bool enable);
}
