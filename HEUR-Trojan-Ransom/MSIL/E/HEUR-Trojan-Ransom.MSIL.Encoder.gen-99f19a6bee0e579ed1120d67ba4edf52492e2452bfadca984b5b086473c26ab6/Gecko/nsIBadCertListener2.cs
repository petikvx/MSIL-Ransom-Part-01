using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2c3d268c-ad82-49f3-99aa-e9ffddd7a0dc")]
public interface nsIBadCertListener2
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool NotifyCertProblem([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor socketInfo, [MarshalAs(UnmanagedType.Interface)] nsISSLStatus status, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase targetSite);
}
