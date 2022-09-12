using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("62a93afb-93a1-465c-84c8-0432264229de")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebNavigationInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint IsTypeSupported([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType, [MarshalAs(UnmanagedType.Interface)] nsIWebNavigation aWebNav);
}
