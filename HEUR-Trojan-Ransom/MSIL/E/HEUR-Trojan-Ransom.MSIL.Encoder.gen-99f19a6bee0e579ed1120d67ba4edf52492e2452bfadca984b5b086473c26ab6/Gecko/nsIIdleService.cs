using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("cc52f19a-63ae-4a1c-9cc3-e79eace0b471")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIIdleService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIdleTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddIdleObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver observer, uint time);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveIdleObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver observer, uint time);
}
