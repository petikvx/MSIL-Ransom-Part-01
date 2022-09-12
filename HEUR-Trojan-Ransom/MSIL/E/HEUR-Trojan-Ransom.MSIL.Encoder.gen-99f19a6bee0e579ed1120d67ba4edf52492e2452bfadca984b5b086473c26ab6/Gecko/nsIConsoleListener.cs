using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("35c400a4-5792-438c-b915-65e30d58d557")]
public interface nsIConsoleListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Observe([MarshalAs(UnmanagedType.Interface)] nsIConsoleMessage aMessage);
}
