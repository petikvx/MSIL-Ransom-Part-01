using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("31d1c294-1dd2-11b2-be3a-c79230dca297")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICacheDeviceInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetDescriptionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetUsageReportAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEntryCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTotalSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMaximumSizeAttribute();
}
