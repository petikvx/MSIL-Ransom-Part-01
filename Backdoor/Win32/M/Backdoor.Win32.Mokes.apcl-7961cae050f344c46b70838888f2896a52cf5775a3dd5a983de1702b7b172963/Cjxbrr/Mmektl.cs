using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cjxbrr;

public class Mmektl : Form
{
	private IContainer yuut = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && yuut != null)
		{
			yuut.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void lfqz()
	{
		yuut = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(807, 791));
		((Control)this).set_Text("Mmektl");
	}

	public Mmektl()
	{
		lfqz();
	}
}
