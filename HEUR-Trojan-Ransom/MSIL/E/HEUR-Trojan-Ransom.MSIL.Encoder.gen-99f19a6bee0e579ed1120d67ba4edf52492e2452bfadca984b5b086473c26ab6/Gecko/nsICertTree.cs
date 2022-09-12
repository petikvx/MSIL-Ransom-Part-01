using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("55d5ad6b-5572-47fe-941c-f01fe723659e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICertTree : nsITreeView
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetRowCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsITreeSelection GetSelectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSelectionAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeSelection aSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetRowProperties(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCellProperties(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetColumnProperties([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsContainer(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsContainerOpen(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsContainerEmpty(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsSeparator(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsSorted();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool CanDrop(int index, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Drop(int row, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetParentIndex(int rowIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool HasNextSibling(int rowIndex, int afterIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetLevel(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetImageSrc(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetProgressMode(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCellValue(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCellText(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTree([MarshalAs(UnmanagedType.Interface)] nsITreeBoxObject tree);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ToggleOpenState(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CycleHeader([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SelectionChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CycleCell(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsEditable(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsSelectable(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCellValue(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCellText(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void PerformAction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void PerformActionOnRow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action, int row);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void PerformActionOnCell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string action, int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadCerts(uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadCertsFromCache([MarshalAs(UnmanagedType.Interface)] nsIX509CertList cache, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert GetCert(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICertTreeItem GetTreeItem(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsHostPortOverride(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteEntryObject(uint index);
}
