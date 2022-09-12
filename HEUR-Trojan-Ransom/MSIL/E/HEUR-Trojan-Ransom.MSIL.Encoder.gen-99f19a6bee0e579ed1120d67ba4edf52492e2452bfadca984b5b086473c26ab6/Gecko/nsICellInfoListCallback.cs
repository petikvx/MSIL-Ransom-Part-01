using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d8fae631-7ade-4024-b288-7efe75e6b091")]
public interface nsICellInfoListCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetCellInfoList(uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] nsICellInfo[] result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetCellInfoListFailed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);
}
