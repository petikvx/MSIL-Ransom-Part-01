using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a9a34341-5a33-4e0a-98e1-13e7ea4228be")]
public interface nsICellInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRegisteredAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTimestampTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetTimestampAttribute();
}
