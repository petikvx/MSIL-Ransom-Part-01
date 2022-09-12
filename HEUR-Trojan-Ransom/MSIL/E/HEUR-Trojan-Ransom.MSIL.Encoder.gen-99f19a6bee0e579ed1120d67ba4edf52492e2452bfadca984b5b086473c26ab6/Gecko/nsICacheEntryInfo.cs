using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fab51c92-95c3-4468-b317-7de4d7588254")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICacheEntryInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetClientIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetDeviceIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFetchCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLastFetchedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetExpirationTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDataSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsStreamBased();
}
