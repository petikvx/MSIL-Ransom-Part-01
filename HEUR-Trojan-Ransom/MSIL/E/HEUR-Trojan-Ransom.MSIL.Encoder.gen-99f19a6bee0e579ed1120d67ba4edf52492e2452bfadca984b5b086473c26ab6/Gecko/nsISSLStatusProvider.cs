using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("179b1ab1-0950-4427-9556-6f496dc4a27f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISSLStatusProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISSLStatus GetSSLStatusAttribute();
}
