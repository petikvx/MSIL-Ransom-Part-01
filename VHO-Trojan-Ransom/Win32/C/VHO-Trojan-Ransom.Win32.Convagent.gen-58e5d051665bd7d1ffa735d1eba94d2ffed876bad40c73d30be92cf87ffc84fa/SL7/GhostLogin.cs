using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SL7;

public class GhostLogin : Form
{
	private IContainer components = null;

	public GhostLogin()
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
		((Form)this).set_ClientSize(new Size(399, 260));
		((Control)this).set_Name("GhostLogin");
		((Control)this).set_Text("GhostLogin");
		((Control)this).ResumeLayout(false);
	}
}
