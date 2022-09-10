using System.Diagnostics;

namespace Stealerium.Helpers;

internal sealed class CommandHelper
{
	public static string Run(string cmd, bool wait = true)
	{
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
		string result = process.StandardOutput.ReadToEnd();
		if (wait)
		{
			process.WaitForExit();
			return result;
		}
		return result;
	}
}
