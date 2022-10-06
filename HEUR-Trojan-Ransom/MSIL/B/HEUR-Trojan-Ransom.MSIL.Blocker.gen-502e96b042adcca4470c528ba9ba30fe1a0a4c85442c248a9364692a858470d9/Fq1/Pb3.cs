using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Fq1;

[DesignerGenerated]
public class Pb3 : Form
{
	internal IContainer M;

	public Pb3()
	{
		d3P();
	}

	protected override void Qg3(bool r7T)
	{
		try
		{
			if (r7T && M != null)
			{
				M.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r7T);
		}
	}

	private void d3P()
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
