using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm0 : Form
{
	private Screen screen_0;

	private IContainer icontainer_0;

	public GForm0(Screen screen_1)
	{
		screen_0 = screen_1;
		method_0();
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		((Form)this).set_Location(screen_0.get_WorkingArea().Location);
		((Form)this).set_TopMost(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_WindowState((FormWindowState)2);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name(Class6.smethod_0(-1183834834));
		((Control)this).set_Text(Class6.smethod_0(-1183834834));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
	}
}
