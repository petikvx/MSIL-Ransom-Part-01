using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gecko;

internal class XPTabPage : TabPage
{
	[DllImport("gdi32")]
	private static extern int SetBkMode(IntPtr hdc, int nBkMode);

	[DllImport("gdi32")]
	private static extern IntPtr GetStockObject(int nIndex);

	protected override void WndProc(ref Message m)
	{
		if (Application.get_RenderWithVisualStyles() && (((Message)(ref m)).get_Msg() == 312 || ((Message)(ref m)).get_Msg() == 307))
		{
			SetBkMode(((Message)(ref m)).get_WParam(), 1);
			((Message)(ref m)).set_Result(GetStockObject(5));
		}
		else
		{
			((ScrollableControl)this).WndProc(ref m);
		}
	}
}
