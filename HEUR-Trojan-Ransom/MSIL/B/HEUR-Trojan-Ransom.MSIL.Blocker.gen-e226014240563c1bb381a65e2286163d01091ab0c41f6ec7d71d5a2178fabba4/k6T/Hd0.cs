using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace k6T;

[DesignerGenerated]
public class Hd0 : Form
{
	private IContainer components;

	public Hd0()
	{
		b3H();
	}

	[DebuggerNonUserCode]
	protected override void Hk0(bool g9B)
	{
		try
		{
			if (g9B && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g9B);
		}
	}

	[DebuggerStepThrough]
	private void b3H()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_Text("Form1");
	}
}
