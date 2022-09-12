using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("F29270C8-3BE5-4046-9B57-945A84DFF132")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXULSortService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Sort([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSortKey, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSortHints);
}
