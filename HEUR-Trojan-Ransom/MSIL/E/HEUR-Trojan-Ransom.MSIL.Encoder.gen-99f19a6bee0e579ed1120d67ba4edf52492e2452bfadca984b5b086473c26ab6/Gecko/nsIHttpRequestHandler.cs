using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2bbb4db7-d285-42b3-a3ce-142b8cc7e139")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpRequestHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Handle([MarshalAs(UnmanagedType.Interface)] nsIHttpRequest request, [MarshalAs(UnmanagedType.Interface)] nsIHttpResponse response);
}
