using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("731C6C50-67D6-11d4-9529-0020183BF181")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICommandHandlerInit
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
}
