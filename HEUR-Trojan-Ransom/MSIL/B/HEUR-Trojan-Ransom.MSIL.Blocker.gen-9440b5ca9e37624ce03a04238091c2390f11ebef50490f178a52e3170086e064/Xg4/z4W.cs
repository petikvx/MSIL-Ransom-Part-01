using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Xg4;

[DesignerGenerated]
public class z4W : Form
{
	internal IContainer f;

	public z4W()
	{
		Bm7();
	}

	protected override void r6B(bool k4R)
	{
		try
		{
			if (k4R && f != null)
			{
				f.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k4R);
		}
	}

	private void Bm7()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(563, 242));
		((Control)this).set_Name("JimenezPending");
		((Form)this).set_Text("JimenezPending");
		((Control)this).ResumeLayout(false);
	}
}
