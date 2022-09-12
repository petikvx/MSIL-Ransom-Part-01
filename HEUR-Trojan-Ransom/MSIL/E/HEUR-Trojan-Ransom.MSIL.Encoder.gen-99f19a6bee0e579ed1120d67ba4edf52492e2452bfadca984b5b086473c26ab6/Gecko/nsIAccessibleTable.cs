using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("cb0bf7b9-117e-40e2-9e46-189c3d43ce4a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleTable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetCaptionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSummaryAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSummary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColumnCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetCellAt(int rowIndex, int columnIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCellIndexAt(int rowIndex, int columnIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColumnIndexAt(int cellIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowIndexAt(int cellIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRowAndColumnIndicesAt(int cellIndex, ref int rowIndex, ref int columnIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColumnExtentAt(int row, int column);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowExtentAt(int row, int column);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetColumnDescription(int columnIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRowDescription(int rowIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsColumnSelected(int columnIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsRowSelected(int rowIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCellSelected(int rowIndex, int columnIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSelectedCellCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSelectedColumnCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSelectedRowCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetSelectedCellsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelectedCellIndices(ref uint cellsArraySize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref int[] cellsArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelectedColumnIndices(ref uint columnsArraySize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref int[] columnsArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelectedRowIndices(ref uint rowsArraySize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref int[] rowsArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectRow(int rowIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectColumn(int columnIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnselectRow(int rowIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnselectColumn(int columnIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsProbablyForLayout();
}
