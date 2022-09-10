using System.Windows.Forms;

namespace QQCaptor.Tools;

internal class DoubleBufferListView : ListView
{
	public DoubleBufferListView()
	{
		((Control)this).SetStyle((ControlStyles)204800, true);
		((Control)this).UpdateStyles();
	}
}
