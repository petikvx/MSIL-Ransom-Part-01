using System.Diagnostics;

namespace RFStub;

internal sealed class CommandHelper
{
	public static string Run(string cmd, bool wait = true)
	{
		string result = "";
		using (Process process = new Process())
		{
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
			result = process.StandardOutput.ReadToEnd();
			if (wait)
			{
				process.WaitForExit();
			}
		}
		return result;
	}
}
