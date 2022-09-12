using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns12;

[DesignerGenerated]
public class Ignore : Form
{
	private IContainer icontainer_0;

	public Ignore()
	{
		((Form)this).add_Load((EventHandler)Ignore_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).set_Name("Ignore");
		((Form)this).set_Text("Ignore");
		((Control)this).ResumeLayout(false);
	}

	private void Ignore_Load(object sender, EventArgs e)
	{
	}
}
