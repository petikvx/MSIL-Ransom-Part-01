using System;

namespace ns0;

public class PrepareCellEditorEventArgs : EventArgs
{
	public readonly Cell cell_0;

	public readonly ICellEditControl icellEditControl_0;

	public PrepareCellEditorEventArgs(Cell cell_1, ICellEditControl icellEditControl_1)
	{
		cell_0 = cell_1;
		icellEditControl_0 = icellEditControl_1;
	}
}
