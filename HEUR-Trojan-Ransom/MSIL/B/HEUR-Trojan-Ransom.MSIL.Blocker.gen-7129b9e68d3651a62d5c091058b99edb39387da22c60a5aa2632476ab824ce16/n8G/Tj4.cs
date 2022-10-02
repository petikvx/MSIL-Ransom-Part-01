using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace n8G;

[DesignerGenerated]
public class Tj4 : Form
{
	internal IContainer v;

	public Tj4()
	{
		Ho7();
	}

	protected override void b5N(bool Yq9)
	{
		try
		{
			if (Yq9 && v != null)
			{
				v.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Yq9);
		}
	}

	private void Ho7()
	{
		IContainer container = (v = new Container());
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_Text("JimenezSchedule");
	}
}
