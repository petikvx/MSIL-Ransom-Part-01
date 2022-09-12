using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5a9b4770-9fcb-4307-a12e-4b6708e78b97")]
public interface nsIRDFPropagatableDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPropagateChangesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPropagateChangesAttribute([MarshalAs(UnmanagedType.U1)] bool aPropagateChanges);
}
