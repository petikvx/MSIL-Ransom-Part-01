using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b4b1449d-0ef0-47f5-b62e-adc57fd49702")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrivacyTransitionObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrivateModeChanged([MarshalAs(UnmanagedType.U1)] bool enabled);
}
