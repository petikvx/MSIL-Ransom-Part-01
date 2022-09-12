using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2EDF705F-D252-4971-9F09-71DD0F760DC6")]
public interface nsISHTransaction
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry GetSHEntryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSHEntryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHTransaction GetPrevAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrevAttribute([MarshalAs(UnmanagedType.Interface)] nsISHTransaction aPrev);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHTransaction GetNextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNextAttribute([MarshalAs(UnmanagedType.Interface)] nsISHTransaction aNext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPersistAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPersistAttribute([MarshalAs(UnmanagedType.U1)] bool aPersist);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Create([MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry, [MarshalAs(UnmanagedType.Interface)] nsISHTransaction aPrev);
}
