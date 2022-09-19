using System.Diagnostics;

namespace wg;

public static class PS
{
	public static bool RedirectOutput { get; set; }

	private static string Execute(string path, string arguments, bool wait)
	{
		try
		{
			Process process = StartHidden(path, arguments);
			if (wait)
			{
				process.WaitForExit();
				return process.StandardOutput.ReadToEnd();
			}
			return null;
		}
		catch
		{
			return "";
		}
	}

	public static string ExecuteAndWait(string path, string arguments)
	{
		return Execute(path, arguments, wait: true);
	}

	public static void ExecuteAndForget(string path, string arguments)
	{
		Execute(path, arguments, wait: false);
	}

	public static Process StartHidden(string path, string arguments)
	{
		Process process = new Process();
		process.StartInfo.FileName = path;
		process.StartInfo.Arguments = arguments;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = RedirectOutput;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		return process;
	}

	static PS()
	{
	}
}
