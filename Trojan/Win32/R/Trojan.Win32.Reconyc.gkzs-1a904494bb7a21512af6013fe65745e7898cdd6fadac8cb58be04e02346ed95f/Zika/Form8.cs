using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zika;

public class Form8 : Form
{
	private IContainer components;

	private Timer timer1;

	private Label label1;

	public Form8()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Form8_Load(object sender, EventArgs e)
	{
		((Control)this).set_Top(0);
		((Control)this).set_Left(0);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		string text = "";
		Random random = new Random();
		for (int i = 0; i < Screen.get_PrimaryScreen().get_Bounds().Width * Screen.get_PrimaryScreen().get_Bounds().Height / 50; i++)
		{
			int num = random.Next(0, 190);
			if (num >= 95)
			{
				num += 33;
			}
			num += 33;
			text += char.ConvertFromUtf32(num);
		}
		((Control)label1).set_Text(text);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		label1 = new Label();
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(15000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Dock((DockStyle)5);
		((Control)label1).set_Font(new Font("Consolas", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Silver);
		((Control)label1).set_Location(new Point(0, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(284, 261));
		((Control)label1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form8");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form8");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form8_Load);
		((Control)this).ResumeLayout(false);
	}
}
