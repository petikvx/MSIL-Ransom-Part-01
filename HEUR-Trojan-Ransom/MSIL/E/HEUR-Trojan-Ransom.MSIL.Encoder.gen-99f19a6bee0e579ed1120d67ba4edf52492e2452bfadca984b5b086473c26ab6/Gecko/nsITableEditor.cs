using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4805e684-49b9-11d3-9ce4-ed60bd6cb5bc")]
public interface nsITableEditor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertTableCell(int aNumber, [MarshalAs(UnmanagedType.U1)] bool aAfter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertTableColumn(int aNumber, [MarshalAs(UnmanagedType.U1)] bool aAfter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertTableRow(int aNumber, [MarshalAs(UnmanagedType.U1)] bool aAfter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTableCellContents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTableCell(int aNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTableColumn(int aNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTableRow(int aNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectTableCell();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectBlockOfCells([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aStartCell, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aEndCell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectTableRow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectTableColumn();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectTable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAllTableCells();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement SwitchTableCellHeaderType([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aSourceCell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void JoinTableCells([MarshalAs(UnmanagedType.U1)] bool aMergeNonContiguousContents);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SplitTableCell();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NormalizeTable([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCellIndexes([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aCell, ref int aRowIndex, ref int aColIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTableSize([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTable, ref int aRowCount, ref int aColCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetCellAt([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTable, int aRowIndex, int aColIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCellDataAt([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTable, int aRowIndex, int aColIndex, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMElement aCell, ref int aStartRowIndex, ref int aStartColIndex, ref int aRowSpan, ref int aColSpan, ref int aActualRowSpan, ref int aActualColSpan, [MarshalAs(UnmanagedType.U1)] ref bool aIsSelected);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetFirstRow([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTableElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetNextRow([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTableElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionAfterTableEdit([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTable, int aRow, int aCol, int aDirection, [MarshalAs(UnmanagedType.U1)] bool aSelected);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetSelectedOrParentTableElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTagName, ref int aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSelectedCellsType([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFirstSelectedCell([MarshalAs(UnmanagedType.Interface)] ref nsIDOMRange aRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFirstSelectedCellInTable(ref int aRowIndex, ref int aColIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetNextSelectedCell([MarshalAs(UnmanagedType.Interface)] ref nsIDOMRange aRange);
}
