using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace t8F;

[DesignerGenerated]
public class Cr6 : Form
{
	private IContainer components;

	public Cr6()
	{
		s5T();
	}

	[DebuggerNonUserCode]
	protected override void d2D(bool c1B)
	{
		try
		{
			if (c1B && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c1B);
		}
	}

	[DebuggerStepThrough]
	private void s5T()
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
