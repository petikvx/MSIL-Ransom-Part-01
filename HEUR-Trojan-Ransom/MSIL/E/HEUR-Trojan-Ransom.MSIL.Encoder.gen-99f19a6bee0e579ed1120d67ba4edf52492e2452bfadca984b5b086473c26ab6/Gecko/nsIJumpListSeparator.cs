using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("69A2D5C5-14DC-47da-925D-869E0BD64D27")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIJumpListSeparator : nsIJumpListItem
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new short GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJumpListItem item);
}
