using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Qhvqj;

public class Form1 : Form
{
	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		new Form6().button1_Click(null, EventArgs.Empty);
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(677, 401));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
