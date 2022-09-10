using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace exersice;

internal class Form1 : Form
{
	private IContainer components = null;

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
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}
}
