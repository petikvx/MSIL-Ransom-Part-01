using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6006e502-3861-49bd-aba1-fa6d2e74e237")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessiblePivotObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnPivotChanged([MarshalAs(UnmanagedType.Interface)] nsIAccessiblePivot aPivot, [MarshalAs(UnmanagedType.Interface)] nsIAccessible aOldAccessible, int aOldStart, int aOldEnd, PivotMoveReason aReason, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput);
}
