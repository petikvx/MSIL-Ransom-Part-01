using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7f093367-1492-4b89-87af-c01dbc831246")]
public interface nsICycleCollectorHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NoteRefCountedObject([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAddress, uint aRefCount, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aObjectDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NoteGCedObject([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAddress, [MarshalAs(UnmanagedType.U1)] bool aMarked, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aObjectDescription, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCompartmentAddress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NoteEdge([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFromAddress, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aToAddress, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aEdgeName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DescribeRoot([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAddress, uint aKnownEdges);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DescribeGarbage([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAddress);
}
