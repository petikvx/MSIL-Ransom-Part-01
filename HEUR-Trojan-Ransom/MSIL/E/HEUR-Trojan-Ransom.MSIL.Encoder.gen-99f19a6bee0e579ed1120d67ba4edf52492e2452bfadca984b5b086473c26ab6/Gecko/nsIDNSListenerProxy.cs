using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("60eff0e4-6f7c-493c-add9-1cbea59063ad")]
public interface nsIDNSListenerProxy
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDNSListener GetOriginalListenerAttribute();
}
