using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0843f3c1-043e-4c64-9d8c-091370548c05")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBrowserTab
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetScaleAttribute();
}
