using System.Diagnostics;

namespace Client.Modules.Manager;

internal sealed class CommandHelper
{
	public static string Run(string cmd, bool wait = true)
	{
		string text = "";
		using Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			FileName = "cmd.exe",
			Arguments = cmd,
			RedirectStandardError = true,
			RedirectStandardOutput = true
		};
		process.Start();
		text = process.StandardOutput.ReadToEnd();
		if (wait)
		{
			process.WaitForExit();
			return text;
		}
		return text;
	}
}
