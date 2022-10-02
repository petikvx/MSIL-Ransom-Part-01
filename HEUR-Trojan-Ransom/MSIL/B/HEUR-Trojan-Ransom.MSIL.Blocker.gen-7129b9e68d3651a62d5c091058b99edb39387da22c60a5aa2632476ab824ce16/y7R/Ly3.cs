using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace y7R;

[DesignerGenerated]
public class Ly3 : Form
{
	internal IContainer v;

	public Ly3()
	{
		Tb0();
	}

	protected override void p0W(bool Cx2)
	{
		try
		{
			if (Cx2 && v != null)
			{
				v.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cx2);
		}
	}

	private void Tb0()
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
