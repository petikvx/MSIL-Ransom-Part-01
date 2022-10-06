using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace As6;

[DesignerGenerated]
public class Wj1 : Form
{
	internal IContainer M;

	public Wj1()
	{
		e8E();
	}

	protected override void Rm0(bool x9Y)
	{
		try
		{
			if (x9Y && M != null)
			{
				M.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x9Y);
		}
	}

	private void e8E()
	{
		IContainer container = (M = new Container());
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_Text("JimenezSchedule");
	}
}
