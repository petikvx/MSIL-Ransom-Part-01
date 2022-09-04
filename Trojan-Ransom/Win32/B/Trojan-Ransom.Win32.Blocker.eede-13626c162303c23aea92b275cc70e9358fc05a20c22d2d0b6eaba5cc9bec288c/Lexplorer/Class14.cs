using System;
using System.Diagnostics;

namespace Lexplorer;

internal class Class14 : Class13
{
	private string defaultBrowserPath = string.Empty;

	public Class14()
	{
		methodTable.Add("OPEN", Open);
		methodTable.Add("CLOSE", Close);
	}

	private bool Open(Class10 props, bool forced)
	{
		if (defaultBrowserPath == string.Empty)
		{
			defaultBrowserPath = Class3.GetDefaultBrowserPath();
		}
		if (defaultBrowserPath == null)
		{
			return false;
		}
		string text = props["V"];
		string text2 = "true";
		try
		{
			text2 = props["P"];
		}
		catch
		{
			Console.WriteLine("Could not find 'P' attribute. Outdated script/version?");
		}
		if (text2 == null)
		{
			Console.WriteLine("CAN'T GET PRIVATE MODE! props[P] is null!");
			Class3.OpenInExternalProgram("-private " + text, defaultBrowserPath);
		}
		else
		{
			Console.WriteLine("PRIVATE MODE ENABLED? " + text2);
			if (text2 == "true")
			{
				Class3.OpenInExternalProgram("-private " + text, defaultBrowserPath);
			}
			else
			{
				Class3.OpenInExternalProgram(text, defaultBrowserPath);
			}
		}
		Class15 @class = new Class15();
		@class.ExecutionMethodName = "Set";
		@class.PropertyBag = new Class10 { { "V", "3000" } };
		if (!@class.Execute(forced))
		{
			return false;
		}
		IntPtr foregroundWindow = Class25.GetForegroundWindow();
		if (foregroundWindow != IntPtr.Zero)
		{
			int hMsg = 16;
			foregroundWindow = Class25.FindWindowEx(foregroundWindow, IntPtr.Zero, "DirectUIHWND", null);
			if (foregroundWindow != IntPtr.Zero)
			{
				Class25.SendMessage((int)foregroundWindow, hMsg, 0, 0);
			}
		}
		return true;
	}

	private bool Close(Class10 props, bool forced)
	{
		string pathToExecutable = Class3.GetDefaultBrowserPath();
		CloseProgram(pathToExecutable);
		return true;
	}

	private static void CloseProgram(string pathToExecutable)
	{
		string exeName = GetExeName(pathToExecutable);
		Process[] processesByName = Process.GetProcessesByName(exeName);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			if (!process.HasExited)
			{
				process.CloseMainWindow();
			}
		}
	}

	private static string GetExeName(string pathToExe)
	{
		int num = pathToExe.LastIndexOf('\\');
		int num2 = pathToExe.LastIndexOf(".exe");
		if (num != -1 && num2 != -1)
		{
			return pathToExe.Substring(num + 1, num2 - num - 1);
		}
		return null;
	}

	public override string ToString()
	{
		return $"Command type: BROWSER, Method={base.ExecutionMethodName}";
	}
}
