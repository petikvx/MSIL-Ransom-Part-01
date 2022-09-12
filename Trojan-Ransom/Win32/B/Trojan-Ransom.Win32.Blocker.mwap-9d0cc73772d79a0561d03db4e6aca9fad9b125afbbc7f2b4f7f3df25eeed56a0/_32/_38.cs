using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace _32;

internal class _38
{
	private enum CtrlType
	{
		CTRL_C_EVENT = 0,
		CTRL_BREAK_EVENT = 1,
		CTRL_CLOSE_EVENT = 2,
		CTRL_LOGOFF_EVENT = 5,
		CTRL_SHUTDOWN_EVENT = 6
	}

	private delegate bool EventHandler(CtrlType sig);

	private static EventHandler _72;

	private static Process _16;

	[DllImport("Kernel32")]
	private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);

	private static bool _82(CtrlType sig)
	{
		try
		{
			if (_16 != null)
			{
				Console.WriteLine("Aborting...");
				_16.Kill();
			}
		}
		catch
		{
		}
		return true;
	}

	private static string _93(string _17)
	{
		return Encoding.Unicode.GetString(Convert.FromBase64String(_17));
	}

	private static string _94(string _17)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(_17);
		return Convert.ToBase64String(bytes);
	}

	private static void Main(string[] args)
	{
		_72 = (EventHandler)Delegate.Combine(_72, new EventHandler(_82));
		SetConsoleCtrlHandler(_72, add: true);
		string text = Guid.NewGuid().ToString();
		Environment.SetEnvironmentVariable("zumsel", text, EnvironmentVariableTarget.Process);
		string location = Assembly.GetExecutingAssembly().Location;
		string text2 = $"$x='{text}';$y='{location}';";
		string _89 = text2 + _93("dAByAHkAIAB7AA0ACgAgACAAaQBmACAAKABbAEUAbgB2AGkAcgBvAG4AbQBlAG4AdABdADoAOgBWAGUAcgBzAGkAbwBuAC4ATQBhAGoAbwByACAALQBnAGUAIAA0ACkADQAKACAAIAB7ACAAJABuAHUAbABsACAAPQAgAFsAUgBlAGYAbABlAGMAdABpAG8AbgAuAEEAcwBzAGUAbQBiAGwAeQBdADoAOgBVAG4AcwBhAGYAZQBMAG8AYQBkAEYAcgBvAG0AKAAkAHkAKQAgAH0AIABlAGwAcwBlACAAewAgACQAbgB1AGwAbAAgAD0AIABbAFIAZQBmAGwAZQBjAHQAaQBvAG4ALgBBAHMAcwBlAG0AYgBsAHkAXQA6ADoATABvAGEAZABGAGkAbABlACgAJAB5ACkAfQANAAoAIAAgAC4AIAAoAFsAXwAzADIALgBfADgAOABdADoAOgBfADcANAAoACQAeAApACkADQAKACAAIABlAHgAaQB0ACAAJABMAEEAUwBUAEUAWABJAFQAQwBPAEQARQANAAoAfQAgAA0ACgBjAGEAdABjAGgAIABbAE4AbwB0AFMAdQBwAHAAbwByAHQAZQBkAEUAeABjAGUAcAB0AGkAbwBuAF0ADQAKAHsADQAKACAAIABXAHIAaQB0AGUALQBIAG8AcwB0ACAAJwBBAHAAcABsAGkAYwBhAHQAaQBvAG4AIABsAG8AYwBhAHQAaQBvAG4AIABpAHMAIAB1AG4AdAByAHUAcwB0AGUAZAAuACAAQwBvAHAAeQAgAGYAaQBsAGUAIAB0AG8AIABhACAAbABvAGMAYQBsACAAZAByAGkAdgBlACwAIABhAG4AZAAgAHQAcgB5ACAAYQBnAGEAaQBuAC4AJwAgAC0ARgBvAHIAZQBnAHIAbwB1AG4AZABDAG8AbABvAHIAIABSAGUAZAANAAoAfQANAAoAYwBhAHQAYwBoACAAewANAAoAIAAgAFcAcgBpAHQAZQAtAEgAbwBzAHQAIAAoACIARQByAHIAbwByADoAIAAiACAAKwAgACQAXwAuAEUAeABjAGUAcAB0AGkAbwBuAC4ATQBlAHMAcwBhAGcAZQApACAALQBGAG8AcgBlACAAUgBlAGQAIAANAAoAfQA=");
		string text3 = "";
		if (args != null && args.Length == 1 && args[0].Trim() == "/?")
		{
			text3 = "-?";
		}
		else if (args != null && args.Length > 0)
		{
			foreach (string text4 in args)
			{
				text3 = ((!text4.Contains(" ")) ? (text3 + text4 + " ") : (text3 + "\"" + text4 + "\" "));
			}
		}
		Environment.SetEnvironmentVariable("willi", text3, EnvironmentVariableTarget.Process);
		string fileName = Path.Combine(Environment.SystemDirectory, "windowspowershell\\v1.0\\powershell.exe");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = fileName;
		processStartInfo.Arguments = "-sta -noprofile -executionpolicy bypass -encodedcommand " + _94(_89);
		processStartInfo.UseShellExecute = true;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		ProcessStartInfo startInfo = processStartInfo;
		try
		{
			_16 = Process.Start(startInfo);
			try
			{
				if (_16 != null && !_16.HasExited)
				{
					_16.WaitForExit();
				}
			}
			finally
			{
				try
				{
					if (_16 != null && !_16.HasExited)
					{
						_16.Kill();
					}
				}
				catch
				{
				}
			}
			try
			{
				if (_16 != null)
				{
					Environment.ExitCode = _16.ExitCode;
					Environment.Exit(_16.ExitCode);
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Unable to launch application: " + ex.Message);
		}
	}
}
