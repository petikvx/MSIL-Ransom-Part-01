using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClipboardViewer;

[DefaultEvent("ClipboardChanged")]
public class ClipboardMonitor : Control
{
	private IntPtr nextClipboardViewer;

	public event EventHandler<ClipboardChangedEventArgs> ClipboardChanged;

	public ClipboardMonitor()
	{
		((Control)this).set_BackColor(Color.Red);
		((Control)this).set_Visible(false);
		nextClipboardViewer = (IntPtr)SetClipboardViewer((int)((Control)this).get_Handle());
	}

	[DllImport("User32.dll")]
	protected static extern int SetClipboardViewer(int hWndNewViewer);

	[DllImport("User32.dll", CharSet = CharSet.Auto)]
	public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

	protected override void WndProc(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		default:
			((Control)this).WndProc(ref m);
			break;
		case 781:
			if (((Message)(ref m)).get_WParam() == nextClipboardViewer)
			{
				nextClipboardViewer = ((Message)(ref m)).get_LParam();
			}
			else
			{
				SendMessage(nextClipboardViewer, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			}
			break;
		case 776:
			OnClipboardChanged();
			SendMessage(nextClipboardViewer, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			break;
		}
	}

	private void OnClipboardChanged()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IDataObject dataObject = Clipboard.GetDataObject();
			if (this.ClipboardChanged != null)
			{
				this.ClipboardChanged(this, new ClipboardChangedEventArgs(dataObject));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}
}
