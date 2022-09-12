using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5fb5bb60-7069-11e4-9803-0800200c9a66")]
public interface nsIContentPermissionRequestCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyVisibility([MarshalAs(UnmanagedType.U1)] bool isVisible);
}
