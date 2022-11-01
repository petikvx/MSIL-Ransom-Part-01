using System.Diagnostics;

namespace PenterWare.Utils;

internal class ProcessUtils
{
	public static void ExecuteCommandLine(string commandline, out string output, out int exitCode)
	{
		GeneralUtils.Log("Executing hidden command " + commandline);
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c " + commandline + " 2>&1";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		output = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		exitCode = process.ExitCode;
	}
}
