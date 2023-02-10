using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace g3E7;

[DesignerGenerated]
public class r2Z4 : Form
{
	private IContainer components;

	public r2Z4()
	{
		k2NJ();
	}

	[DebuggerNonUserCode]
	protected override void Qk42(bool f2MC)
	{
		try
		{
			if (f2MC && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f2MC);
		}
	}

	[DebuggerStepThrough]
	private void k2NJ()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(936, 565));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Teacher_Dashboard");
		((Form)this).set_Text("Teacher_Dashboard");
		((Control)this).ResumeLayout(false);
	}
}
