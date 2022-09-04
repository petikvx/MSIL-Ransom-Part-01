using System;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns4;

namespace ns2;

internal sealed class Control0 : Control
{
	private IntPtr intptr_0;

	internal EventHandler<EventArgs0> eventHandler_0;

	public Control0()
	{
		((Control)this).set_BackColor(Color.Red);
		((Control)this).set_Visible(false);
		intptr_0 = (IntPtr)Class23.SetClipboardViewer((int)((Control)this).get_Handle());
	}

	void Control.Dispose(bool disposing)
	{
		Class23.ChangeClipboardChain(((Control)this).get_Handle(), intptr_0);
	}

	void Control.WndProc(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		default:
			((Control)this).WndProc(ref m);
			break;
		case 781:
			if (((Message)(ref m)).get_WParam() == intptr_0)
			{
				intptr_0 = ((Message)(ref m)).get_LParam();
			}
			else
			{
				Class23.SendMessage(intptr_0, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			}
			break;
		case 776:
			Class23.smethod_103(this);
			Class23.SendMessage(intptr_0, ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			break;
		}
	}
}
