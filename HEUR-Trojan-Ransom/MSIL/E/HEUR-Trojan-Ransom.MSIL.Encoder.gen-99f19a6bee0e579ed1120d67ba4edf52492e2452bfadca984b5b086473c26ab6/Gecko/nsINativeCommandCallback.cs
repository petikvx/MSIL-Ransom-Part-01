using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5d0e1a60-1187-11e4-9191-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINativeCommandCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NativeCommandResult([MarshalAs(UnmanagedType.U1)] bool success);
}
