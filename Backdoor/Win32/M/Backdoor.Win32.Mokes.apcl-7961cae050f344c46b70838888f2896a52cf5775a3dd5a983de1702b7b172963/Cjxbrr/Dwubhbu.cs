using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cjxbrr;

public class Dwubhbu : Form
{
	private IContainer xqcu = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && xqcu != null)
		{
			xqcu.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void ebur()
	{
		xqcu = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(649, 833));
		((Control)this).set_Text("Dwubhbu");
	}

	public Dwubhbu()
	{
		ebur();
	}
}
