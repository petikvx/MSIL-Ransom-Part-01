using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace XinFrams_Locker;

public class Form2 : Form
{
	private IContainer components = null;

	private Label label1;

	private ProgressBar progressBar1;

	private Label label2;

	private Label label3;

	private Timer timer2;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		timer2.Start();
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		Thread.Sleep(10000);
		Form3 form = new Form3();
		((Control)form).Show();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		progressBar1 = new ProgressBar();
		label2 = new Label();
		label3 = new Label();
		timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("UD デジタル 教科書体 NK-B", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(3, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(328, 14));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Please Wait... Loading Your File:c:/users/hamu.png");
		((Control)progressBar1).set_Location(new Point(6, 36));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(485, 23));
		((Control)progressBar1).set_TabIndex(1);
		progressBar1.set_Value(64);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("UD デジタル 教科書体 NK-B", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(3, 72));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(493, 14));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Your Important Files Are Encrypting... hamu.txt.XinFrams Encrypted Succrss!");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("UD デジタル 教科書体 NK-B", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(3, 95));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(455, 14));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("WARNING!:DO NOT Trun Off Your PC! Trun Off To Your All Data Lost!");
		timer2.set_Interval(1);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(503, 119));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Please Wait...");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
