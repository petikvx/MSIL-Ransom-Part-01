using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("66386aa9-2088-4bae-82c7-9f58bc02be64")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPopupWindowManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TestPermission([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal);
}
