using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm0 : Form
{
	private IContainer icontainer_0;

	public GForm0()
	{
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(968, 634));
		((Control)this).set_Text("Ucerzaehpkrgw");
	}
}
