using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SL7;

public class Commands : Form
{
	private IContainer components = null;

	public Commands()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(336, 108));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Cursor(Cursors.get_IBeam());
		((Control)this).set_Name("Commands");
		((Control)this).set_Text("Commands");
		((Control)this).ResumeLayout(false);
	}
}
