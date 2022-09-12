using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("58e330c1-7b48-11d2-98b9-00805f297d89")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITransaction
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UndoTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RedoTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsTransientAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Merge([MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction);
}
