using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("57CED9A7-EC0B-4A0E-8AEB-5DA32EBE951C")]
public interface nsIXULTreeBuilderObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanDrop(int index, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnDrop(int row, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnToggleOpenState(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCycleHeader([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string colID, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement elt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCycleCell(int row, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string colID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSelectionChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnPerformAction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnPerformActionOnRow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action, int row);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnPerformActionOnCell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action, int row, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string colID);
}
