using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B135F602-0BFE-11D5-A73C-F0E420E8293C")]
public interface nsPICommandUpdater
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CommandStatusChanged([MarshalAs(UnmanagedType.LPStr)] string aCommandName);
}
