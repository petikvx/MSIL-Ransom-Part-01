using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7fb719b3-d804-4964-9596-77cf924ee314")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContextMenuListener2
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnShowContextMenu(uint aContextFlags, [MarshalAs(UnmanagedType.Interface)] nsIContextMenuInfo aUtils);
}
