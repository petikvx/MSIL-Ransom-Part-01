using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SniperTower;

public class GForm0 : Form
{
	private IContainer icontainer_0 = null;

	public GForm0()
	{
		method_0();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Text("FormerSniper");
	}
}
