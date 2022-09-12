using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e4723748-1dd1-11b2-8ee6-866a532a6237")]
public interface nsIDOMNodeFilter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	short AcceptNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode n);
}
