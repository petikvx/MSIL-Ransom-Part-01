using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("359F7990-D4E9-11d3-A1A5-0050041CAF44")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStreamLoaderObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStreamComplete([MarshalAs(UnmanagedType.Interface)] nsIStreamLoader loader, [MarshalAs(UnmanagedType.Interface)] nsISupports ctxt, int status, uint resultLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] result);
}
