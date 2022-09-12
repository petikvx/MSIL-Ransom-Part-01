using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4d2ebe88-36eb-4e20-bcd1-997b3c1f24ce")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFeedResultListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleResult([MarshalAs(UnmanagedType.Interface)] nsIFeedResult result);
}
