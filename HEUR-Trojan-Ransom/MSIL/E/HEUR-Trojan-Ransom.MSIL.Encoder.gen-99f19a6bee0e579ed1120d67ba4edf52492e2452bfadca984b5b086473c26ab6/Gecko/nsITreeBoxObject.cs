using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f3da0c5e-51f5-45f0-b2cd-6be3ab6847ae")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITreeBoxObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumns GetColumnsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeView GetViewAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetViewAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeView aView);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFocusedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocusedAttribute([MarshalAs(UnmanagedType.U1)] bool aFocused);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetTreeBodyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHorizontalPositionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIScriptableRegion GetSelectionRegionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFirstVisibleRow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLastVisibleRow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPageLength();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnsureRowIsVisible(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnsureCellIsVisible(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollToRow(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollByLines(int numLines);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollByPages(int numPages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollToCell(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollToColumn([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollToHorizontalPosition(int horizontalPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Invalidate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateColumn([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateRow(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateCell(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateRange(int startIndex, int endIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateColumnRange(int startIndex, int endIndex, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowAt(int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCellAt(int x, int y, ref int row, [MarshalAs(UnmanagedType.Interface)] ref nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase childElt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCoordsForCellItem(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase element, ref int x, ref int y, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCellCropped(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RowCountChanged(int index, int count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearStyleAndImageCaches();
}
