using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("65a8e823-0591-4fc0-a56a-03265e0a4ce8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProtocolHandlerWithDynamicFlags
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlagsForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
}
