using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f8577124-6a5f-486f-ae04-c5bcae911eb5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentPermissionRequester
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVisibility([MarshalAs(UnmanagedType.Interface)] nsIContentPermissionRequestCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentPermissionRequestCallback GetOnVisibilityChangeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnVisibilityChangeAttribute([MarshalAs(UnmanagedType.Interface)] nsIContentPermissionRequestCallback aOnVisibilityChange);
}
