using System;
using System.Windows.Forms;

namespace ExciteRAN;

internal static class LineConverter
{
	[STAThread]
	private static void ResolveFile()
	{
		IconInfo.EnablePartition();
		DiskDesigner.SaveNetwork();
		MenuEventArgs.SaveNetwork((byte)ControlQueue.ResolveMenuItem(1204) != 0);
		LineType.SaveNetwork((Form)(object)new DockingPaneContext());
	}
}
