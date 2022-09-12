using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3478b6b0-3875-11d4-94ef-0020183bf181")]
public interface nsIContextMenuListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnShowContextMenu(uint aContextFlags, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
}
