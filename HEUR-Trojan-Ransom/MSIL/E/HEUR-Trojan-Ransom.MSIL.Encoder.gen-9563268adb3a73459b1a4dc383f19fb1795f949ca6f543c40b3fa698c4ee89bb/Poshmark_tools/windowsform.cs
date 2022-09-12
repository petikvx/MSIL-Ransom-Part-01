using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class windowsform : Form
{
	private IContainer components = null;

	public windowsform()
	{
		InitializeComponent();
		Application.EnableVisualStyles();
		Application.Run((Form)(object)new Form1());
		((Form)this).Close();
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
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).set_Name("windowsform");
		((Control)this).set_Text("poshmark pro tools");
		((Control)this).ResumeLayout(false);
	}
}
