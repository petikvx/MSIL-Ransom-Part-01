using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f8c08c4b-d778-49d1-a59b-866fdc500d95")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICacheVisitor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool VisitDevice([MarshalAs(UnmanagedType.LPStr)] string deviceID, [MarshalAs(UnmanagedType.Interface)] nsICacheDeviceInfo deviceInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool VisitEntry([MarshalAs(UnmanagedType.LPStr)] string deviceID, [MarshalAs(UnmanagedType.Interface)] nsICacheEntryInfo entryInfo);
}
