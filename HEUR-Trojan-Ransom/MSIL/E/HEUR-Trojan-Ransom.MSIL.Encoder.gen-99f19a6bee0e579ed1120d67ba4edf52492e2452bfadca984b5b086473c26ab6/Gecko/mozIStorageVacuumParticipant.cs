using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8f367508-1d9a-4d3f-be0c-ac11b6dd7dbf")]
public interface mozIStorageVacuumParticipant
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetExpectedDatabasePageSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection GetDatabaseConnectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnBeginVacuum();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnEndVacuum([MarshalAs(UnmanagedType.U1)] bool aSucceeded);
}
