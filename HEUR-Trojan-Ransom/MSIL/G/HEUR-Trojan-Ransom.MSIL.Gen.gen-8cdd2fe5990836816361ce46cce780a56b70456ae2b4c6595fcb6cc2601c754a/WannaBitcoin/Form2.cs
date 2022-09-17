using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WannaBitcoin;

public class Form2 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private ProgressBar progressBar1;

	private Timer timer1;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Connect to sever error. Please check your interent connection or try again later.");
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		label2 = new Label();
		progressBar1 = new ProgressBar();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Taipei Sans TC Beta", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)label1).set_Location(new Point(51, 29));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(346, 34));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Connecting to the server");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Taipei Sans TC Beta", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)label2).set_Location(new Point(30, 73));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(397, 31));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("It depends your network speed");
		((Control)progressBar1).set_Location(new Point(44, 124));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(380, 46));
		((Control)progressBar1).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(470, 203));
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
