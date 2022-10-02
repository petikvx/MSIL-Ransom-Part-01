using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace d7Z;

[DesignerGenerated]
public class n4D : Form
{
	private IContainer components;

	public n4D()
	{
		Pp1();
	}

	protected override void q8S(bool k2A)
	{
		try
		{
			if (k2A && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k2A);
		}
	}

	private void Pp1()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_Text("JimenezSchedule");
	}
}
