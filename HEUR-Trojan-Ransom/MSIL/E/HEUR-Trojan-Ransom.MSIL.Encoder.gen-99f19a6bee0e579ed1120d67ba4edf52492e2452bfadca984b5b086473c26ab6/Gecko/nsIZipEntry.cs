using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fad6f72f-13d8-4e26-9173-53007a4afe71")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIZipEntry
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetCompressionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRealSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCRC32Attribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSyntheticAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPermissionsAttribute();
}
