using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("dc263ca8-b257-47eb-b5b7-339d9e0b90f7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWinAppHelper
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUserCanElevateAttribute();
}
