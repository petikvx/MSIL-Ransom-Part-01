using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cjxbrr;

public class Pykngkcpv : Form
{
	private IContainer gtaf = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && gtaf != null)
		{
			gtaf.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void nvin()
	{
		gtaf = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(897, 771));
		((Control)this).set_Text("Pykngkcpv");
	}

	public Pykngkcpv()
	{
		nvin();
	}
}
