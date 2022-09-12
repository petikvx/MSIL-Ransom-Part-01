using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("091116f0-0bdc-4b32-b9c8-c8d5a37cb088")]
public interface nsITreeView
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeSelection GetSelectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeSelection aSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRowProperties(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCellProperties(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetColumnProperties([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsContainer(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsContainerOpen(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsContainerEmpty(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSeparator(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSorted();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanDrop(int index, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Drop(int row, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetParentIndex(int rowIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasNextSibling(int rowIndex, int afterIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLevel(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetImageSrc(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetProgressMode(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCellValue(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCellText(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTree([MarshalAs(UnmanagedType.Interface)] nsITreeBoxObject tree);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToggleOpenState(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CycleHeader([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectionChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CycleCell(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEditable(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSelectable(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCellValue(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCellText(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PerformAction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PerformActionOnRow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action, int row);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PerformActionOnCell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action, int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
}
