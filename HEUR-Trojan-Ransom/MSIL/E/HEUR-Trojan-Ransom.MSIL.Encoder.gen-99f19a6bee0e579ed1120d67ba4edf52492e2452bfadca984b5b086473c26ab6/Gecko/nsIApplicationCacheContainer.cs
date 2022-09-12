using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("bbb80700-1f7f-4258-aff4-1743cc5a7d23")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIApplicationCacheContainer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCache GetApplicationCacheAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetApplicationCacheAttribute([MarshalAs(UnmanagedType.Interface)] nsIApplicationCache aApplicationCache);
}
