using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0941cb79-36e5-41e0-b05f-cdb854c53f03")]
public interface nsINeighboringCellIdsCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetNeighboringCellIds(uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] nsINeighboringCellInfo[] result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetNeighboringCellIdsFailed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);
}
