using System.Windows.Forms;

namespace SandboxDotNet.Helpers;

public static class TableLayoutHelper
{
	public static void RemoveArbitraryRow(TableLayoutPanel panel, int rowIndex)
	{
		if (rowIndex >= panel.get_RowCount())
		{
			return;
		}
		for (int i = 0; i < panel.get_ColumnCount(); i++)
		{
			Control controlFromPosition = panel.GetControlFromPosition(i, rowIndex);
			((ControlCollection)panel.get_Controls()).Remove(controlFromPosition);
		}
		for (int j = rowIndex + 1; j < panel.get_RowCount(); j++)
		{
			for (int k = 0; k < panel.get_ColumnCount(); k++)
			{
				Control controlFromPosition2 = panel.GetControlFromPosition(k, j);
				if (controlFromPosition2 != null)
				{
					panel.SetRow(controlFromPosition2, j - 1);
				}
			}
		}
		int num = panel.get_RowCount() - 1;
		if (((TableLayoutStyleCollection)panel.get_RowStyles()).get_Count() > num)
		{
			((TableLayoutStyleCollection)panel.get_RowStyles()).RemoveAt(num);
		}
		int rowCount = panel.get_RowCount();
		panel.set_RowCount(rowCount - 1);
	}
}
