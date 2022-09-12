using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ACB8FB3C-E1B0-4044-8A50-E52C3E7C1057")]
public interface nsIJumpListItem
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJumpListItem item);
}
