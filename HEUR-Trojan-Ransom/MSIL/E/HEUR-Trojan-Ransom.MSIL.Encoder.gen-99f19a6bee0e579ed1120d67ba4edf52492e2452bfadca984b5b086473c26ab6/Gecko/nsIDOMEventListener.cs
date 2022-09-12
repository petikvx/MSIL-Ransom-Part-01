using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("df31c120-ded6-11d1-bd85-00805f8ae3f4")]
public interface nsIDOMEventListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent @event);
}
