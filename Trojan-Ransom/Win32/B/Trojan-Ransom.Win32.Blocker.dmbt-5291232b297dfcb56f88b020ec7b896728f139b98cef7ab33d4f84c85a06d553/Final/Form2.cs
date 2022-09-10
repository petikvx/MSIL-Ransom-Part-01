using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Final;

public class Form2 : Form
{
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

	private Timer timer_0;

	private Label label11;

	private Label label12;

	private Label label13;

	private Label label14;

	private Label label16;

	private Label label1;

	private Panel panel1;

	private Label label4;

	private ComboBox comboBox1;

	private Panel panel2;

	private Label label26;

	private Label label25;

	private PictureBox pictureBox2;

	private Label label15;

	private Label label17;

	private Label label19;

	private Label label18;

	private Label label20;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel1;

	private Panel panel3;

	private Label label21;

	private Panel panel4;

	private Label label22;

	private PictureBox pictureBox3;

	private LinkLabel linkLabel3;

	private PictureBox pictureBox4;

	private LinkLabel linkLabel5;

	private LinkLabel linkLabel6;

	private LinkLabel linkLabel7;

	private Label label23;

	private Label label24;

	private TextBox textBox1;

	private Label label27;

	private Label label28;

	private TextBox textBox2;

	private ComboBox comboBox3;

	private ComboBox comboBox4;

	private Label label29;

	private TextBox textBox3;

	private Label label30;

	private ComboBox comboBox5;

	private Label label31;

	private Label label32;

	private Label label33;

	private Button button3;

	private TextBox textBox4;

	private Label label34;

	private Button button2;

	private GClass0 gclass0_0 = new GClass0();

	private GClass0.GStruct0 gstruct0_0;

	private string string_0;

	private Timer timer_1 = new Timer();

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
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
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected O, but got Unknown
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got Unknown
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b56: Expected O, but got Unknown
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected O, but got Unknown
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected O, but got Unknown
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Expected O, but got Unknown
		//IL_1071: Unknown result type (might be due to invalid IL or missing references)
		//IL_107b: Expected O, but got Unknown
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected O, but got Unknown
		//IL_1145: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected O, but got Unknown
		//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ec: Expected O, but got Unknown
		//IL_121b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Expected O, but got Unknown
		//IL_12b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bf: Expected O, but got Unknown
		//IL_12de: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_136b: Expected O, but got Unknown
		//IL_13e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f1: Expected O, but got Unknown
		//IL_1467: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Expected O, but got Unknown
		//IL_14e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f1: Expected O, but got Unknown
		//IL_155f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1569: Expected O, but got Unknown
		//IL_16ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f4: Expected O, but got Unknown
		//IL_176e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1778: Expected O, but got Unknown
		//IL_185d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1867: Expected O, but got Unknown
		//IL_18e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ea: Expected O, but got Unknown
		//IL_196f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1979: Expected O, but got Unknown
		//IL_1a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a15: Expected O, but got Unknown
		//IL_1a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4e: Expected O, but got Unknown
		//IL_1ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae8: Expected O, but got Unknown
		//IL_1af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b03: Expected O, but got Unknown
		//IL_1b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7e: Expected O, but got Unknown
		//IL_1d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d56: Expected O, but got Unknown
		//IL_1ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de9: Expected O, but got Unknown
		//IL_2862: Unknown result type (might be due to invalid IL or missing references)
		//IL_286c: Expected O, but got Unknown
		//IL_28e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f0: Expected O, but got Unknown
		//IL_2993: Unknown result type (might be due to invalid IL or missing references)
		//IL_299d: Expected O, but got Unknown
		//IL_2a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a76: Expected O, but got Unknown
		//IL_2b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b23: Expected O, but got Unknown
		//IL_2c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c0c: Expected O, but got Unknown
		//IL_2c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c96: Expected O, but got Unknown
		//IL_2ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb1: Expected O, but got Unknown
		//IL_2d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d2c: Expected O, but got Unknown
		//IL_2da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db1: Expected O, but got Unknown
		//IL_2e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e79: Expected O, but got Unknown
		//IL_2eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef8: Expected O, but got Unknown
		//IL_2f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f89: Expected O, but got Unknown
		//IL_3031: Unknown result type (might be due to invalid IL or missing references)
		//IL_303b: Expected O, but got Unknown
		//IL_327a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3284: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
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
		timer_0 = new Timer(icontainer_0);
		label11 = new Label();
		label12 = new Label();
		label13 = new Label();
		label14 = new Label();
		label16 = new Label();
		label1 = new Label();
		panel1 = new Panel();
		panel2 = new Panel();
		label34 = new Label();
		textBox4 = new TextBox();
		button3 = new Button();
		label32 = new Label();
		linkLabel7 = new LinkLabel();
		linkLabel2 = new LinkLabel();
		linkLabel1 = new LinkLabel();
		label20 = new Label();
		label19 = new Label();
		label18 = new Label();
		label17 = new Label();
		label15 = new Label();
		pictureBox2 = new PictureBox();
		panel3 = new Panel();
		label31 = new Label();
		label27 = new Label();
		textBox1 = new TextBox();
		label24 = new Label();
		label23 = new Label();
		linkLabel6 = new LinkLabel();
		linkLabel5 = new LinkLabel();
		pictureBox4 = new PictureBox();
		label21 = new Label();
		panel4 = new Panel();
		label33 = new Label();
		comboBox5 = new ComboBox();
		label30 = new Label();
		comboBox4 = new ComboBox();
		label29 = new Label();
		textBox3 = new TextBox();
		comboBox3 = new ComboBox();
		label28 = new Label();
		textBox2 = new TextBox();
		linkLabel3 = new LinkLabel();
		pictureBox3 = new PictureBox();
		label22 = new Label();
		comboBox1 = new ComboBox();
		label4 = new Label();
		label26 = new Label();
		label25 = new Label();
		button2 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)panel3).SuspendLayout();
		((ISupportInitialize)pictureBox4).BeginInit();
		((Control)panel4).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
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
		((Control)button1).set_Text("PAY");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		timer_0.add_Tick((EventHandler)timer_1_Tick);
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
		((Control)label1).set_Location(new Point(356, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(256, 24));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Payment for private key!");
		((Control)panel1).set_BackColor(Color.White);
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).get_Controls().Add((Control)(object)panel3);
		((Control)panel1).get_Controls().Add((Control)(object)panel4);
		((Control)panel1).get_Controls().Add((Control)(object)comboBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).set_Location(new Point(277, 57));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(432, 450));
		((Control)panel1).set_TabIndex(29);
		((Control)panel2).get_Controls().Add((Control)(object)label34);
		((Control)panel2).get_Controls().Add((Control)(object)textBox4);
		((Control)panel2).get_Controls().Add((Control)(object)button3);
		((Control)panel2).get_Controls().Add((Control)(object)label32);
		((Control)panel2).get_Controls().Add((Control)(object)linkLabel7);
		((Control)panel2).get_Controls().Add((Control)(object)linkLabel2);
		((Control)panel2).get_Controls().Add((Control)(object)linkLabel1);
		((Control)panel2).get_Controls().Add((Control)(object)label20);
		((Control)panel2).get_Controls().Add((Control)(object)label19);
		((Control)panel2).get_Controls().Add((Control)(object)label18);
		((Control)panel2).get_Controls().Add((Control)(object)label17);
		((Control)panel2).get_Controls().Add((Control)(object)label15);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel2).set_Location(new Point(10, 70));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(408, 354));
		((Control)panel2).set_TabIndex(2);
		((Control)label34).set_AutoSize(true);
		((Control)label34).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label34).set_Location(new Point(12, 247));
		((Control)label34).set_Name("label34");
		((Control)label34).set_Size(new Size(93, 15));
		((Control)label34).set_TabIndex(13);
		((Control)label34).set_Text("Transaction ID: ");
		((Control)textBox4).set_Location(new Point(105, 244));
		((TextBoxBase)textBox4).set_MaxLength(64);
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(286, 20));
		((Control)textBox4).set_TabIndex(12);
		((Control)button3).set_Location(new Point(266, 214));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(65, 23));
		((Control)button3).set_TabIndex(11);
		((Control)button3).set_Text("Copy");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)label32).set_AutoSize(true);
		((Control)label32).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label32).set_Location(new Point(161, 194));
		((Control)label32).set_Name("label32");
		((Control)label32).set_Size(new Size(30, 15));
		((Control)label32).set_TabIndex(10);
		((Control)label32).set_Text("BTC");
		linkLabel7.set_ActiveLinkColor(Color.Green);
		((Control)linkLabel7).set_AutoSize(true);
		((Control)linkLabel7).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		linkLabel7.set_LinkColor(Color.Green);
		((Control)linkLabel7).set_Location(new Point(16, 326));
		((Control)linkLabel7).set_Name("linkLabel7");
		((Control)linkLabel7).set_Size(new Size(122, 15));
		((Control)linkLabel7).set_TabIndex(9);
		((Label)linkLabel7).set_TabStop(true);
		((Control)linkLabel7).set_Text("How to get bitcoins?");
		linkLabel7.set_VisitedLinkColor(Color.Green);
		linkLabel7.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel7_LinkClicked));
		linkLabel2.set_ActiveLinkColor(Color.Green);
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		linkLabel2.set_LinkColor(Color.Green);
		((Control)linkLabel2).set_Location(new Point(16, 302));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(160, 15));
		((Control)linkLabel2).set_TabIndex(7);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("Getting started with Bitcoin");
		linkLabel2.set_VisitedLinkColor(Color.Green);
		linkLabel2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked));
		linkLabel1.set_ActiveLinkColor(Color.Green);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		linkLabel1.set_LinkColor(Color.Green);
		((Control)linkLabel1).set_Location(new Point(16, 279));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(72, 15));
		((Control)linkLabel1).set_TabIndex(6);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Home Page");
		linkLabel1.set_VisitedLinkColor(Color.Green);
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)label20).set_AutoSize(true);
		((Control)label20).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label20).set_Location(new Point(12, 218));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(253, 15));
		((Control)label20).set_TabIndex(5);
		((Control)label20).set_Text("18CJpdtdK1i5T6HvS2r6MrLZWkDW84NuKo");
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label19).set_Location(new Point(191, 194));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(169, 15));
		((Control)label19).set_TabIndex(4);
		((Control)label19).set_Text("= 300 USD to Bitcoin address");
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label18).set_Location(new Point(123, 194));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(31, 15));
		((Control)label18).set_TabIndex(3);
		((Control)label18).set_Text("0.35");
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label17).set_Location(new Point(12, 193));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(100, 15));
		((Control)label17).set_TabIndex(2);
		((Control)label17).set_Text("You have to send");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_Location(new Point(12, 98));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(386, 90));
		((Control)label15).set_TabIndex(1);
		((Control)label15).set_Text(componentResourceManager.GetString("label15.Text"));
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(66, 2));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(282, 92));
		pictureBox2.set_TabIndex(0);
		pictureBox2.set_TabStop(false);
		((Control)panel3).get_Controls().Add((Control)(object)label31);
		((Control)panel3).get_Controls().Add((Control)(object)label27);
		((Control)panel3).get_Controls().Add((Control)(object)textBox1);
		((Control)panel3).get_Controls().Add((Control)(object)label24);
		((Control)panel3).get_Controls().Add((Control)(object)label23);
		((Control)panel3).get_Controls().Add((Control)(object)linkLabel6);
		((Control)panel3).get_Controls().Add((Control)(object)linkLabel5);
		((Control)panel3).get_Controls().Add((Control)(object)pictureBox4);
		((Control)panel3).get_Controls().Add((Control)(object)label21);
		((Control)panel3).set_Location(new Point(10, 70));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(408, 354));
		((Control)panel3).set_TabIndex(8);
		((Control)label31).set_AutoSize(true);
		((Control)label31).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label31).set_Location(new Point(171, 206));
		((Control)label31).set_Name("label31");
		((Control)label31).set_Size(new Size(60, 16));
		((Control)label31).set_TabIndex(13);
		((Control)label31).set_Text("400 USD");
		((Control)label27).set_AutoSize(true);
		((Control)label27).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label27).set_ForeColor(Color.Maroon);
		((Control)label27).set_Location(new Point(9, 293));
		((Control)label27).set_Name("label27");
		((Control)label27).set_Size(new Size(377, 14));
		((Control)label27).set_TabIndex(12);
		((Control)label27).set_Text("Make sure you entered the payment information correctly and click <<PAY>>.");
		((Control)textBox1).set_Location(new Point(169, 242));
		((TextBoxBase)textBox1).set_MaxLength(16);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(207, 20));
		((Control)textBox1).set_TabIndex(11);
		((Control)label24).set_AutoSize(true);
		((Control)label24).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label24).set_Location(new Point(8, 245));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(147, 14));
		((Control)label24).set_TabIndex(10);
		((Control)label24).set_Text("Enter the MoneyPak number: ");
		((Control)label23).set_AutoSize(true);
		((Control)label23).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label23).set_Location(new Point(8, 207));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(107, 14));
		((Control)label23).set_TabIndex(8);
		((Control)label23).set_Text("Amount of payment: ");
		linkLabel6.set_ActiveLinkColor(Color.Green);
		((Control)linkLabel6).set_AutoSize(true);
		((Control)linkLabel6).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		linkLabel6.set_LinkColor(Color.Green);
		((Control)linkLabel6).set_Location(new Point(8, 176));
		((Control)linkLabel6).set_Name("linkLabel6");
		((Control)linkLabel6).set_Size(new Size(142, 15));
		((Control)linkLabel6).set_TabIndex(7);
		((Label)linkLabel6).set_TabStop(true);
		((Control)linkLabel6).set_Text("MoneyPak store locator");
		linkLabel6.set_VisitedLinkColor(Color.Green);
		linkLabel6.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel6_LinkClicked));
		linkLabel5.set_ActiveLinkColor(Color.Green);
		((Control)linkLabel5).set_AutoSize(true);
		((Control)linkLabel5).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		linkLabel5.set_LinkColor(Color.Green);
		((Control)linkLabel5).set_Location(new Point(9, 156));
		((Control)linkLabel5).set_Name("linkLabel5");
		((Control)linkLabel5).set_Size(new Size(72, 15));
		((Control)linkLabel5).set_TabIndex(6);
		((Label)linkLabel5).set_TabStop(true);
		((Control)linkLabel5).set_Text("Home Page");
		linkLabel5.set_VisitedLinkColor(Color.Green);
		linkLabel5.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel5_LinkClicked));
		pictureBox4.set_Image((Image)componentResourceManager.GetObject("pictureBox4.Image"));
		((Control)pictureBox4).set_Location(new Point(41, 3));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(335, 91));
		pictureBox4.set_TabIndex(1);
		pictureBox4.set_TabStop(false);
		((Control)label21).set_AutoSize(true);
		((Control)label21).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label21).set_Location(new Point(8, 104));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(397, 42));
		((Control)label21).set_TabIndex(0);
		((Control)label21).set_Text(componentResourceManager.GetString("label21.Text"));
		((Control)panel4).get_Controls().Add((Control)(object)label33);
		((Control)panel4).get_Controls().Add((Control)(object)comboBox5);
		((Control)panel4).get_Controls().Add((Control)(object)label30);
		((Control)panel4).get_Controls().Add((Control)(object)comboBox4);
		((Control)panel4).get_Controls().Add((Control)(object)label29);
		((Control)panel4).get_Controls().Add((Control)(object)textBox3);
		((Control)panel4).get_Controls().Add((Control)(object)comboBox3);
		((Control)panel4).get_Controls().Add((Control)(object)label28);
		((Control)panel4).get_Controls().Add((Control)(object)textBox2);
		((Control)panel4).get_Controls().Add((Control)(object)linkLabel3);
		((Control)panel4).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel4).get_Controls().Add((Control)(object)label22);
		((Control)panel4).set_Location(new Point(10, 70));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(408, 354));
		((Control)panel4).set_TabIndex(34);
		((Control)label33).set_AutoSize(true);
		((Control)label33).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label33).set_ForeColor(Color.Maroon);
		((Control)label33).set_Location(new Point(8, 235));
		((Control)label33).set_Name("label33");
		((Control)label33).set_Size(new Size(372, 15));
		((Control)label33).set_TabIndex(20);
		((Control)label33).set_Text("You need to buy 2 vouchers value of 200 each and click <<PAY>>.");
		comboBox5.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox5).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox5).set_FormattingEnabled(true);
		comboBox5.get_Items().AddRange(new object[244]
		{
			"AF", "AX", "AL", "DZ", "AS", "AD", "AO", "AI", "AQ", "AG",
			"AR", "AM", "AW", "AU", "AT", "AZ", "BS", "BH", "BD", "BB",
			"BY", "BE", "BZ", "BJ", "BM", "BT", "BO", "BA", "BW", "BV",
			"BR", "IO", "BN", "BG", "BF", "BI", "KH", "CM", "CA", "CV",
			"KY", "CF", "TD", "CL", "CN", "CX", "CC", "CO", "KM", "CG",
			"CD", "CK", "CR", "CI", "HR", "CU", "CY", "CZ", "DK", "DJ",
			"DM", "DO", "EC", "EG", "SV", "GQ", "ER", "EE", "ET", "FK",
			"FO", "FJ", "FI", "FR", "GF", "PF", "TF", "GA", "GM", "GE",
			"DE", "GH", "GI", "GR", "GL", "GD", "GP", "GU", "GT", "GG",
			"GN", "GW", "GY", "HT", "HM", "VA", "HN", "HK", "HU", "IS",
			"IN", "ID", "IR", "IQ", "IE", "IM", "IL", "IT", "JM", "JP",
			"JE", "JO", "KZ", "KE", "KI", "KP", "KR", "KW", "KG", "LA",
			"LV", "LB", "LS", "LR", "LY", "LI", "LT", "LU", "MO", "MK",
			"MG", "MW", "MY", "MV", "ML", "MT", "MH", "MQ", "MR", "MU",
			"YT", "MX", "FM", "MD", "MC", "MN", "ME", "MS", "MA", "MZ",
			"MM", "NA", "NR", "NP", "NL", "AN", "NC", "NZ", "NI", "NE",
			"NG", "NU", "NF", "MP", "NO", "OM", "PK", "PW", "PS", "PA",
			"PG", "PY", "PE", "PH", "PN", "PL", "PT", "PR", "QA", "RE",
			"RO", "RU", "RW", "SH", "KN", "LC", "PM", "VC", "WS", "SM",
			"ST", "SA", "SN", "RS", "SC", "SL", "SG", "SK", "SI", "SB",
			"SO", "ZA", "GS", "ES", "LK", "SD", "SR", "SJ", "SZ", "SE",
			"CH", "SY", "TW", "TJ", "TZ", "TH", "TL", "TG", "TK", "TO",
			"TT", "TN", "TR", "TM", "TC", "TV", "UG", "UA", "AE", "GB",
			"US", "UM", "UY", "UZ", "VU", "VE", "VN", "VG", "VI", "WF",
			"EH", "YE", "ZM", "ZW"
		});
		((Control)comboBox5).set_Location(new Point(291, 324));
		((Control)comboBox5).set_Name("comboBox5");
		((Control)comboBox5).set_Size(new Size(47, 24));
		((Control)comboBox5).set_TabIndex(19);
		((Control)label30).set_AutoSize(true);
		((Control)label30).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label30).set_Location(new Point(12, 333));
		((Control)label30).set_Name("label30");
		((Control)label30).set_Size(new Size(273, 15));
		((Control)label30).set_TabIndex(18);
		((Control)label30).set_Text("Please choose country where UKASH is bought: ");
		comboBox4.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox4).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox4).set_FormattingEnabled(true);
		comboBox4.get_Items().AddRange(new object[3] { "EUR", "GBP", "USD" });
		((Control)comboBox4).set_Location(new Point(47, 295));
		((Control)comboBox4).set_Name("comboBox4");
		((Control)comboBox4).set_Size(new Size(47, 24));
		((Control)comboBox4).set_TabIndex(17);
		((Control)label29).set_AutoSize(true);
		((Control)label29).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label29).set_Location(new Point(12, 298));
		((Control)label29).set_Name("label29");
		((Control)label29).set_Size(new Size(29, 16));
		((Control)label29).set_TabIndex(16);
		((Control)label29).set_Text("200");
		((Control)textBox3).set_Location(new Point(111, 299));
		((TextBoxBase)textBox3).set_MaxLength(19);
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(207, 20));
		((Control)textBox3).set_TabIndex(15);
		comboBox3.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox3).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox3).set_FormattingEnabled(true);
		comboBox3.get_Items().AddRange(new object[3] { "EUR", "GBP", "USD" });
		((Control)comboBox3).set_Location(new Point(47, 258));
		((Control)comboBox3).set_Name("comboBox3");
		((Control)comboBox3).set_Size(new Size(47, 24));
		((Control)comboBox3).set_TabIndex(14);
		((Control)label28).set_AutoSize(true);
		((Control)label28).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label28).set_Location(new Point(12, 261));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(29, 16));
		((Control)label28).set_TabIndex(13);
		((Control)label28).set_Text("200");
		((Control)textBox2).set_Location(new Point(111, 262));
		((TextBoxBase)textBox2).set_MaxLength(19);
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(207, 20));
		((Control)textBox2).set_TabIndex(12);
		linkLabel3.set_ActiveLinkColor(Color.Green);
		((Control)linkLabel3).set_AutoSize(true);
		((Control)linkLabel3).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		linkLabel3.set_LinkColor(Color.Green);
		((Control)linkLabel3).set_Location(new Point(11, 211));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(72, 15));
		((Control)linkLabel3).set_TabIndex(2);
		((Label)linkLabel3).set_TabStop(true);
		((Control)linkLabel3).set_Text("Home Page");
		linkLabel3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked));
		pictureBox3.set_Image((Image)componentResourceManager.GetObject("pictureBox3.Image"));
		((Control)pictureBox3).set_Location(new Point(114, 3));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(176, 92));
		pictureBox3.set_TabIndex(1);
		pictureBox3.set_TabStop(false);
		((Control)label22).set_AutoSize(true);
		((Control)label22).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label22).set_Location(new Point(8, 98));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(399, 105));
		((Control)label22).set_TabIndex(0);
		((Control)label22).set_Text(componentResourceManager.GetString("label22.Text"));
		comboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox1).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[3] { "BitCoin (most cheap option)", "MoneyPak (USA only)", "Ukash" });
		((Control)comboBox1).set_Location(new Point(10, 28));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(408, 24));
		((Control)comboBox1).set_TabIndex(1);
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(7, 9));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(279, 14));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("Choose a convenient payment method and click Next >>:");
		((Control)label26).set_AutoSize(true);
		((Control)label26).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label26).set_ForeColor(Color.Yellow);
		((Control)label26).set_Location(new Point(84, 400));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(29, 24));
		((Control)label26).set_TabIndex(33);
		((Control)label26).set_Text("d.");
		((Control)label25).set_AutoSize(true);
		((Control)label25).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label25).set_ForeColor(Color.Yellow);
		((Control)label25).set_Location(new Point(54, 400));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(34, 24));
		((Control)label25).set_TabIndex(32);
		((Control)label25).set_Text("00");
		((Control)button2).set_BackColor(Color.RoyalBlue);
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(420, 520));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(140, 39));
		((Control)button2).set_TabIndex(34);
		((Control)button2).set_Text("<< Back");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(721, 573));
		((Control)this).get_Controls().Add((Control)(object)button2);
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
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("CryptoLocker");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((ISupportInitialize)pictureBox4).EndInit();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((ISupportInitialize)pictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form2()
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

	private void Form2_Load(object sender, EventArgs e)
	{
		method_0();
		string_0 = "http://" + gclass0_0.method_4() + "/";
		gclass0_0.method_15(string_0);
		gclass0_0.dateTime_0 = DateTime.Now.AddSeconds(gclass0_0.int_0);
		timer_1.set_Interval(1000);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_1.Start();
		((Control)label3).set_Text(gclass0_0.dateTime_0.ToString());
		((ListControl)comboBox1).set_SelectedIndex(0);
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		gclass0_0.int_0--;
		TimeSpan timeSpan = TimeSpan.FromSeconds(gclass0_0.int_0);
		if (gclass0_0.int_0 < 0)
		{
			timer_1.Stop();
			return;
		}
		((Control)label25).set_Text(timeSpan.Days.ToString());
		((Control)label6).set_Text(timeSpan.Hours.ToString());
		((Control)label8).set_Text(timeSpan.Minutes.ToString());
		((Control)label10).set_Text(timeSpan.Seconds.ToString());
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		Form3 form = new Form3();
		gstruct0_0.int_0 = ((ListControl)comboBox1).get_SelectedIndex();
		if (((ListControl)comboBox1).get_SelectedIndex() == 0)
		{
			if (((Control)textBox4).get_Text().Length == 64)
			{
				gstruct0_0.string_0 = ((Control)textBox4).get_Text();
				flag3 = true;
			}
			else
			{
				MessageBox.Show("Transaction ID must be 64 digits!", "BitCoin", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else if (((ListControl)comboBox1).get_SelectedIndex() == 1)
		{
			if (((Control)textBox1).get_Text().Length >= 12 && ((Control)textBox1).get_Text().Length <= 16 && gclass0_0.method_0(((Control)textBox1).get_Text()))
			{
				gstruct0_0.string_1 = ((Control)textBox1).get_Text();
				flag = true;
			}
			else
			{
				MessageBox.Show("Voucher code must be between 12 and 16 digits!", "MoneyPak", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else if (((ListControl)comboBox1).get_SelectedIndex() == 2)
		{
			if (((Control)textBox2).get_Text().Length == 19 && ((Control)textBox3).get_Text().Length == 19 && ((Control)comboBox5).get_Text() != "")
			{
				gstruct0_0.string_4 = ((Control)comboBox3).get_Text();
				gstruct0_0.string_5 = ((Control)comboBox4).get_Text();
				gstruct0_0.string_6 = ((Control)comboBox5).get_Text();
				gstruct0_0.string_2 = ((Control)textBox2).get_Text();
				gstruct0_0.string_3 = ((Control)textBox3).get_Text();
				flag2 = true;
			}
			else
			{
				MessageBox.Show("Voucher code must be 19 digits and country must be selected!", "Ukash", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		if (flag || flag2 || flag3)
		{
			((Control)button1).set_Enabled(false);
			((Control)button2).set_Enabled(false);
			gclass0_0.method_14(string_0, gstruct0_0);
			((Control)form).Show();
			((Control)this).Hide();
		}
	}

	private void method_0()
	{
		((Control)panel2).Hide();
		((Control)panel3).Hide();
		((Control)panel4).Hide();
	}

	private void method_1()
	{
		((Control)panel3).Hide();
		((Control)panel3).set_Visible(false);
		((Control)panel4).Hide();
		((Control)panel4).set_Visible(false);
		((Control)panel2).Show();
		((Control)panel2).BringToFront();
		((Control)label20).set_Text(gclass0_0.string_4);
	}

	private void method_2()
	{
		((Control)panel2).Hide();
		((Control)panel2).set_Visible(false);
		((Control)panel4).Hide();
		((Control)panel4).set_Visible(false);
		((Control)panel3).Show();
		((Control)panel3).BringToFront();
	}

	private void method_3()
	{
		((Control)panel2).Hide();
		((Control)panel2).set_Visible(false);
		((Control)panel3).Hide();
		((Control)panel3).set_Visible(false);
		((Control)panel4).Show();
		((Control)panel4).BringToFront();
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)comboBox1).get_SelectedIndex() == 0)
		{
			method_1();
		}
		else if (((ListControl)comboBox1).get_SelectedIndex() == 1)
		{
			method_2();
		}
		else if (((ListControl)comboBox1).get_SelectedIndex() == 2)
		{
			method_3();
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://bitcoin.org/en/");
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://bitcoin.org/en/getting-started");
	}

	private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://howtobuybitcoins.info/");
	}

	private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.moneypak.com");
	}

	private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.moneypak.com/storelocator.aspx");
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.ukash.com");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Control)button1).set_Enabled(false);
		((Control)button2).set_Enabled(false);
		Form1 form = new Form1();
		((Control)form).Show();
		((Control)this).Hide();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)label20).get_Text());
	}
}
