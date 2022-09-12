using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("456ca3b2-02be-4f97-89a2-08c08d3ad88f")]
public interface nsIContentDispatchChooser
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Ask([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandler, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, uint aReason);
}
